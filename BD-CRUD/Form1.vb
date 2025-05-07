
Imports System.Data.Common
Imports MySql.Data.MySqlClient
Public Class Form1
    Private miConexion As MySqlConnection
    Private estudiantesDataAdapter As MySqlDataAdapter
    Private universidadDataSet As DataSet
    Private esNuevo As Boolean
    Private idFila As Integer
    Private vistaDatos As DataView
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miConexion = New MySqlConnection()
        miConexion.ConnectionString = "Server=localhost; Port=3307; Database=universidad; Uid=root; Pwd=1234;"

        estudiantesDataAdapter = New MySqlDataAdapter()
        estudiantesDataAdapter.SelectCommand = New MySqlCommand("SELECT * FROM estudiantes", miConexion)

        universidadDataSet = New DataSet()
        universidadDataSet.Tables.Add("TEstudiantes")

        estudiantesDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey

        estudiantesDataAdapter.Fill(universidadDataSet.Tables("TEstudiantes"))

        vistaDatos = universidadDataSet.Tables("TEstudiantes").DefaultView

        dgvListadoEstudiantes.DataSource = vistaDatos
        dgvListadoEstudiantes.Columns(0).Visible = False
        dgvListadoEstudiantes.Columns(4).Width = 280
        dgvListadoEstudiantes.CurrentCell = dgvListadoEstudiantes.Rows(0).Cells(1)
        cancelar()

    End Sub



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim fila As DataRow
        Dim cmd As String

        If esNuevo Then
            '1. Crear una nueva fila 
            fila = universidadDataSet.Tables("TEstudiantes").NewRow

            '2. Rellenar la fila con información
            fila("nombre") = tbNombre.Text
            fila("apellido") = tbApellido.Text
            fila("matricula") = tbMatricula.Text
            fila("carrera") = tbCarrera.Text

            '3. Agregar fila a la tabla del DataSet
            universidadDataSet.Tables("TEstudiantes").Rows.Add(fila)
            '4. Crear Comando para agregar a la BD la fila nueva
            cmd = "INSERT INTO estudiantes (nombre, apellido, matricula, carrera) VALUES (@nom, @ape, @mat, @car)"
            estudiantesDataAdapter.InsertCommand = New MySqlCommand(cmd, miConexion)
            estudiantesDataAdapter.InsertCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 45, "nombre")
            estudiantesDataAdapter.InsertCommand.Parameters.Add("@ape", MySqlDbType.VarChar, 45, "apellido")
            estudiantesDataAdapter.InsertCommand.Parameters.Add("@mat", MySqlDbType.VarChar, 20, "matricula")
            estudiantesDataAdapter.InsertCommand.Parameters.Add("@car", MySqlDbType.VarChar, 150, "carrera")
            '5. Guardar los cambios en la base de datos
            estudiantesDataAdapter.Update(universidadDataSet.Tables("TEstudiantes"))
            '6. Volver a cargar la tabla del dataset para obtener los ultimos cambios de la BD
            universidadDataSet.Tables("TEstudiantes").Clear()
            estudiantesDataAdapter.Fill(universidadDataSet.Tables("TEstudiantes"))
        Else
            '1. Seleccionar fila a guardar
            fila = universidadDataSet.Tables("TEstudiantes").Rows.Find(idFila)
            '2. Rellenar la fila con información
            fila("nombre") = tbNombre.Text
            fila("apellido") = tbApellido.Text
            fila("matricula") = tbMatricula.Text
            fila("carrera") = tbCarrera.Text

            '4. Crear el comando para modificar la fila
            cmd = "UPDATE estudiantes
                    SET Nombre = @nom, Apellido=@ape, matricula=@mat, carrera=@car
                    WHERE id=@id;"
            estudiantesDataAdapter.UpdateCommand = New MySqlCommand(cmd, miConexion)
            estudiantesDataAdapter.UpdateCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 50, "Nombre")
            estudiantesDataAdapter.UpdateCommand.Parameters.Add("@ape", MySqlDbType.VarChar, 50, "Apellido")
            estudiantesDataAdapter.UpdateCommand.Parameters.Add("@mat", MySqlDbType.VarChar, 20, "matricula")
            estudiantesDataAdapter.UpdateCommand.Parameters.Add("@car", MySqlDbType.VarChar, 150, "carrera")
            estudiantesDataAdapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "id")

            '4. Guardar los cambios en la base de datos
            estudiantesDataAdapter.Update(universidadDataSet.Tables("TEstudiantes"))

        End If
        cancelar()
    End Sub


    Sub cargarTextBox()
        Dim fila As DataGridViewRow = dgvListadoEstudiantes.CurrentRow
        idFila = fila.Cells(0).Value
        tbNombre.Text = fila.Cells(1).Value
        tbApellido.Text = fila.Cells(2).Value
        tbMatricula.Text = fila.Cells(3).Value
        tbCarrera.Text = fila.Cells(4).Value
    End Sub
    Private Sub dgvListadoEstudiantes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoEstudiantes.CellClick
        If vistaDatos.Count > 0 Then
            cargarTextBox()
        End If
    End Sub

    Sub cancelar()
        activarTextBox(False)
        btnNuevo.Enabled = True
        btnEditar.Enabled = True
        btnGuardar.Enabled = False
        btnBorrar.Enabled = True
        btnCancelar.Enabled = False
        dgvListadoEstudiantes.CurrentCell = dgvListadoEstudiantes.Rows(0).Cells(1)
        cargarTextBox()
    End Sub




    Sub activarTextBox(ByVal activo As Boolean)
        If activo = True Then
            tbNombre.Enabled = True
            tbApellido.Enabled = True
            tbMatricula.Enabled = True
            tbCarrera.Enabled = True
        Else
            tbNombre.Enabled = False
            tbApellido.Enabled = False
            tbMatricula.Enabled = False
            tbCarrera.Enabled = False
        End If
    End Sub




    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        activarTextBox(True)
        btnNuevo.Enabled = False
        btnEditar.Enabled = False
        btnBorrar.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        tbApellido.Text = ""
        tbNombre.Text = ""
        tbMatricula.Text = ""
        tbCarrera.Text = ""
        esNuevo = True
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        activarTextBox(True)
        btnNuevo.Enabled = False
        btnEditar.Enabled = False
        btnBorrar.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        esNuevo = False
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If (MessageBox.Show("Está seguro de borrar el registro?", "Borrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            universidadDataSet.Tables("TEstudiantes").Rows.Find(idFila).Delete()
            estudiantesDataAdapter.DeleteCommand = New MySqlCommand("DELETE FROM estudiantes WHERE id = @id", miConexion)
            estudiantesDataAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.BigInt, 0, "id")
            estudiantesDataAdapter.Update(universidadDataSet.Tables("TEstudiantes"))
        End If
        cancelar()
    End Sub

    Private Sub tbBuscar_TextChanged(sender As Object, e As EventArgs) Handles tbBuscar.TextChanged
        vistaDatos.RowFilter = "apellido LIKE '" + tbBuscar.Text + "%'"
        If vistaDatos.Count > 0 Then
            cargarTextBox()
        End If
    End Sub


End Class
