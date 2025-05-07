<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        tbMatricula = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        tbNombre = New TextBox()
        tbApellido = New TextBox()
        tbCarrera = New TextBox()
        GroupBox1 = New GroupBox()
        dgvListadoEstudiantes = New DataGridView()
        PictureBox1 = New PictureBox()
        tbBuscar = New TextBox()
        btnEditar = New Button()
        btnBorrar = New Button()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnCancelar = New Button()
        GroupBox1.SuspendLayout()
        CType(dgvListadoEstudiantes, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 1
        Label1.Text = "Carrera"
        ' 
        ' tbMatricula
        ' 
        tbMatricula.Location = New Point(107, 85)
        tbMatricula.Name = "tbMatricula"
        tbMatricula.Size = New Size(100, 23)
        tbMatricula.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 3
        Label2.Text = "Matricula"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(38, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 4
        Label3.Text = "Apellido"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(38, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 5
        Label4.Text = "Nombre"
        ' 
        ' tbNombre
        ' 
        tbNombre.Location = New Point(107, 25)
        tbNombre.Name = "tbNombre"
        tbNombre.Size = New Size(100, 23)
        tbNombre.TabIndex = 6
        ' 
        ' tbApellido
        ' 
        tbApellido.Location = New Point(107, 55)
        tbApellido.Name = "tbApellido"
        tbApellido.Size = New Size(100, 23)
        tbApellido.TabIndex = 7
        ' 
        ' tbCarrera
        ' 
        tbCarrera.Location = New Point(107, 114)
        tbCarrera.Name = "tbCarrera"
        tbCarrera.Size = New Size(100, 23)
        tbCarrera.TabIndex = 8
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(tbCarrera)
        GroupBox1.Controls.Add(tbApellido)
        GroupBox1.Controls.Add(tbNombre)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(tbMatricula)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(96, 15)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(238, 158)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Dato Estudiante"
        ' 
        ' dgvListadoEstudiantes
        ' 
        dgvListadoEstudiantes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvListadoEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvListadoEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvListadoEstudiantes.Location = New Point(21, 257)
        dgvListadoEstudiantes.MultiSelect = False
        dgvListadoEstudiantes.Name = "dgvListadoEstudiantes"
        dgvListadoEstudiantes.RowHeadersWidth = 51
        dgvListadoEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvListadoEstudiantes.Size = New Size(706, 146)
        dgvListadoEstudiantes.TabIndex = 10
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.find
        PictureBox1.Location = New Point(42, 201)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(52, 50)
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' tbBuscar
        ' 
        tbBuscar.Location = New Point(134, 216)
        tbBuscar.Name = "tbBuscar"
        tbBuscar.Size = New Size(580, 23)
        tbBuscar.TabIndex = 12
        ' 
        ' btnEditar
        ' 
        btnEditar.Image = My.Resources.Resources.edit
        btnEditar.ImageAlign = ContentAlignment.MiddleRight
        btnEditar.Location = New Point(381, 55)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(118, 45)
        btnEditar.TabIndex = 12
        btnEditar.Text = "Editar"
        btnEditar.TextAlign = ContentAlignment.MiddleLeft
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnBorrar
        ' 
        btnBorrar.Image = My.Resources.Resources.remove
        btnBorrar.ImageAlign = ContentAlignment.MiddleRight
        btnBorrar.Location = New Point(381, 106)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(118, 43)
        btnBorrar.TabIndex = 13
        btnBorrar.Text = "Borrar"
        btnBorrar.TextAlign = ContentAlignment.MiddleLeft
        btnBorrar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Image = My.Resources.Resources.add
        btnNuevo.ImageAlign = ContentAlignment.MiddleRight
        btnNuevo.Location = New Point(381, 4)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(118, 45)
        btnNuevo.TabIndex = 14
        btnNuevo.Text = "Nuevo"
        btnNuevo.TextAlign = ContentAlignment.MiddleLeft
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Image = My.Resources.Resources.save
        btnGuardar.ImageAlign = ContentAlignment.MiddleRight
        btnGuardar.Location = New Point(381, 155)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(118, 45)
        btnGuardar.TabIndex = 15
        btnGuardar.Text = "Guardar"
        btnGuardar.TextAlign = ContentAlignment.MiddleLeft
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Image = My.Resources.Resources.cancel
        btnCancelar.ImageAlign = ContentAlignment.MiddleRight
        btnCancelar.Location = New Point(548, 109)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(118, 43)
        btnCancelar.TabIndex = 13
        btnCancelar.Text = "Cancelar"
        btnCancelar.TextAlign = ContentAlignment.MiddleLeft
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(760, 415)
        Controls.Add(tbBuscar)
        Controls.Add(PictureBox1)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(dgvListadoEstudiantes)
        Controls.Add(btnCancelar)
        Controls.Add(btnBorrar)
        Controls.Add(btnEditar)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvListadoEstudiantes, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents tbMatricula As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents tbCarrera As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvListadoEstudiantes As DataGridView
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbBuscar As TextBox

End Class
