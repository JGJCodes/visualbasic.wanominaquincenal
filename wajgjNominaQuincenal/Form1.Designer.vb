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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.rbConIsr = New System.Windows.Forms.RadioButton()
        Me.rbSinIsr = New System.Windows.Forms.RadioButton()
        Me.lblISRT = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.lblIsr = New System.Windows.Forms.Label()
        Me.txtIsr = New System.Windows.Forms.TextBox()
        Me.lblDescT = New System.Windows.Forms.Label()
        Me.txtImss = New System.Windows.Forms.TextBox()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.txtAhorro = New System.Windows.Forms.TextBox()
        Me.lblDescu = New System.Windows.Forms.Label()
        Me.txtDescu = New System.Windows.Forms.TextBox()
        Me.lblDeduc = New System.Windows.Forms.Label()
        Me.txtDeduc = New System.Windows.Forms.TextBox()
        Me.lblNeto = New System.Windows.Forms.Label()
        Me.txtNeto = New System.Windows.Forms.TextBox()
        Me.lblEmp = New System.Windows.Forms.Label()
        Me.lblSalDia = New System.Windows.Forms.Label()
        Me.lblDiasT = New System.Windows.Forms.Label()
        Me.lblHorasE = New System.Windows.Forms.Label()
        Me.lblSueldo = New System.Windows.Forms.Label()
        Me.lblTiempoE = New System.Windows.Forms.Label()
        Me.lblPercep = New System.Windows.Forms.Label()
        Me.txtEmp = New System.Windows.Forms.TextBox()
        Me.txtSalDia = New System.Windows.Forms.TextBox()
        Me.txtDiasT = New System.Windows.Forms.TextBox()
        Me.txtHorasE = New System.Windows.Forms.TextBox()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.txtTiempoE = New System.Windows.Forms.TextBox()
        Me.txtPercep = New System.Windows.Forms.TextBox()
        Me.chkImss = New System.Windows.Forms.CheckBox()
        Me.chkInfo = New System.Windows.Forms.CheckBox()
        Me.chkAhorro = New System.Windows.Forms.CheckBox()
        Me.lblLimpiar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(373, 19)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitulo.Size = New System.Drawing.Size(94, 13)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Nomina Quincenal"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(183, 426)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 1
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(449, 64)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(270, 111)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'rbConIsr
        '
        Me.rbConIsr.AutoSize = True
        Me.rbConIsr.Location = New System.Drawing.Point(500, 101)
        Me.rbConIsr.Name = "rbConIsr"
        Me.rbConIsr.Size = New System.Drawing.Size(100, 17)
        Me.rbConIsr.TabIndex = 3
        Me.rbConIsr.TabStop = True
        Me.rbConIsr.Text = "Con ISR <20%>"
        Me.rbConIsr.UseVisualStyleBackColor = True
        '
        'rbSinIsr
        '
        Me.rbSinIsr.AutoSize = True
        Me.rbSinIsr.Location = New System.Drawing.Point(500, 141)
        Me.rbSinIsr.Name = "rbSinIsr"
        Me.rbSinIsr.Size = New System.Drawing.Size(90, 17)
        Me.rbSinIsr.TabIndex = 4
        Me.rbSinIsr.TabStop = True
        Me.rbSinIsr.Text = "Sin ISR <0%>"
        Me.rbSinIsr.UseVisualStyleBackColor = True
        '
        'lblISRT
        '
        Me.lblISRT.AutoSize = True
        Me.lblISRT.Location = New System.Drawing.Point(562, 73)
        Me.lblISRT.Name = "lblISRT"
        Me.lblISRT.Size = New System.Drawing.Size(28, 13)
        Me.lblISRT.TabIndex = 5
        Me.lblISRT.Text = "ISR:"
        '
        'ListView2
        '
        Me.ListView2.Location = New System.Drawing.Point(449, 224)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(270, 127)
        Me.ListView2.TabIndex = 6
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'lblIsr
        '
        Me.lblIsr.AutoSize = True
        Me.lblIsr.Location = New System.Drawing.Point(472, 192)
        Me.lblIsr.Name = "lblIsr"
        Me.lblIsr.Size = New System.Drawing.Size(28, 13)
        Me.lblIsr.TabIndex = 7
        Me.lblIsr.Text = "ISR:"
        '
        'txtIsr
        '
        Me.txtIsr.Location = New System.Drawing.Point(584, 185)
        Me.txtIsr.Name = "txtIsr"
        Me.txtIsr.Size = New System.Drawing.Size(100, 20)
        Me.txtIsr.TabIndex = 8
        '
        'lblDescT
        '
        Me.lblDescT.AutoSize = True
        Me.lblDescT.Location = New System.Drawing.Point(552, 231)
        Me.lblDescT.Name = "lblDescT"
        Me.lblDescT.Size = New System.Drawing.Size(64, 13)
        Me.lblDescT.TabIndex = 10
        Me.lblDescT.Text = "Descuentos"
        '
        'txtImss
        '
        Me.txtImss.Location = New System.Drawing.Point(597, 257)
        Me.txtImss.Name = "txtImss"
        Me.txtImss.Size = New System.Drawing.Size(100, 20)
        Me.txtImss.TabIndex = 13
        '
        'txtInfo
        '
        Me.txtInfo.Location = New System.Drawing.Point(597, 282)
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(100, 20)
        Me.txtInfo.TabIndex = 14
        '
        'txtAhorro
        '
        Me.txtAhorro.Location = New System.Drawing.Point(597, 310)
        Me.txtAhorro.Name = "txtAhorro"
        Me.txtAhorro.Size = New System.Drawing.Size(100, 20)
        Me.txtAhorro.TabIndex = 15
        '
        'lblDescu
        '
        Me.lblDescu.AutoSize = True
        Me.lblDescu.Location = New System.Drawing.Point(472, 376)
        Me.lblDescu.Name = "lblDescu"
        Me.lblDescu.Size = New System.Drawing.Size(67, 13)
        Me.lblDescu.TabIndex = 16
        Me.lblDescu.Text = "Descuentos:"
        '
        'txtDescu
        '
        Me.txtDescu.Location = New System.Drawing.Point(597, 369)
        Me.txtDescu.Name = "txtDescu"
        Me.txtDescu.Size = New System.Drawing.Size(100, 20)
        Me.txtDescu.TabIndex = 17
        '
        'lblDeduc
        '
        Me.lblDeduc.AutoSize = True
        Me.lblDeduc.Location = New System.Drawing.Point(472, 426)
        Me.lblDeduc.Name = "lblDeduc"
        Me.lblDeduc.Size = New System.Drawing.Size(73, 13)
        Me.lblDeduc.TabIndex = 18
        Me.lblDeduc.Text = "Deducciones:"
        '
        'txtDeduc
        '
        Me.txtDeduc.Location = New System.Drawing.Point(597, 423)
        Me.txtDeduc.Name = "txtDeduc"
        Me.txtDeduc.Size = New System.Drawing.Size(100, 20)
        Me.txtDeduc.TabIndex = 19
        '
        'lblNeto
        '
        Me.lblNeto.AutoSize = True
        Me.lblNeto.Location = New System.Drawing.Point(472, 465)
        Me.lblNeto.Name = "lblNeto"
        Me.lblNeto.Size = New System.Drawing.Size(72, 13)
        Me.lblNeto.TabIndex = 20
        Me.lblNeto.Text = "Neto a pagar:"
        '
        'txtNeto
        '
        Me.txtNeto.Location = New System.Drawing.Point(597, 465)
        Me.txtNeto.Name = "txtNeto"
        Me.txtNeto.Size = New System.Drawing.Size(100, 20)
        Me.txtNeto.TabIndex = 21
        '
        'lblEmp
        '
        Me.lblEmp.AutoSize = True
        Me.lblEmp.Location = New System.Drawing.Point(171, 80)
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.Size = New System.Drawing.Size(57, 13)
        Me.lblEmp.TabIndex = 22
        Me.lblEmp.Text = "Empleado:"
        '
        'lblSalDia
        '
        Me.lblSalDia.AutoSize = True
        Me.lblSalDia.Location = New System.Drawing.Point(171, 173)
        Me.lblSalDia.Name = "lblSalDia"
        Me.lblSalDia.Size = New System.Drawing.Size(72, 13)
        Me.lblSalDia.TabIndex = 23
        Me.lblSalDia.Text = "Salario Diario:"
        '
        'lblDiasT
        '
        Me.lblDiasT.AutoSize = True
        Me.lblDiasT.Location = New System.Drawing.Point(171, 125)
        Me.lblDiasT.Name = "lblDiasT"
        Me.lblDiasT.Size = New System.Drawing.Size(87, 13)
        Me.lblDiasT.TabIndex = 24
        Me.lblDiasT.Text = "Dias Trabajados:"
        '
        'lblHorasE
        '
        Me.lblHorasE.AutoSize = True
        Me.lblHorasE.Location = New System.Drawing.Point(171, 224)
        Me.lblHorasE.Name = "lblHorasE"
        Me.lblHorasE.Size = New System.Drawing.Size(70, 13)
        Me.lblHorasE.TabIndex = 25
        Me.lblHorasE.Text = "Horas Extras:"
        '
        'lblSueldo
        '
        Me.lblSueldo.AutoSize = True
        Me.lblSueldo.Location = New System.Drawing.Point(171, 264)
        Me.lblSueldo.Name = "lblSueldo"
        Me.lblSueldo.Size = New System.Drawing.Size(80, 13)
        Me.lblSueldo.TabIndex = 26
        Me.lblSueldo.Text = "Sueldo Quince:"
        '
        'lblTiempoE
        '
        Me.lblTiempoE.AutoSize = True
        Me.lblTiempoE.Location = New System.Drawing.Point(171, 310)
        Me.lblTiempoE.Name = "lblTiempoE"
        Me.lblTiempoE.Size = New System.Drawing.Size(72, 13)
        Me.lblTiempoE.TabIndex = 27
        Me.lblTiempoE.Text = "Tiempo Extra:"
        '
        'lblPercep
        '
        Me.lblPercep.AutoSize = True
        Me.lblPercep.Location = New System.Drawing.Point(171, 355)
        Me.lblPercep.Name = "lblPercep"
        Me.lblPercep.Size = New System.Drawing.Size(75, 13)
        Me.lblPercep.TabIndex = 28
        Me.lblPercep.Text = "Percepciones:"
        '
        'txtEmp
        '
        Me.txtEmp.Location = New System.Drawing.Point(294, 73)
        Me.txtEmp.Name = "txtEmp"
        Me.txtEmp.Size = New System.Drawing.Size(100, 20)
        Me.txtEmp.TabIndex = 29
        '
        'txtSalDia
        '
        Me.txtSalDia.Location = New System.Drawing.Point(294, 118)
        Me.txtSalDia.Name = "txtSalDia"
        Me.txtSalDia.Size = New System.Drawing.Size(100, 20)
        Me.txtSalDia.TabIndex = 30
        '
        'txtDiasT
        '
        Me.txtDiasT.Location = New System.Drawing.Point(294, 166)
        Me.txtDiasT.Name = "txtDiasT"
        Me.txtDiasT.Size = New System.Drawing.Size(100, 20)
        Me.txtDiasT.TabIndex = 31
        '
        'txtHorasE
        '
        Me.txtHorasE.Location = New System.Drawing.Point(294, 217)
        Me.txtHorasE.Name = "txtHorasE"
        Me.txtHorasE.Size = New System.Drawing.Size(100, 20)
        Me.txtHorasE.TabIndex = 32
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(294, 257)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSueldo.TabIndex = 33
        '
        'txtTiempoE
        '
        Me.txtTiempoE.Location = New System.Drawing.Point(294, 303)
        Me.txtTiempoE.Name = "txtTiempoE"
        Me.txtTiempoE.Size = New System.Drawing.Size(100, 20)
        Me.txtTiempoE.TabIndex = 34
        '
        'txtPercep
        '
        Me.txtPercep.Location = New System.Drawing.Point(294, 355)
        Me.txtPercep.Name = "txtPercep"
        Me.txtPercep.Size = New System.Drawing.Size(100, 20)
        Me.txtPercep.TabIndex = 35
        '
        'chkImss
        '
        Me.chkImss.AutoSize = True
        Me.chkImss.Location = New System.Drawing.Point(463, 260)
        Me.chkImss.Name = "chkImss"
        Me.chkImss.Size = New System.Drawing.Size(87, 17)
        Me.chkImss.TabIndex = 36
        Me.chkImss.Text = "IMSS <10%>"
        Me.chkImss.UseVisualStyleBackColor = True
        '
        'chkInfo
        '
        Me.chkInfo.AutoSize = True
        Me.chkInfo.Location = New System.Drawing.Point(464, 285)
        Me.chkInfo.Name = "chkInfo"
        Me.chkInfo.Size = New System.Drawing.Size(118, 17)
        Me.chkInfo.TabIndex = 37
        Me.chkInfo.Text = "INFONAVIT <15%>"
        Me.chkInfo.UseVisualStyleBackColor = True
        '
        'chkAhorro
        '
        Me.chkAhorro.AutoSize = True
        Me.chkAhorro.Location = New System.Drawing.Point(464, 313)
        Me.chkAhorro.Name = "chkAhorro"
        Me.chkAhorro.Size = New System.Drawing.Size(86, 17)
        Me.chkAhorro.TabIndex = 38
        Me.chkAhorro.Text = "Ahorro <5%>"
        Me.chkAhorro.UseVisualStyleBackColor = True
        '
        'lblLimpiar
        '
        Me.lblLimpiar.Location = New System.Drawing.Point(319, 426)
        Me.lblLimpiar.Name = "lblLimpiar"
        Me.lblLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.lblLimpiar.TabIndex = 39
        Me.lblLimpiar.Text = "Limpiar"
        Me.lblLimpiar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WAJGJNominaQuincenal.My.Resources.Resources.themepreview2
        Me.PictureBox1.Location = New System.Drawing.Point(22, 166)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 129)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 518)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblLimpiar)
        Me.Controls.Add(Me.chkAhorro)
        Me.Controls.Add(Me.chkInfo)
        Me.Controls.Add(Me.chkImss)
        Me.Controls.Add(Me.txtPercep)
        Me.Controls.Add(Me.txtTiempoE)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.txtHorasE)
        Me.Controls.Add(Me.txtDiasT)
        Me.Controls.Add(Me.txtSalDia)
        Me.Controls.Add(Me.txtEmp)
        Me.Controls.Add(Me.lblPercep)
        Me.Controls.Add(Me.lblTiempoE)
        Me.Controls.Add(Me.lblSueldo)
        Me.Controls.Add(Me.lblHorasE)
        Me.Controls.Add(Me.lblDiasT)
        Me.Controls.Add(Me.lblSalDia)
        Me.Controls.Add(Me.lblEmp)
        Me.Controls.Add(Me.txtNeto)
        Me.Controls.Add(Me.lblNeto)
        Me.Controls.Add(Me.txtDeduc)
        Me.Controls.Add(Me.lblDeduc)
        Me.Controls.Add(Me.txtDescu)
        Me.Controls.Add(Me.lblDescu)
        Me.Controls.Add(Me.txtAhorro)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.txtImss)
        Me.Controls.Add(Me.lblDescT)
        Me.Controls.Add(Me.txtIsr)
        Me.Controls.Add(Me.lblIsr)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.lblISRT)
        Me.Controls.Add(Me.rbSinIsr)
        Me.Controls.Add(Me.rbConIsr)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Form1"
        Me.Text = "Nomina Quincenal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents rbConIsr As System.Windows.Forms.RadioButton
    Friend WithEvents rbSinIsr As System.Windows.Forms.RadioButton
    Friend WithEvents lblISRT As System.Windows.Forms.Label
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents lblIsr As System.Windows.Forms.Label
    Friend WithEvents txtIsr As System.Windows.Forms.TextBox
    Friend WithEvents lblDescT As System.Windows.Forms.Label
    Friend WithEvents txtImss As System.Windows.Forms.TextBox
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtAhorro As System.Windows.Forms.TextBox
    Friend WithEvents lblDescu As System.Windows.Forms.Label
    Friend WithEvents txtDescu As System.Windows.Forms.TextBox
    Friend WithEvents lblDeduc As System.Windows.Forms.Label
    Friend WithEvents txtDeduc As System.Windows.Forms.TextBox
    Friend WithEvents lblNeto As System.Windows.Forms.Label
    Friend WithEvents txtNeto As System.Windows.Forms.TextBox
    Friend WithEvents lblEmp As System.Windows.Forms.Label
    Friend WithEvents lblSalDia As System.Windows.Forms.Label
    Friend WithEvents lblDiasT As System.Windows.Forms.Label
    Friend WithEvents lblHorasE As System.Windows.Forms.Label
    Friend WithEvents lblSueldo As System.Windows.Forms.Label
    Friend WithEvents lblTiempoE As System.Windows.Forms.Label
    Friend WithEvents lblPercep As System.Windows.Forms.Label
    Friend WithEvents txtEmp As System.Windows.Forms.TextBox
    Friend WithEvents txtSalDia As System.Windows.Forms.TextBox
    Friend WithEvents txtDiasT As System.Windows.Forms.TextBox
    Friend WithEvents txtHorasE As System.Windows.Forms.TextBox
    Friend WithEvents txtSueldo As System.Windows.Forms.TextBox
    Friend WithEvents txtTiempoE As System.Windows.Forms.TextBox
    Friend WithEvents txtPercep As System.Windows.Forms.TextBox
    Friend WithEvents chkImss As System.Windows.Forms.CheckBox
    Friend WithEvents chkInfo As System.Windows.Forms.CheckBox
    Friend WithEvents chkAhorro As System.Windows.Forms.CheckBox
    Friend WithEvents lblLimpiar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
