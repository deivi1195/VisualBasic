<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PortadaSlot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PortadaSlot))
        Me.btnEmpezar = New System.Windows.Forms.Button()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEmpezar
        '
        Me.btnEmpezar.BackColor = System.Drawing.Color.Transparent
        Me.btnEmpezar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpezar.FlatAppearance.BorderSize = 0
        Me.btnEmpezar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEmpezar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEmpezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpezar.Font = New System.Drawing.Font("Broadway", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpezar.Location = New System.Drawing.Point(277, 608)
        Me.btnEmpezar.Name = "btnEmpezar"
        Me.btnEmpezar.Size = New System.Drawing.Size(201, 46)
        Me.btnEmpezar.TabIndex = 1
        Me.btnEmpezar.Text = "                     ."
        Me.btnEmpezar.UseVisualStyleBackColor = False
        '
        'btnReiniciar
        '
        Me.btnReiniciar.BackColor = System.Drawing.Color.Transparent
        Me.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReiniciar.FlatAppearance.BorderSize = 0
        Me.btnReiniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnReiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReiniciar.Font = New System.Drawing.Font("Broadway", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnReiniciar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnReiniciar.Location = New System.Drawing.Point(21, 12)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(57, 58)
        Me.btnReiniciar.TabIndex = 22
        Me.btnReiniciar.UseVisualStyleBackColor = False
        '
        'PortadaSlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(738, 693)
        Me.Controls.Add(Me.btnReiniciar)
        Me.Controls.Add(Me.btnEmpezar)
        Me.DoubleBuffered = True
        Me.Name = "PortadaSlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TragaMoneda"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEmpezar As System.Windows.Forms.Button
    Friend WithEvents btnReiniciar As System.Windows.Forms.Button
End Class
