Imports System.Drawing.Printing

Public Class Billing

    Dim WithEvents Pd As New PrintDocument
    Dim Ppd As New PrintPreviewDialog
    Dim longpaper As Integer

    Private Sub ProductsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Product_DetailsDataSet)

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'Product_DetailsDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.Product_DetailsDataSet.Products)

    End Sub

    Private Sub SearchToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripButton.Click

        Try
            Me.ProductsTableAdapter.Search(Me.Product_DetailsDataSet.Products, Product_IDToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ProductsBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Product_DetailsDataSet)

    End Sub

     Sub changelongpaper()

        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 240

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click

        L7.Text = Product_IDTextBox.Text
        L8.Text = Product_NameTextBox.Text
        L9.Text = Unit_PriceTextBox.Text

        txtbxprice.Enabled = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextItem.Click

        Dim rnum As Integer = DataGridView1.Rows.Add()

        DataGridView1.Rows.Item(rnum).Cells("Column1").Value = L7.Text
        DataGridView1.Rows.Item(rnum).Cells("Column2").Value = L8.Text
        DataGridView1.Rows.Item(rnum).Cells("Column3").Value = L9.Text
        DataGridView1.Rows.Item(rnum).Cells("Column4").Value = txtbxQty.Text
        DataGridView1.Rows.Item(rnum).Cells("Column5").Value = txtbxprice.Text

        StockTextBox.Text = StockTextBox.Text - txtbxQty.Text

        L7.Text = ""
        L8.Text = ""
        L9.Text = ""
        txtbxQty.Text = ""
        txtbxprice.Text = ""

    End Sub
    Private Sub btnRItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRItem.Click

        L7.Text = ""
        L8.Text = ""
        L9.Text = ""
        txtbxQty.Text = ""
        txtbxprice.Text = ""

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbxQty.TextChanged
        
        If txtbxQty.Text = "" Then
            txtbxprice.Enabled = False
        Else
            txtbxprice.Enabled = True
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetPrice.Click

        If (CInt(txtbxQty.Text) > CInt(StockTextBox.Text)) Then
            MsgBox("Out Stock", MsgBoxStyle.Information, "Alert")
        Else
            txtbxprice.Text = L9.Text * txtbxQty.Text
        End If

    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewBill.Click

        changelongpaper()
        Ppd.Document = Pd
        Ppd.ShowDialog()

    End Sub

    Private Sub Pd_BeginPrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Pd.BeginPrint

        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 300, longpaper)
        Pd.DefaultPageSettings = pagesetup

    End Sub

    Private Sub Pd_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Pd.PrintPage

        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f8b As New Font("Calibri", 8, FontStyle.Bold)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = Pd.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = Pd.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = Pd.DefaultPageSettings.PaperSize.Width

        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "=================================================================================================="

        e.Graphics.DrawString("Sameera Book Shop", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("Anuradhapura", f10, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("Tel : +94 712482765", f8, Brushes.Black, centermargin, 41, center)
        e.Graphics.DrawString("www.sameerabookshop.com", f8, Brushes.Black, centermargin, 53, center)

        e.Graphics.DrawString("Invoice ID", f8, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 75)
        e.Graphics.DrawString("SBS1245", f8, Brushes.Black, 60, 75)

        e.Graphics.DrawString("Date :" & Date.Now(), f8, Brushes.Black, 0, 90)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 100)

        e.Graphics.DrawString("ITEM", f8b, Brushes.Black, 20, 110)
        e.Graphics.DrawString("RATE", f8b, Brushes.Black, 130, 110)
        e.Graphics.DrawString("QTY", f8b, Brushes.Black, 180, 110)
        e.Graphics.DrawString("AMOUNT", f8b, Brushes.Black, 240, 110)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 120)

        Dim height As Integer

        DataGridView1.AllowUserToAddRows = False
        
        For row As Integer = 0 To DataGridView1.RowCount - 1
            height += 15
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(1).Value.ToString, f8, Brushes.Black, 5, 115 + height)

            e.Graphics.DrawString("Rs.", f8, Brushes.Black, 135, 115 + height, right)
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString, f8, Brushes.Black, 155, 115 + height, right)
            e.Graphics.DrawString(".00", f8, Brushes.Black, 170, 115 + height, right)

            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(3).Value.ToString, f8, Brushes.Black, 200, 115 + height, right)

            e.Graphics.DrawString("Rs.", f8, Brushes.Black, 250, 115 + height, right)
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(4).Value.ToString, f8, Brushes.Black, 274, 115 + height, right)
            e.Graphics.DrawString(".00", f8, Brushes.Black, 290, 115 + height, right)
        Next

        Dim height2 As Integer
        height2 = 110 + height
        sumprice()

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 120)

        'e.Graphics.DrawString("Rs.", f8, Brushes.Black, 250, 30 + height2, right)
        e.Graphics.DrawString("Total : Rs." & Format(totalPrice, "##,##0"), f8b, Brushes.Black, 270, 30 + height2, right)
        e.Graphics.DrawString(".00", f8b, Brushes.Black, 290, 30 + height2, right)

        e.Graphics.DrawString("Number of pieces:" & Format(totalQty, "##,##0"), f8b, Brushes.Black, 0, 30 + height2)

        e.Graphics.DrawString("THANK YOU...!!!", f10b, Brushes.Black, centermargin, 70 + height2, center)

    End Sub
    Dim totalPrice As Long
    Dim totalQty As Long
    Sub sumprice()

        Dim countprice As Long = 0
        For rowitem As Long = 0 To DataGridView1.RowCount - 1
            countprice = countprice + Val(DataGridView1.Rows(rowitem).Cells(4).Value)
        Next
        totalPrice = countprice

        Dim countqty As Long
        For rowitem As Long = 0 To DataGridView1.RowCount - 1
            countqty = countqty + Val(DataGridView1.Rows(rowitem).Cells(3).Value)
        Next
        totalQty = countqty

    End Sub
    
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Application.Exit()

    End Sub

End Class