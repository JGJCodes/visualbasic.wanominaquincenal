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
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.btnCalcular = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.rbConISR = New System.Windows.Forms.RadioButton
        Me.rbSinISR = New System.Windows.Forms.RadioButton
        Me.lblISRT = New System.Windows.Forms.Label
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.lblISR = New System.Windows.Forms.Label
        Me.txtISR = New System.Windows.Forms.TextBox
        Me.lblDescT = New System.Windows.Forms.Label
        Me.txtIMSS = New System.Windows.Forms.TextBox
        Me.txtINF = New System.Windows.Forms.TextBox
        Me.txtAhorro = New System.Windows.Forms.TextBox
        Me.lblDescu = New System.Windows.Forms.Label
        Me.txtDescu = New System.Windows.Forms.TextBox
        Me.lblDeduc = New System.Windows.Forms.Label
        Me.txtDeduc = New System.Windows.Forms.TextBox
        Me.lblNeto = New System.Windows.Forms.Label
        Me.txtNeto = New System.Windows.Forms.TextBox
        Me.lblEmp = New System.Windows.Forms.Label
        Me.lblSaldia = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblHorasE = New System.Windows.Forms.Label
        Me.lblSueldo = New System.Windows.Forms.Label
        Me.lblTiempoE = New System.Windows.Forms.Label
        Me.lblPercer = New System.Windows.Forms.Label
        Me.txtEmp = New System.Windows.Forms.TextBox
        Me.txtSaldia = New System.Windows.Forms.TextBox
        Me.txtDiasT = New System.Windows.Forms.TextBox
        Me.txtHorasE = New System.Windows.Forms.TextBox
        Me.txtSueldo = New System.Windows.Forms.TextBox
        Me.txtTiempoE = New System.Windows.Forms.TextBox
        Me.txtPercer = New System.Windows.Forms.TextBox
        Me.chkIMSS = New System.Windows.Forms.CheckBox
        Me.chkINFO = New System.Windows.Forms.CheckBox
        Me.chkAhorro = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(295, 18)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(94, 13)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Nomina Quincenal"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(90, 405)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 1
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(376, 50)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(270, 111)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'rbConISR
        '
        Me.rbConISR.AutoSize = True
        Me.rbConISR.Location = New System.Drawing.Point(425, 90)
        Me.rbConISR.Name = "rbConISR"
        Me.rbConISR.Size = New System.Drawing.Size(100, 17)
        Me.rbConISR.TabIndex = 3
        Me.rbConISR.TabStop = True
        Me.rbConISR.Text = "Con ISR <20%>"
        Me.rbConISR.UseVisualStyleBackColor = True
        '
        'rbSinISR
        '
        Me.rbSinISR.AutoSize = True
        Me.rbSinISR.Location = New System.Drawing.Point(425, 124)
        Me.rbSinISR.Name = "rbSinISR"
        Me.rbSinISR.Size = New System.Drawing.Size(90, 17)
        Me.rbSinISR.TabIndex = 4
        Me.rbSinISR.TabStop = True
        Me.rbSinISR.Text = "Sin ISR <0%>"
        Me.rbSinISR.UseVisualStyleBackColor = True
        '
        'lblISRT
        '
        Me.lblISRT.AutoSize = True
        Me.lblISRT.Location = New System.Drawing.Point(497, 64)
        Me.lblISRT.Name = "lblISRT"
        Me.lblISRT.Size = New System.Drawing.Size(28, 13)
        Me.lblISRT.TabIndex = 5
        Me.lblISRT.Text = "ISR:"
        '
        'ListView2
        '
        Me.ListView2.Location = New System.Drawing.Point(376, 221)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(270, 127)
        Me.ListView2.TabIndex = 6
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'lblISR
        '
        Me.lblISR.AutoSize = True
        Me.lblISR.Location = New System.Drawing.Point(404, 185)
        Me.lblISR.Name = "lblISR"
        Me.lblISR.Size = New System.Drawing.Size(28, 13)
        Me.lblISR.TabIndex = 7
        Me.lblISR.Text = "ISR:"
        '
        'txtISR
        '
        Me.txtISR.Location = New System.Drawing.Point(464, 182)
        Me.txtISR.Name = "txtISR"
        Me.txtISR.Size = New System.Drawing.Size(100, 20)
        Me.txtISR.TabIndex = 8
        '
        'lblDescT
        '
        Me.lblDescT.AutoSize = True
        Me.lblDescT.Location = New System.Drawing.Point(461, 231)
        Me.lblDescT.Name = "lblDescT"
        Me.lblDescT.Size = New System.Drawing.Size(64, 13)
        Me.lblDescT.TabIndex = 10
        Me.lblDescT.Text = "Descuentos"
        '
        'txtIMSS
        '
        Me.txtIMSS.Location = New System.Drawing.Point(524, 256)
        Me.txtIMSS.Name = "txtIMSS"
        Me.txtIMSS.Size = New System.Drawing.Size(100, 20)
        Me.txtIMSS.TabIndex = 13
        '
        'txtINF
        '
        Me.txtINF.Location = New System.Drawing.Point(524, 282)
        Me.txtINF.Name = "txtINF"
        Me.txtINF.Size = New System.Drawing.Size(100, 20)
        Me.txtINF.TabIndex = 14
        '
        'txtAhorro
        '
        Me.txtAhorro.Location = New System.Drawing.Point(524, 309)
        Me.txtAhorro.Name = "txtAhorro"
        Me.txtAhorro.Size = New System.Drawing.Size(100, 20)
        Me.txtAhorro.TabIndex = 15
        '
        'lblDescu
        '
        Me.lblDescu.AutoSize = True
        Me.lblDescu.Location = New System.Drawing.Point(376, 372)
        Me.lblDescu.Name = "lblDescu"
        Me.lblDescu.Size = New System.Drawing.Size(67, 13)
        Me.lblDescu.TabIndex = 16
        Me.lblDescu.Text = "Descuentos:"
        '
        'txtDescu
        '
        Me.txtDescu.Location = New System.Drawing.Point(475, 365)
        Me.txtDescu.Name = "txtDescu"
        Me.txtDescu.Size = New System.Drawing.Size(100, 20)
        Me.txtDescu.TabIndex = 17
        '
        'lblDeduc
        '
        Me.lblDeduc.AutoSize = True
        Me.lblDeduc.Location = New System.Drawing.Point(376, 405)
        Me.lblDeduc.Name = "lblDeduc"
        Me.lblDeduc.Size = New System.Drawing.Size(73, 13)
        Me.lblDeduc.TabIndex = 18
        Me.lblDeduc.Text = "Deducciones:"
        '
        'txtDeduc
        '
        Me.txtDeduc.Location = New System.Drawing.Point(475, 398)
        Me.txtDeduc.Name = "txtDeduc"
        Me.txtDeduc.Size = New System.Drawing.Size(100, 20)
        Me.txtDeduc.TabIndex = 19
        '
        'lblNeto
        '
        Me.lblNeto.AutoSize = True
        Me.lblNeto.Location = New System.Drawing.Point(376, 440)
        Me.lblNeto.Name = "lblNeto"
        Me.lblNeto.Size = New System.Drawing.Size(72, 13)
        Me.lblNeto.TabIndex = 20
        Me.lblNeto.Text = "Neto a pagar:"
        '
        'txtNeto
        '
        Me.txtNeto.Location = New System.Drawing.Point(475, 433)
        Me.txtNeto.Name = "txtNeto"
        Me.txtNeto.Size = New System.Drawing.Size(100, 20)
        Me.txtNeto.TabIndex = 21
        '
        'lblEmp
        '
        Me.lblEmp.AutoSize = True
        Me.lblEmp.Location = New System.Drawing.Point(64, 64)
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.Size = New System.Drawing.Size(57, 13)
        Me.lblEmp.TabIndex = 22
        Me.lblEmp.Text = "Empleado:"
        '
        'lblSaldia
        '
        Me.lblSaldia.AutoSize = True
        Me.lblSaldia.Location = New System.Drawing.Point(64, 108)
        Me.lblSaldia.Name = "lblSaldia"
        Me.lblSaldia.Size = New System.Drawing.Size(72, 13)
        Me.lblSaldia.TabIndex = 23
        Me.lblSaldia.Text = "Salario Diario:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(64, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Dias Trabajados:"
        '
        'lblHorasE
        '
        Me.lblHorasE.AutoSize = True
        Me.lblHorasE.Location = New System.Drawing.Point(64, 185)
        Me.lblHorasE.Name = "lblHorasE"
        Me.lblHorasE.Size = New System.Drawing.Size(70, 13)
        Me.lblHorasE.TabIndex = 25
        Me.lblHorasE.Text = "Horas Extras:"
        '
        'lblSueldo
        '
        Me.lblSueldo.AutoSize = True
        Me.lblSueldo.Location = New System.Drawing.Point(64, 231)
        Me.lblSueldo.Name = "lblSueldo"
        Me.lblSueldo.Size = New System.Drawing.Size(80, 13)
        Me.lblSueldo.TabIndex = 26
        Me.lblSueldo.Text = "Sueldo Quince:"
        '
        'lblTiempoE
        '
        Me.lblTiempoE.AutoSize = True
        Me.lblTiempoE.Location = New System.Drawing.Point(64, 274)
        Me.lblTiempoE.Name = "lblTiempoE"
        Me.lblTiempoE.Size = New System.Drawing.Size(72, 13)
        Me.lblTiempoE.TabIndex = 27
        Me.lblTiempoE.Text = "Tiempo Extra:"
        '
        'lblPercer
        '
        Me.lblPercer.AutoSize = True
        Me.lblPercer.Location = New System.Drawing.Point(64, 320)
        Me.lblPercer.Name = "lblPercer"
        Me.lblPercer.Size = New System.Drawing.Size(75, 13)
        Me.lblPercer.TabIndex = 28
        Me.lblPercer.Text = "Percepciones:"
        '
        'txtEmp
        '
        Me.txtEmp.Location = New System.Drawing.Point(182, 57)
        Me.txtEmp.Name = "txtEmp"
        Me.txtEmp.Size = New System.Drawing.Size(100, 20)
        Me.txtEmp.TabIndex = 29
        '
        'txtSaldia
        '
        Me.txtSaldia.Location = New System.Drawing.Point(182, 101)
        Me.txtSaldia.Name = "txtSaldia"
        Me.txtSaldia.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldia.TabIndex = 30
        '
        'txtDiasT
        '
        Me.txtDiasT.Location = New System.Drawing.Point(182, 141)
        Me.txtDiasT.Name = "txtDiasT"
        Me.txtDiasT.Size = New System.Drawing.Size(100, 20)
        Me.txtDiasT.TabIndex = 31
        '
        'txtHorasE
        '
        Me.txtHorasE.Location = New System.Drawing.Point(182, 178)
        Me.txtHorasE.Name = "txtHorasE"
        Me.txtHorasE.Size = New System.Drawing.Size(100, 20)
        Me.txtHorasE.TabIndex = 32
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(182, 224)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSueldo.TabIndex = 33
        '
        'txtTiempoE
        '
        Me.txtTiempoE.Location = New System.Drawing.Point(182, 267)
        Me.txtTiempoE.Name = "txtTiempoE"
        Me.txtTiempoE.Size = New System.Drawing.Size(100, 20)
        Me.txtTiempoE.TabIndex = 34
        '
        'txtPercer
        '
        Me.txtPercer.Location = New System.Drawing.Point(182, 313)
        Me.txtPercer.Name = "txtPercer"
        Me.txtPercer.Size = New System.Drawing.Size(100, 20)
        Me.txtPercer.TabIndex = 35
        '
        'chkIMSS
        '
        Me.chkIMSS.AutoSize = True
        Me.chkIMSS.Location = New System.Drawing.Point(389, 259)
        Me.chkIMSS.Name = "chkIMSS"
        Me.chkIMSS.Size = New System.Drawing.Size(87, 17)
        Me.chkIMSS.TabIndex = 36
        Me.chkIMSS.Text = "IMSS <10%>"
        Me.chkIMSS.UseVisualStyleBackColor = True
        '
        'chkINFO
        '
        Me.chkINFO.AutoSize = True
        Me.chkINFO.Location = New System.Drawing.Point(389, 285)
        Me.chkINFO.Name = "chkINFO"
        Me.chkINFO.Size = New System.Drawing.Size(118, 17)
        Me.chkINFO.TabIndex = 37
        Me.chkINFO.Text = "INFONAVIT <15%>"
        Me.chkINFO.UseVisualStyleBackColor = True
        '
        'chkAhorro
        '
        Me.chkAhorro.AutoSize = True
        Me.chkAhorro.Location = New System.Drawing.Point(389, 312)
        Me.chkAhorro.Name = "chkAhorro"
        Me.chkAhorro.Size = New System.Drawing.Size(86, 17)
        Me.chkAhorro.TabIndex = 38
        Me.chkAhorro.Text = "Ahorro <5%>"
        Me.chkAhorro.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 474)
        Me.Controls.Add(Me.chkAhorro)
        Me.Controls.Add(Me.chkINFO)
        Me.Controls.Add(Me.chkIMSS)
        Me.Controls.Add(Me.txtPercer)
        Me.Controls.Add(Me.txtTiempoE)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.txtHorasE)
        Me.Controls.Add(Me.txtDiasT)
        Me.Controls.Add(Me.txtSaldia)
        Me.Controls.Add(Me.txtEmp)
        Me.Controls.Add(Me.lblPercer)
        Me.Controls.Add(Me.lblTiempoE)
        Me.Controls.Add(Me.lblSueldo)
        Me.Controls.Add(Me.lblHorasE)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblSaldia)
        Me.Controls.Add(Me.lblEmp)
        Me.Controls.Add(Me.txtNeto)
        Me.Controls.Add(Me.lblNeto)
        Me.Controls.Add(Me.txtDeduc)
        Me.Controls.Add(Me.lblDeduc)
        Me.Controls.Add(Me.txtDescu)
        Me.Controls.Add(Me.lblDescu)
        Me.Controls.Add(Me.txtAhorro)
        Me.Controls.Add(Me.txtINF)
        Me.Controls.Add(Me.txtIMSS)
        Me.Controls.Add(Me.lblDescT)
        Me.Controls.Add(Me.txtISR)
        Me.Controls.Add(Me.lblISR)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.lblISRT)
        Me.Controls.Add(Me.rbSinISR)
        Me.Controls.Add(Me.rbConISR)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Form1"
        Me.Text = "Nomina Quincenal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents rbConISR As System.Windows.Forms.RadioButton
    Friend WithEvents rbSinISR As System.Windows.Forms.RadioButton
    Friend WithEvents lblISRT As System.Windows.Forms.Label
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents lblISR As System.Windows.Forms.Label
    Friend WithEvents txtISR As System.Windows.Forms.TextBox
    Friend WithEvents lblDescT As System.Windows.Forms.Label
    Friend WithEvents txtIMSS As System.Windows.Forms.TextBox
    Friend WithEvents txtINF As System.Windows.Forms.TextBox
    Friend WithEvents txtAhorro As System.Windows.Forms.TextBox
    Friend WithEvents lblDescu As System.Windows.Forms.Label
    Friend WithEvents txtDescu As System.Windows.Forms.TextBox
    Friend WithEvents lblDeduc As System.Windows.Forms.Label
    Friend WithEvents txtDeduc As System.Windows.Forms.TextBox
    Friend WithEvents lblNeto As System.Windows.Forms.Label
    Friend WithEvents txtNeto As System.Windows.Forms.TextBox
    Friend WithEvents lblEmp As System.Windows.Forms.Label
    Friend WithEvents lblSaldia As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblHorasE As System.Windows.Forms.Label
    Friend WithEvents lblSueldo As System.Windows.Forms.Label
    Friend WithEvents lblTiempoE As System.Windows.Forms.Label
    Friend WithEvents lblPercer As System.Windows.Forms.Label
    Friend WithEvents txtEmp As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldia As System.Windows.Forms.TextBox
    Friend WithEvents txtDiasT As System.Windows.Forms.TextBox
    Friend WithEvents txtHorasE As System.Windows.Forms.TextBox
    Friend WithEvents txtSueldo As System.Windows.Forms.TextBox
    Friend WithEvents txtTiempoE As System.Windows.Forms.TextBox
    Friend WithEvents txtPercer As System.Windows.Forms.TextBox
    Friend WithEvents chkIMSS As System.Windows.Forms.CheckBox
    Friend WithEvents chkINFO As System.Windows.Forms.CheckBox
    Friend WithEvents chkAhorro As System.Windows.Forms.CheckBox

End Class
