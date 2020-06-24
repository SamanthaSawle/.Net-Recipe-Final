Imports System.Data
Imports System.Data.SqlServerCe

Public Class Instructions

    Public Shared choice As String

    Private Sub Instructions_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Options.Close()

        If choice = "cookies" Then
            gbxCookieInstructions.Visible = True
        End If
        If choice = "toast" Then
            gbxFrenchToastInstructions.Visible = True
        End If
        If choice = "popover" Then
            gbxPopover.Visible = True
        End If
        If choice = "crepe" Then
            gbxCrepe.Visible = True
        End If
        If choice = "muffin" Then
            gbxMuffins.Visible = True
        End If

    End Sub

    Private Sub btnMakeThis_Click(sender As Object, e As EventArgs) Handles btnMakeThis.Click
        MessageBox.Show("The ingredients you used to make this recipe have been automatically removed from your inventory.")

        Dim recipeDS As New DataSet()
        Dim kitchenDS As New DataSet()

        Dim connectionString As String = "Data Source=C:\Users\Dieter\Desktop\Ssawle_Final_NET\Sawle_FinalProjectAssessment1\Database1.sdf;Persist Security Info=False;"
        Dim dbConnection As New SqlCeConnection(connectionString)
        dbConnection.Open()

        Dim dbAdapter As New SqlCeDataAdapter("SELECT * FROM Recipes", dbConnection)
        dbAdapter.Fill(recipeDS, "Recipes")
        Dim dbAdapter2 As New SqlCeDataAdapter("SELECT * FROM Kitchen", dbConnection)
        dbAdapter2.Fill(kitchenDS, "Kitchen")

        ' Fill Variables with User Input
        Dim uBakingPowder As Double = kitchenDS.Tables("Kitchen").Rows(0).Item("BakingPowder")
        Dim uButter As Double = kitchenDS.Tables("Kitchen").Rows(0).Item("Butter")
        Dim uEgg As Integer = kitchenDS.Tables("Kitchen").Rows(0).Item("Egg")
        Dim uFlour As Double = kitchenDS.Tables("Kitchen").Rows(0).Item("Flour")
        Dim uMilk As Double = kitchenDS.Tables("Kitchen").Rows(0).Item("Milk")
        Dim uSalt As Double = kitchenDS.Tables("Kitchen").Rows(0).Item("Salt")
        Dim uSugar As Double = kitchenDS.Tables("Kitchen").Rows(0).Item("Sugar")
        Dim uVegetableOil As Double = kitchenDS.Tables("Kitchen").Rows(0).Item("VegetableOil")

        Dim index As Integer

        If choice = "cookies" Then
            index = 0
        ElseIf choice = "muffin" Then
            index = 1
        ElseIf choice = "popover" Then
            index = 2
        ElseIf choice = "crepe" Then
            index = 3
        ElseIf choice = "toast" Then
            index = 4
        End If

        Dim sBakingPowder = recipeDS.Tables("Recipes").Rows(index).Item("BakingPowder")
        Dim sButter As Double = recipeDS.Tables("Recipes").Rows(index).Item("Butter")
        Dim sEgg As Double = recipeDS.Tables("Recipes").Rows(index).Item("Egg")
        Dim sFlour As Double = recipeDS.Tables("Recipes").Rows(index).Item("Flour")
        Dim sMilk As Double = recipeDS.Tables("Recipes").Rows(index).Item("Milk")
        Dim sSalt As Double = recipeDS.Tables("Recipes").Rows(index).Item("Salt")
        Dim sSugar As Double = recipeDS.Tables("Recipes").Rows(index).Item("Sugar")
        Dim sVegetableOil As Double = recipeDS.Tables("Recipes").Rows(index).Item("VegetableOil")

        uBakingPowder = uBakingPowder - sBakingPowder
        uButter = uButter - sButter
        uEgg = uEgg - sEgg
        uFlour = uFlour - sFlour
        uMilk = uMilk - sMilk
        uSalt = uSalt - sSalt
        uSugar = uSugar - sSugar
        uVegetableOil = uVegetableOil - sVegetableOil

        Dim deleteString As String = "delete from Kitchen where userInput=1;"
        Dim deleteCommand As New SqlCeCommand(deleteString, dbConnection)

        deleteCommand.ExecuteNonQuery()

        Dim insertString As String = "insert into Kitchen (UserInput, BakingPowder, Butter, Egg, Flour, Milk, Salt, Sugar, VegetableOil) values(@UserInput, @BakingPowder, @Butter, @Egg, @Flour, @Milk, @Salt, @Sugar, @VegetableOil)"
        Dim insertCommand As New SqlCeCommand(insertString, dbConnection)

        insertCommand.Parameters.Add("@UserInput", SqlDbType.Int, 4, "UserInput")
        insertCommand.Parameters.Add("@BakingPowder", SqlDbType.Float, 8, "BakingPowder")
        insertCommand.Parameters.Add("@Butter", SqlDbType.Float, 8, "Butter")
        insertCommand.Parameters.Add("@Egg", SqlDbType.Float, 8, "Egg")
        insertCommand.Parameters.Add("@Flour", SqlDbType.Float, 8, "Flour")
        insertCommand.Parameters.Add("@Milk", SqlDbType.Float, 8, "Milk")
        insertCommand.Parameters.Add("@Salt", SqlDbType.Float, 8, "Salt")
        insertCommand.Parameters.Add("@Sugar", SqlDbType.Float, 8, "Sugar")
        insertCommand.Parameters.Add("@VegetableOil", SqlDbType.Float, 8, "VegetableOil")

        dbAdapter2.InsertCommand = insertCommand

        Dim resultTable As New DataTable()
        resultTable = kitchenDS.Tables("Kitchen")
        Dim newRow As DataRow = resultTable.NewRow

        newRow.SetField("UserInput", 1)
        newRow.SetField("BakingPowder", uBakingPowder)
        newRow.SetField("Butter", uButter)
        newRow.SetField("Egg", uEgg)
        newRow.SetField("Flour", uFlour)
        newRow.SetField("Milk", uMilk)
        newRow.SetField("Salt", uSalt)
        newRow.SetField("Sugar", uSugar)
        newRow.SetField("VegetableOil", uVegetableOil)

        resultTable.Rows.Add(newRow)
        newRow.EndEdit()

        dbAdapter2.Update(kitchenDS.Tables("Kitchen"))

        dbConnection.Close()

        Kitchen.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Options.Show()
    End Sub

End Class