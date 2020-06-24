Imports System.Data
Imports System.Data.SqlServerCe

Public Class Options

    Dim recipeDS As New DataSet()
    Dim kitchenDS As New DataSet()

    Public Sub Options_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Instructions.Close()
        Kitchen.Close()

        'Open up Database Table and Instantiate
        Dim connectionString As String = "Data Source=C:\Users\Dieter\Desktop\Ssawle_Final_NET\Sawle_FinalProjectAssessment1\Database1.sdf;Persist Security Info=False;"
        Dim dbConnection As New SqlCeConnection(connectionString)
        dbConnection.Open()

        Dim dbAdapter As New SqlCeDataAdapter("SELECT * FROM Recipes", dbConnection)
        dbAdapter.Fill(recipeDS, "Recipes")
        Dim dbAdapter2 As New SqlCeDataAdapter("SELECT * FROM Kitchen", dbConnection)
        dbAdapter2.Fill(kitchenDS, "Kitchen")

        ' Fill Variables with User Input
        Dim ouBakingPowder As Double = kitchenDS.Tables("Kitchen").Rows(0).Item("BakingPowder")
        Dim ouButter As Double = kitchenDS.Tables("Kitchen").Rows(0).Item("Butter")
        Dim ouEgg As Integer = kitchenDS.Tables("Kitchen").Rows(0).Item("Egg")
        Dim ouFlour As Double = kitchenDS.Tables("Kitchen").Rows(0).Item("Flour")
        Dim ouMilk As Double = kitchenDS.Tables("Kitchen").Rows(0).Item("Milk")
        Dim ouSalt As Double = kitchenDS.Tables("Kitchen").Rows(0).Item("Salt")
        Dim ouSugar As Double = kitchenDS.Tables("Kitchen").Rows(0).Item("Sugar")
        Dim ouVegetableOil As Double = kitchenDS.Tables("Kitchen").Rows(0).Item("VegetableOil")

        'Process each row in the table compared to user input
        Dim index As Integer = 1
        Dim lastIndex As Integer = recipeDS.Tables("Recipes").Rows.Count

        While index <= lastIndex

            Dim osBakingPowder = recipeDS.Tables("Recipes").Rows(index - 1).Item("BakingPowder")
            Dim osButter As Double = recipeDS.Tables("Recipes").Rows(index - 1).Item("Butter")
            Dim osEgg As Double = recipeDS.Tables("Recipes").Rows(index - 1).Item("Egg")
            Dim osFlour As Double = recipeDS.Tables("Recipes").Rows(index - 1).Item("Flour")
            Dim osMilk As Double = recipeDS.Tables("Recipes").Rows(index - 1).Item("Milk")
            Dim osSalt As Double = recipeDS.Tables("Recipes").Rows(index - 1).Item("Salt")
            Dim osSugar As Double = recipeDS.Tables("Recipes").Rows(index - 1).Item("Sugar")
            Dim osVegetableOil As Double = recipeDS.Tables("Recipes").Rows(index - 1).Item("VegetableOil")

            If ouBakingPowder >= osBakingPowder And ouButter >= osButter And ouEgg >= osEgg And ouFlour >= osFlour And ouMilk >= osMilk And ouSalt >= osSalt And ouSugar >= osSugar And ouVegetableOil >= osVegetableOil Then
                'The recipes will always be in the same order as this program does not allow for the users to change that.
                If index = 1 Then
                    gbxCookies.Visible = True
                    gbxNothing.Visible = False
                ElseIf index = 2 Then
                    Dim bread As Boolean
                    'Citation after section
                    Dim intAnswer = _
                    MsgBox("Do you have sliced bread?", _
                           vbYesNo, "Bread Slices")

                    If intAnswer = vbYes Then
                        bread = True
                        gbxFrenchToast.Visible = True
                        gbxNothing.Visible = False
                    End If
                    'Citation: Guy, Scripting, "How Can I Give a User A Yes/No Prompt?" Hey Scripting Guy! Blog. Microsoft Corporation. 16 Aug 2004. blogs.technet.com. 1 Feb 2015. <http://blogs.technet.com/b/heyscriptingguy/archive/2004/08/16/how-can-i-give-a-user-a-yes-no-prompt.aspx>

                ElseIf index = 3 Then
                    gbxPopovers.Visible = True
                    gbxNothing.Visible = False
                ElseIf index = 4 Then
                    gbxCrepe.Visible = True
                    gbxNothing.Visible = False
                ElseIf index = 5 Then
                    gbxMuffin.Visible = True
                    gbxNothing.Visible = False
                End If

            End If

            index += 1
        End While

        dbConnection.Close()
        dbConnection.Dispose()

    End Sub


    Private Sub btnCookies_Click(sender As Object, e As EventArgs) Handles btnCookies.Click
        Instructions.choice = "cookies"
        Instructions.Show()
    End Sub

    Shared Sub btnFrenchToast_Click(sender As Object, e As EventArgs) Handles btnFrenchToast.Click
        Instructions.choice = "toast"
        Instructions.Show()
    End Sub

    Private Sub btnPopover_Click(sender As Object, e As EventArgs) Handles btnPopover.Click
        Instructions.choice = "popover"
        Instructions.Show()
    End Sub

    Private Sub btnCrepe_Click(sender As Object, e As EventArgs) Handles btnCrepe.Click
        Instructions.choice = "crepe"
        Instructions.Show()
    End Sub

    Private Sub btnMuffin_Click(sender As Object, e As EventArgs) Handles btnMuffin.Click
        Instructions.choice = "muffin"
        Instructions.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Kitchen.Show()
        Me.Close()
    End Sub



End Class