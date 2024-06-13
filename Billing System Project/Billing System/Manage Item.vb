Public Class Item

    Private Sub ProductsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Product_DetailsDataSet)

        Product_IDTextBox.Text = ""
        Product_NameTextBox.Text = ""
        CategoryTextBox.Text = ""
        Unit_PriceTextBox.Text = ""
        StockTextBox.Text = ""
        txtbxQty.Text = ""

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'Product_DetailsDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.Product_DetailsDataSet.Products)

    End Sub
    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

        Me.Validate()
        Me.ProductsBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.Product_DetailsDataSet)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Application.Exit()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        Dim obj = New Loging
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub btnAddQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddQty.Click

        Dim a As Integer
        a = txtbxQty.Text
        StockTextBox.Text = StockTextBox.Text + a

    End Sub
End Class