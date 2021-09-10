Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        ' valida se todos os campos estao preenchidos
        If (txtOp1.Text = Nothing Or txtOp2.Text = Nothing Or txtOp3.Text = Nothing) Then
            MsgBox("Há campos em branco. Por favor, verifique.", MsgBoxStyle.Critical, "Atenção:")
            Exit Sub
        Else
            ' se todos os campos estiverem preenchidos, cria o vetor para add as opcoes
            Dim vetorOpcoes() As String
            vetorOpcoes = {txtOp1.Text, txtOp2.Text, txtOp3.Text}
            ' passando as opcoes do vetor para o comboBox
            cbxOpcoes.DataSource = vetorOpcoes
        End If
    End Sub

    ' limpando todos os campos
    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtOp1.Text = Nothing
        txtOp2.Text = Nothing
        txtOp3.Text = Nothing
    End Sub

    ' desabilitando a entrada de dados diretamente pelo usuario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtOpcaoSelecionadaCbox.Enabled = False
    End Sub

    ' mostrando no inupt a opcao que o usuario seleciona na comboBox
    Private Sub cbxOpcoes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxOpcoes.SelectedIndexChanged
        txtOpcaoSelecionadaCbox.Text = cbxOpcoes.Text
    End Sub
End Class
