<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PortadaCasino
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PortadaCasino))
        Me.btnRuleta = New System.Windows.Forms.Button()
        Me.btnSlot = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRuleta
        '
        Me.btnRuleta.BackColor = System.Drawing.Color.Transparent
        Me.btnRuleta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRuleta.FlatAppearance.BorderSize = 0
        Me.btnRuleta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRuleta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRuleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRuleta.Font = New System.Drawing.Font("Broadway", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRuleta.Location = New System.Drawing.Point(181, 502)
        Me.btnRuleta.Name = "btnRuleta"
        Me.btnRuleta.Size = New System.Drawing.Size(188, 35)
        Me.btnRuleta.TabIndex = 1
        Me.btnRuleta.Text = "                           ."
        Me.btnRuleta.UseVisualStyleBackColor = False
        '
        'btnSlot
        '
        Me.btnSlot.BackColor = System.Drawing.Color.Transparent
        Me.btnSlot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSlot.FlatAppearance.BorderSize = 0
        Me.btnSlot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSlot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSlot.Font = New System.Drawing.Font("Broadway", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSlot.Location = New System.Drawing.Point(414, 503)
        Me.btnSlot.Name = "btnSlot"
        Me.btnSlot.Size = New System.Drawing.Size(177, 35)
        Me.btnSlot.TabIndex = 2
        Me.btnSlot.Text = "                           ."
        Me.btnSlot.UseVisualStyleBackColor = False
        '
        'PortadaCasino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(738, 693)
        Me.Controls.Add(Me.btnSlot)
        Me.Controls.Add(Me.btnRuleta)
        Me.DoubleBuffered = True
        Me.Name = "PortadaCasino"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deivi's Casino"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRuleta As System.Windows.Forms.Button
    Friend WithEvents btnSlot As System.Windows.Forms.Button
End Class
