<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GALAPAGOS = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(464, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(469, 27)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ESCOJA UNA REGION PARA COMENZAR A JUGAR"
        '
        'GALAPAGOS
        '
        Me.GALAPAGOS.BackColor = System.Drawing.Color.Transparent
        Me.GALAPAGOS.Location = New System.Drawing.Point(63, 56)
        Me.GALAPAGOS.Name = "GALAPAGOS"
        Me.GALAPAGOS.Size = New System.Drawing.Size(188, 52)
        Me.GALAPAGOS.TabIndex = 6
        Me.GALAPAGOS.Text = "GALAPAGOS "
        Me.GALAPAGOS.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(439, 318)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 61)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "COSTA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(592, 204)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 54)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "SIERRA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(776, 335)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(157, 59)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "ORIENTE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(464, 421)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(384, 23)
        Me.ProgressBar1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(612, 447)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 27)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "PROGRESO "
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1124, 728)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GALAPAGOS)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Form2"
        Me.Text = "SELECCIONE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GALAPAGOS As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label2 As Label
End Class
