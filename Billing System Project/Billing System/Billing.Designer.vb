<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billing
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
        Me.components = New System.ComponentModel.Container()
        Dim StockLabel As System.Windows.Forms.Label
        Dim Unit_PriceLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim Product_NameLabel As System.Windows.Forms.Label
        Dim Product_IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Billing))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Product_DetailsDataSet = New WindowsApplication1.Product_DetailsDataSet()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnNextItem = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRItem = New System.Windows.Forms.Button()
        Me.L9 = New System.Windows.Forms.Label()
        Me.L8 = New System.Windows.Forms.Label()
        Me.L7 = New System.Windows.Forms.Label()
        Me.txtbxprice = New System.Windows.Forms.TextBox()
        Me.btnGetPrice = New System.Windows.Forms.Button()
        Me.txtbxQty = New System.Windows.Forms.TextBox()
        Me.L6price = New System.Windows.Forms.Label()
        Me.L5Qty = New System.Windows.Forms.Label()
        Me.L4uPrice = New System.Windows.Forms.Label()
        Me.L3PName = New System.Windows.Forms.Label()
        Me.L2PID = New System.Windows.Forms.Label()
        Me.SearchToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Product_IDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Product_IDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ProductsTableAdapter = New WindowsApplication1.Product_DetailsDataSetTableAdapters.ProductsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Product_DetailsDataSetTableAdapters.TableAdapterManager()
        Me.btnViewBill = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.L1topic = New System.Windows.Forms.Label()
        Me.Unit_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.Product_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Product_IDTextBox = New System.Windows.Forms.TextBox()
        Me.L1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProductsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        StockLabel = New System.Windows.Forms.Label()
        Unit_PriceLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        Product_NameLabel = New System.Windows.Forms.Label()
        Product_IDLabel = New System.Windows.Forms.Label()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Product_DetailsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SearchToolStrip.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StockLabel.Location = New System.Drawing.Point(9, 310)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(54, 20)
        StockLabel.TabIndex = 9
        StockLabel.Text = "Stock:"
        '
        'Unit_PriceLabel
        '
        Unit_PriceLabel.AutoSize = True
        Unit_PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Unit_PriceLabel.Location = New System.Drawing.Point(9, 266)
        Unit_PriceLabel.Name = "Unit_PriceLabel"
        Unit_PriceLabel.Size = New System.Drawing.Size(81, 20)
        Unit_PriceLabel.TabIndex = 7
        Unit_PriceLabel.Text = "Unit Price:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoryLabel.Location = New System.Drawing.Point(9, 218)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(77, 20)
        CategoryLabel.TabIndex = 5
        CategoryLabel.Text = "Category:"
        '
        'Product_NameLabel
        '
        Product_NameLabel.AutoSize = True
        Product_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Product_NameLabel.Location = New System.Drawing.Point(9, 173)
        Product_NameLabel.Name = "Product_NameLabel"
        Product_NameLabel.Size = New System.Drawing.Size(114, 20)
        Product_NameLabel.TabIndex = 3
        Product_NameLabel.Text = "Product Name:"
        '
        'Product_IDLabel
        '
        Product_IDLabel.AutoSize = True
        Product_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Product_IDLabel.Location = New System.Drawing.Point(9, 130)
        Product_IDLabel.Name = "Product_IDLabel"
        Product_IDLabel.Size = New System.Drawing.Size(89, 20)
        Product_IDLabel.TabIndex = 1
        Product_IDLabel.Text = "Product ID:"
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.Product_DetailsDataSet
        '
        'Product_DetailsDataSet
        '
        Me.Product_DetailsDataSet.DataSetName = "Product_DetailsDataSet"
        Me.Product_DetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockTextBox
        '
        Me.StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Stock", True))
        Me.StockTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockTextBox.Location = New System.Drawing.Point(123, 310)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.StockTextBox.Size = New System.Drawing.Size(72, 22)
        Me.StockTextBox.TabIndex = 10
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.Crimson
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.Location = New System.Drawing.Point(55, 392)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(120, 43)
        Me.btnAddItem.TabIndex = 13
        Me.btnAddItem.Text = "ADD ITEM"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'btnNextItem
        '
        Me.btnNextItem.BackColor = System.Drawing.Color.Crimson
        Me.btnNextItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextItem.ForeColor = System.Drawing.Color.White
        Me.btnNextItem.Location = New System.Drawing.Point(142, 292)
        Me.btnNextItem.Name = "btnNextItem"
        Me.btnNextItem.Size = New System.Drawing.Size(101, 50)
        Me.btnNextItem.TabIndex = 14
        Me.btnNextItem.Text = "NEXT ITEM"
        Me.btnNextItem.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.btnRItem)
        Me.GroupBox1.Controls.Add(Me.L9)
        Me.GroupBox1.Controls.Add(Me.L8)
        Me.GroupBox1.Controls.Add(Me.L7)
        Me.GroupBox1.Controls.Add(Me.txtbxprice)
        Me.GroupBox1.Controls.Add(Me.btnGetPrice)
        Me.GroupBox1.Controls.Add(Me.txtbxQty)
        Me.GroupBox1.Controls.Add(Me.L6price)
        Me.GroupBox1.Controls.Add(Me.L5Qty)
        Me.GroupBox1.Controls.Add(Me.btnNextItem)
        Me.GroupBox1.Controls.Add(Me.L4uPrice)
        Me.GroupBox1.Controls.Add(Me.L3PName)
        Me.GroupBox1.Controls.Add(Me.L2PID)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(312, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 382)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Item"
        '
        'btnRItem
        '
        Me.btnRItem.BackColor = System.Drawing.Color.Crimson
        Me.btnRItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRItem.ForeColor = System.Drawing.Color.White
        Me.btnRItem.Location = New System.Drawing.Point(263, 292)
        Me.btnRItem.Name = "btnRItem"
        Me.btnRItem.Size = New System.Drawing.Size(101, 50)
        Me.btnRItem.TabIndex = 20
        Me.btnRItem.Text = "REMOVE ITEM"
        Me.btnRItem.UseVisualStyleBackColor = False
        '
        'L9
        '
        Me.L9.AutoSize = True
        Me.L9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L9.ForeColor = System.Drawing.Color.Black
        Me.L9.Location = New System.Drawing.Point(208, 137)
        Me.L9.Name = "L9"
        Me.L9.Size = New System.Drawing.Size(0, 16)
        Me.L9.TabIndex = 14
        '
        'L8
        '
        Me.L8.AutoSize = True
        Me.L8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L8.ForeColor = System.Drawing.Color.Black
        Me.L8.Location = New System.Drawing.Point(208, 88)
        Me.L8.Name = "L8"
        Me.L8.Size = New System.Drawing.Size(0, 16)
        Me.L8.TabIndex = 13
        '
        'L7
        '
        Me.L7.AutoSize = True
        Me.L7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L7.ForeColor = System.Drawing.Color.Black
        Me.L7.Location = New System.Drawing.Point(208, 42)
        Me.L7.Name = "L7"
        Me.L7.Size = New System.Drawing.Size(0, 16)
        Me.L7.TabIndex = 12
        '
        'txtbxprice
        '
        Me.txtbxprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxprice.ForeColor = System.Drawing.Color.Black
        Me.txtbxprice.Location = New System.Drawing.Point(205, 236)
        Me.txtbxprice.Name = "txtbxprice"
        Me.txtbxprice.Size = New System.Drawing.Size(100, 22)
        Me.txtbxprice.TabIndex = 10
        '
        'btnGetPrice
        '
        Me.btnGetPrice.BackColor = System.Drawing.Color.Crimson
        Me.btnGetPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetPrice.ForeColor = System.Drawing.Color.White
        Me.btnGetPrice.Location = New System.Drawing.Point(12, 292)
        Me.btnGetPrice.Name = "btnGetPrice"
        Me.btnGetPrice.Size = New System.Drawing.Size(109, 50)
        Me.btnGetPrice.TabIndex = 19
        Me.btnGetPrice.Text = "GET PRICE"
        Me.btnGetPrice.UseVisualStyleBackColor = False
        '
        'txtbxQty
        '
        Me.txtbxQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxQty.ForeColor = System.Drawing.Color.Black
        Me.txtbxQty.Location = New System.Drawing.Point(205, 183)
        Me.txtbxQty.Name = "txtbxQty"
        Me.txtbxQty.Size = New System.Drawing.Size(69, 22)
        Me.txtbxQty.TabIndex = 9
        '
        'L6price
        '
        Me.L6price.AutoSize = True
        Me.L6price.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L6price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L6price.ForeColor = System.Drawing.Color.Black
        Me.L6price.Location = New System.Drawing.Point(44, 236)
        Me.L6price.Name = "L6price"
        Me.L6price.Size = New System.Drawing.Size(44, 20)
        Me.L6price.TabIndex = 4
        Me.L6price.Text = "Price"
        '
        'L5Qty
        '
        Me.L5Qty.AutoSize = True
        Me.L5Qty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L5Qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L5Qty.ForeColor = System.Drawing.Color.Black
        Me.L5Qty.Location = New System.Drawing.Point(44, 183)
        Me.L5Qty.Name = "L5Qty"
        Me.L5Qty.Size = New System.Drawing.Size(68, 20)
        Me.L5Qty.TabIndex = 3
        Me.L5Qty.Text = "Quantity"
        '
        'L4uPrice
        '
        Me.L4uPrice.AutoSize = True
        Me.L4uPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L4uPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L4uPrice.ForeColor = System.Drawing.Color.Black
        Me.L4uPrice.Location = New System.Drawing.Point(44, 134)
        Me.L4uPrice.Name = "L4uPrice"
        Me.L4uPrice.Size = New System.Drawing.Size(77, 20)
        Me.L4uPrice.TabIndex = 2
        Me.L4uPrice.Text = "Unit Price"
        '
        'L3PName
        '
        Me.L3PName.AutoSize = True
        Me.L3PName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L3PName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L3PName.ForeColor = System.Drawing.Color.Black
        Me.L3PName.Location = New System.Drawing.Point(44, 85)
        Me.L3PName.Name = "L3PName"
        Me.L3PName.Size = New System.Drawing.Size(110, 20)
        Me.L3PName.TabIndex = 1
        Me.L3PName.Text = "Product Name"
        '
        'L2PID
        '
        Me.L2PID.AutoSize = True
        Me.L2PID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L2PID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L2PID.ForeColor = System.Drawing.Color.Black
        Me.L2PID.Location = New System.Drawing.Point(44, 39)
        Me.L2PID.Name = "L2PID"
        Me.L2PID.Size = New System.Drawing.Size(85, 20)
        Me.L2PID.TabIndex = 0
        Me.L2PID.Text = "Product ID"
        '
        'SearchToolStrip
        '
        Me.SearchToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.SearchToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Product_IDToolStripLabel, Me.Product_IDToolStripTextBox, Me.SearchToolStripButton})
        Me.SearchToolStrip.Location = New System.Drawing.Point(9, 70)
        Me.SearchToolStrip.Name = "SearchToolStrip"
        Me.SearchToolStrip.Size = New System.Drawing.Size(226, 25)
        Me.SearchToolStrip.TabIndex = 23
        Me.SearchToolStrip.Text = "SearchToolStrip"
        '
        'Product_IDToolStripLabel
        '
        Me.Product_IDToolStripLabel.Name = "Product_IDToolStripLabel"
        Me.Product_IDToolStripLabel.Size = New System.Drawing.Size(68, 22)
        Me.Product_IDToolStripLabel.Text = "Product_ID:"
        '
        'Product_IDToolStripTextBox
        '
        Me.Product_IDToolStripTextBox.Name = "Product_IDToolStripTextBox"
        Me.Product_IDToolStripTextBox.Size = New System.Drawing.Size(98, 25)
        '
        'SearchToolStripButton
        '
        Me.SearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SearchToolStripButton.Name = "SearchToolStripButton"
        Me.SearchToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.SearchToolStripButton.Text = "Search"
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Product_DetailsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnViewBill
        '
        Me.btnViewBill.BackColor = System.Drawing.Color.Crimson
        Me.btnViewBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewBill.ForeColor = System.Drawing.Color.White
        Me.btnViewBill.Location = New System.Drawing.Point(244, 415)
        Me.btnViewBill.Name = "btnViewBill"
        Me.btnViewBill.Size = New System.Drawing.Size(181, 43)
        Me.btnViewBill.TabIndex = 24
        Me.btnViewBill.Text = "VIEW BILL"
        Me.btnViewBill.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Location = New System.Drawing.Point(21, 34)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.Size = New System.Drawing.Size(633, 362)
        Me.DataGridView1.TabIndex = 25
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Product Name"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Unit Price"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Price"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 140
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Crimson
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.L1topic)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1377, 68)
        Me.Panel1.TabIndex = 26
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1262, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'L1topic
        '
        Me.L1topic.AutoSize = True
        Me.L1topic.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1topic.ForeColor = System.Drawing.Color.White
        Me.L1topic.Location = New System.Drawing.Point(517, 17)
        Me.L1topic.Name = "L1topic"
        Me.L1topic.Size = New System.Drawing.Size(294, 32)
        Me.L1topic.TabIndex = 16
        Me.L1topic.Text = "SAMEERA BOOKSHOP"
        '
        'Unit_PriceTextBox
        '
        Me.Unit_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Unit Price", True))
        Me.Unit_PriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unit_PriceTextBox.Location = New System.Drawing.Point(123, 266)
        Me.Unit_PriceTextBox.Name = "Unit_PriceTextBox"
        Me.Unit_PriceTextBox.Size = New System.Drawing.Size(72, 22)
        Me.Unit_PriceTextBox.TabIndex = 8
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Category", True))
        Me.CategoryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryTextBox.Location = New System.Drawing.Point(123, 218)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(105, 22)
        Me.CategoryTextBox.TabIndex = 6
        '
        'Product_NameTextBox
        '
        Me.Product_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Product Name", True))
        Me.Product_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_NameTextBox.Location = New System.Drawing.Point(123, 173)
        Me.Product_NameTextBox.Name = "Product_NameTextBox"
        Me.Product_NameTextBox.Size = New System.Drawing.Size(158, 22)
        Me.Product_NameTextBox.TabIndex = 4
        '
        'Product_IDTextBox
        '
        Me.Product_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Product ID", True))
        Me.Product_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_IDTextBox.Location = New System.Drawing.Point(123, 130)
        Me.Product_IDTextBox.Name = "Product_IDTextBox"
        Me.Product_IDTextBox.Size = New System.Drawing.Size(72, 22)
        Me.Product_IDTextBox.TabIndex = 2
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.BackColor = System.Drawing.Color.SeaShell
        Me.L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1.ForeColor = System.Drawing.Color.Crimson
        Me.L1.Location = New System.Drawing.Point(74, 7)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(150, 24)
        Me.L1.TabIndex = 15
        Me.L1.Text = "Product Details"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Crimson
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 563)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1377, 15)
        Me.Panel2.TabIndex = 27
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.btnViewBill)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(701, 68)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(676, 495)
        Me.Panel3.TabIndex = 28
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BindingNavigator1)
        Me.Panel4.Controls.Add(Me.btnAddItem)
        Me.Panel4.Controls.Add(Me.SearchToolStrip)
        Me.Panel4.Controls.Add(Me.StockTextBox)
        Me.Panel4.Controls.Add(StockLabel)
        Me.Panel4.Controls.Add(Me.Unit_PriceTextBox)
        Me.Panel4.Controls.Add(Unit_PriceLabel)
        Me.Panel4.Controls.Add(Me.L1)
        Me.Panel4.Controls.Add(Me.CategoryTextBox)
        Me.Panel4.Controls.Add(CategoryLabel)
        Me.Panel4.Controls.Add(Product_IDLabel)
        Me.Panel4.Controls.Add(Me.Product_NameTextBox)
        Me.Panel4.Controls.Add(Me.Product_IDTextBox)
        Me.Panel4.Controls.Add(Product_NameLabel)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 68)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(293, 495)
        Me.Panel4.TabIndex = 29
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.White
        Me.BindingNavigator1.BindingSource = Me.ProductsBindingSource
        Me.BindingNavigator1.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripSeparator3, Me.ProductsBindingNavigatorSaveItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(9, 42)
        Me.BindingNavigator1.MoveFirstItem = Me.ToolStripButton2
        Me.BindingNavigator1.MoveLastItem = Me.ToolStripButton5
        Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton4
        Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton3
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator1.Size = New System.Drawing.Size(232, 25)
        Me.BindingNavigator1.TabIndex = 24
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Move first"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move next"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ProductsBindingNavigatorSaveItem
        '
        Me.ProductsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductsBindingNavigatorSaveItem.Name = "ProductsBindingNavigatorSaveItem"
        Me.ProductsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProductsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1377, 578)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Billing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Product_DetailsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SearchToolStrip.ResumeLayout(False)
        Me.SearchToolStrip.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Product_DetailsDataSet As WindowsApplication1.Product_DetailsDataSet
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As WindowsApplication1.Product_DetailsDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Product_DetailsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents btnNextItem As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents L9 As System.Windows.Forms.Label
    Friend WithEvents L8 As System.Windows.Forms.Label
    Friend WithEvents L7 As System.Windows.Forms.Label
    Friend WithEvents txtbxprice As System.Windows.Forms.TextBox
    Friend WithEvents txtbxQty As System.Windows.Forms.TextBox
    Friend WithEvents L6price As System.Windows.Forms.Label
    Friend WithEvents L5Qty As System.Windows.Forms.Label
    Friend WithEvents L4uPrice As System.Windows.Forms.Label
    Friend WithEvents L3PName As System.Windows.Forms.Label
    Friend WithEvents L2PID As System.Windows.Forms.Label
    Friend WithEvents btnGetPrice As System.Windows.Forms.Button
    Friend WithEvents SearchToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Product_IDToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Product_IDToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SearchToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnViewBill As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Unit_PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Product_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Product_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents L1topic As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProductsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRItem As System.Windows.Forms.Button
End Class
