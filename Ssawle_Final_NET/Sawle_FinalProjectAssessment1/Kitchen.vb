Imports System.Data
Imports System.Data.SqlServerCe

Public Class Kitchen
    ' u is short for "user".
    Dim uBakingPowder As Double
    Dim uButter As Double
    Dim uEgg As Integer
    Dim uFlour As Double
    Dim uMilk As Double
    Dim uSalt As Double
    Dim uSugar As Double
    Dim uVegetableOil As Double

    Dim validBakingPowder As Boolean
    Dim validButter As Boolean
    Dim validEgg As Boolean
    Dim validFlour As Boolean
    Dim validMilk As Boolean
    Dim validSalt As Boolean
    Dim validSugar As Boolean
    Dim validVegetableOil As Boolean

    Dim kitchenDS As New DataSet()

    Private Sub Kitchen_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Options.Close()
        Instructions.Close()

        Dim connectionString As String = "Data Source=C:\Users\Dieter\Desktop\Ssawle_Final_NET\Sawle_FinalProjectAssessment1\Database1.sdf;Persist Security Info=False;"
        Dim dbConnection As New SqlCeConnection(connectionString)

        dbConnection.Open()

        Dim dbAdapter As New SqlCeDataAdapter("SELECT * FROM Kitchen", dbConnection)
        dbAdapter.Fill(kitchenDS, "Kitchen")

        txtPowder.Text = kitchenDS.Tables("Kitchen").Rows(0).Item("BakingPowder")
        txtButter.Text = kitchenDS.Tables("Kitchen").Rows(0).Item("Butter")
        txtEgg.Text = kitchenDS.Tables("Kitchen").Rows(0).Item("Egg")
        txtFlour.Text = kitchenDS.Tables("Kitchen").Rows(0).Item("Flour")
        txtMilk.Text = kitchenDS.Tables("Kitchen").Rows(0).Item("Milk")
        txtSalt.Text = kitchenDS.Tables("Kitchen").Rows(0).Item("Salt")
        txtSugar.Text = kitchenDS.Tables("Kitchen").Rows(0).Item("Sugar")
        txtOil.Text = kitchenDS.Tables("Kitchen").Rows(0).Item("VegetableOil")

        dbConnection.Close()
        dbConnection.Dispose()

    End Sub

    Public Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        validBakingPowder = Double.TryParse(txtPowder.Text, uBakingPowder)
        validButter = Double.TryParse(txtButter.Text, uButter)
        validEgg = Integer.TryParse(txtEgg.Text, uEgg)
        validFlour = Double.TryParse(txtFlour.Text, uFlour)
        validMilk = Double.TryParse(txtMilk.Text, uMilk)
        validSalt = Double.TryParse(txtSalt.Text, uSalt)
        validSugar = Double.TryParse(txtSugar.Text, uSugar)
        validVegetableOil = Double.TryParse(txtOil.Text, uVegetableOil)

        If validBakingPowder And validButter And validEgg And validFlour And validMilk And validSalt And validSugar And validVegetableOil Then

            Dim connectionString As String = "Data Source=C:\Users\Dieter\Desktop\Ssawle_Final_NET\Sawle_FinalProjectAssessment1\Database1.sdf;Persist Security Info=False;"
            Dim dbConnection As New SqlCeConnection(connectionString)

            dbConnection.Open()

            Dim dbAdapter As New SqlCeDataAdapter("SELECT * FROM Kitchen", dbConnection)

            dbAdapter.Fill(kitchenDS, "Kitchen")

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

            dbAdapter.InsertCommand = insertCommand

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

            dbAdapter.Update(kitchenDS.Tables("Kitchen"))

            'This is the easiest method but it doesn't work due to double datatype not converting to float data type
            'Dim updateCommand As New SqlCeCommand("Update Kitchen Set BakingPowder=" + uBakingPowder + ", Butter=" + uButter + ", Egg=" + uEgg + ", Flour=" + uFlour + ", Milk=" + uMilk + ", Salt=" + uSalt + ", Sugar=" + uSugar + ", VegetableOil=" + uVegetableOil + " Where UserInput=1;", dbConnection)
            'updateCommand.ExecuteNonQuery()

            dbConnection.Close()
            dbConnection.Dispose()

            Options.Show()
        Else
            MessageBox.Show("Please enter only numbers.")
        End If
    End Sub



End Class


