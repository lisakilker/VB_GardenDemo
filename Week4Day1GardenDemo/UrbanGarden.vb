Public Class frmUrbanGarden

    Private Sub frmUrbanGarden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GardenDataSetLive.Gardener' table. You can move, or remove it, as needed.
        Try
            Me.GardenerTableAdapter.Fill(Me.GardenDataSetLive.Gardener)

        Catch
            MsgBox("Your database does not exist")
        End Try


    End Sub

    Private Sub ToolSaveButton_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Update()
            GardenerBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(GardenDataSetLive)

        Catch
            MsgBox("Your file did not save")
        End Try

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'string sql is our sql statement

        Dim strSQL As String = "SELECT * FROM Gardener"
        'strPath will provide the database type and path of the gardener database
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=C:\Users\LisaKilker\Documents\Chapter 10\Garden.accdb"
        Dim odaGarden As New OleDb.OleDbDataAdapter(strSQL, strPath)
        Dim datCost As New DataTable
        Dim intCount As Integer
        Dim decTotalCost As Decimal = 0D

        'Datatable is filled with the table data
        odaGarden.Fill(datCost)
        'The connection to the databse is closed
        odaGarden.Dispose()

        For intCount = 0 To datCost.Rows.Count - 1
            decTotalCost += Convert.ToDecimal(datCost.Rows(intCount)("Cost"))
        Next

        lblDisplay.Visible = True
        lblDisplay.Text = "The Total planting cost is " & decTotalCost.ToString("C")

        'Dim intNumberOfRows As Integer
        'intNumberOfRows = datCost.Rows.Count

        'Dim intNumberOfColumns As Integer
        'intNumberOfColumns = datCost.Columns.Count

        'figure 10-42
        'Dim decFirstValue As Decimal
        'decFirstValue = Convert.ToDecimal(datCost.Rows(0)("Cost"))




    End Sub
End Class
