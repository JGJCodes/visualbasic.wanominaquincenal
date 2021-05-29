Public Class Form1

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click

        'Declaracion de variables'
        Dim intSalDia, intDiasT, intHorasE As Integer
        Dim intSueldo, intTiempoE, intPercep, intSalHora As Integer
        'Parte Dos'
        Dim intIsr As Integer
        'Parte Tres'
        Dim intImss, intInfo, intAhorro As Integer
        Dim intDescu, intDeduc, intNeto As Integer

        'Entrada de datos'
        intSalDia = Val(txtSalDia.Text)
        intDiasT = Val(txtDiasT.Text)
        intHorasE = Val(txtHorasE.Text)

        'Calculos y/o procesos'
        intSueldo = intSalDia * intDiasT
        intSalHora = intSalDia / 8
        intTiempoE = (intHorasE * intSalHora) * 3
        intPercep = intSueldo + intTiempoE
        'Parte Dos'
        If rbConIsr.Checked = True Then
            intIsr = intPercep * 0.2
        End If
        If rbSinIsr.Checked = True Then
            intIsr = 0
        End If
        'Parte Tres'
        If chkImss.Checked = True Then
            intImss = intPercep * 0.1
        Else
            intImss = 0
        End If
        If chkInfo.Checked = True Then
            intInfo = intPercep * 0.15
        Else
            intInfo = 0
        End If
        If chkAhorro.Checked = True Then
            intAhorro = intPercep * 0.05
        Else
            intAhorro = 0
        End If
        intDescu = intImss + intInfo + intAhorro
        intDeduc = intIsr + intDescu
        intNeto = intPercep - intDeduc

        'Salida de datos'
        txtSueldo.Text = Str(intSueldo)
        txtTiempoE.Text = Str(intTiempoE)
        txtPercep.Text = Str(intPercep)
        'Parte Dos'
        txtIsr.Text = Str(intIsr)
        'Parte Tres'
        txtImss.Text = Str(intImss)
        txtInfo.Text = Str(intInfo)
        txtAhorro.Text = Str(intAhorro)
        txtDescu.Text = Str(intDescu)
        txtDeduc.Text = Str(intDeduc)
        txtNeto.Text = Str(intNeto)

    End Sub

    Private Sub lblLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLimpiar.Click

        'Limpieza de datos'
        txtEmp.Text = " "
        txtSalDia.Text = " "
        txtDiasT.Text = " "
        txtHorasE.Text = " "
        txtSueldo.Text = " "
        txtTiempoE.Text = " "
        txtPercep.Text = " "
        txtIsr.Text = " "
        txtImss.Text = " "
        txtInfo.Text = " "
        txtAhorro.Text = " "
        txtDescu.Text = " "
        txtDeduc.Text = " "
        txtNeto.Text = " "
        rbConIsr.Checked = False
        rbSinIsr.Checked = False
        chkImss.Checked = False
        chkInfo.Checked = False
        chkAhorro.Checked = False

    End Sub
End Class
