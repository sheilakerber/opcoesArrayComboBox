<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOp1 = New System.Windows.Forms.TextBox()
        Me.txtOp3 = New System.Windows.Forms.TextBox()
        Me.txtOp2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxOpcoes = New System.Windows.Forms.ComboBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOpcaoSelecionadaCbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionar.Location = New System.Drawing.Point(38, 209)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(194, 27)
        Me.btnAdicionar.TabIndex = 0
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Opção 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Opção 3:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Opção 2:"
        '
        'txtOp1
        '
        Me.txtOp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOp1.Location = New System.Drawing.Point(118, 35)
        Me.txtOp1.Name = "txtOp1"
        Me.txtOp1.Size = New System.Drawing.Size(114, 24)
        Me.txtOp1.TabIndex = 4
        Me.txtOp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOp3
        '
        Me.txtOp3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOp3.Location = New System.Drawing.Point(118, 101)
        Me.txtOp3.Name = "txtOp3"
        Me.txtOp3.Size = New System.Drawing.Size(114, 24)
        Me.txtOp3.TabIndex = 5
        Me.txtOp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOp2
        '
        Me.txtOp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOp2.Location = New System.Drawing.Point(118, 68)
        Me.txtOp2.Name = "txtOp2"
        Me.txtOp2.Size = New System.Drawing.Size(114, 24)
        Me.txtOp2.TabIndex = 6
        Me.txtOp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ComboBox com as opções:"
        '
        'cbxOpcoes
        '
        Me.cbxOpcoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxOpcoes.FormattingEnabled = True
        Me.cbxOpcoes.Location = New System.Drawing.Point(38, 167)
        Me.cbxOpcoes.Name = "cbxOpcoes"
        Me.cbxOpcoes.Size = New System.Drawing.Size(194, 24)
        Me.cbxOpcoes.TabIndex = 8
        '
        'btnLimpar
        '
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.Location = New System.Drawing.Point(38, 242)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(194, 27)
        Me.btnLimpar.TabIndex = 9
        Me.btnLimpar.Text = "Limpar campos"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(226, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Escolha uma opção para aparecer aqui:"
        '
        'txtOpcaoSelecionadaCbox
        '
        Me.txtOpcaoSelecionadaCbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpcaoSelecionadaCbox.Location = New System.Drawing.Point(38, 314)
        Me.txtOpcaoSelecionadaCbox.Name = "txtOpcaoSelecionadaCbox"
        Me.txtOpcaoSelecionadaCbox.Size = New System.Drawing.Size(194, 24)
        Me.txtOpcaoSelecionadaCbox.TabIndex = 11
        Me.txtOpcaoSelecionadaCbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 372)
        Me.Controls.Add(Me.txtOpcaoSelecionadaCbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.cbxOpcoes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOp2)
        Me.Controls.Add(Me.txtOp3)
        Me.Controls.Add(Me.txtOp1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Name = "Form1"
        Me.Text = "Array para ComboBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOp1 As System.Windows.Forms.TextBox
    Friend WithEvents txtOp3 As System.Windows.Forms.TextBox
    Friend WithEvents txtOp2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxOpcoes As System.Windows.Forms.ComboBox
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOpcaoSelecionadaCbox As System.Windows.Forms.TextBox

End Class
