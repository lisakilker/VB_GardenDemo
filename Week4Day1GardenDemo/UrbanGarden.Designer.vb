<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUrbanGarden
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
        Dim Plot_IDLabel As System.Windows.Forms.Label
        Dim Urban_Garden_NameLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim Plot_OwnershipLabel As System.Windows.Forms.Label
        Dim CostLabel As System.Windows.Forms.Label
        Dim Gardener_NameLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUrbanGarden))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.GardenDataSetLive = New Week4Day1GardenDemo.GardenDataSetLive()
        Me.GardenerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GardenerTableAdapter = New Week4Day1GardenDemo.GardenDataSetLiveTableAdapters.GardenerTableAdapter()
        Me.TableAdapterManager = New Week4Day1GardenDemo.GardenDataSetLiveTableAdapters.TableAdapterManager()
        Me.Plot_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Urban_Garden_NameTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.Plot_OwnershipTextBox = New System.Windows.Forms.TextBox()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.picGarden = New System.Windows.Forms.PictureBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.Gardener_NameComboBox = New System.Windows.Forms.ComboBox()
        Plot_IDLabel = New System.Windows.Forms.Label()
        Urban_Garden_NameLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        Plot_OwnershipLabel = New System.Windows.Forms.Label()
        CostLabel = New System.Windows.Forms.Label()
        Gardener_NameLabel1 = New System.Windows.Forms.Label()
        CType(Me.GardenDataSetLive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GardenerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.picGarden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Plot_IDLabel
        '
        Plot_IDLabel.AutoSize = True
        Plot_IDLabel.Location = New System.Drawing.Point(90, 211)
        Plot_IDLabel.Name = "Plot_IDLabel"
        Plot_IDLabel.Size = New System.Drawing.Size(42, 13)
        Plot_IDLabel.TabIndex = 3
        Plot_IDLabel.Text = "Plot ID:"
        '
        'Urban_Garden_NameLabel
        '
        Urban_Garden_NameLabel.AutoSize = True
        Urban_Garden_NameLabel.Location = New System.Drawing.Point(24, 290)
        Urban_Garden_NameLabel.Name = "Urban_Garden_NameLabel"
        Urban_Garden_NameLabel.Size = New System.Drawing.Size(108, 13)
        Urban_Garden_NameLabel.TabIndex = 7
        Urban_Garden_NameLabel.Text = "Urban Garden Name:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Location = New System.Drawing.Point(303, 209)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(51, 13)
        LocationLabel.TabIndex = 9
        LocationLabel.Text = "Location:"
        '
        'Plot_OwnershipLabel
        '
        Plot_OwnershipLabel.AutoSize = True
        Plot_OwnershipLabel.Location = New System.Drawing.Point(273, 249)
        Plot_OwnershipLabel.Name = "Plot_OwnershipLabel"
        Plot_OwnershipLabel.Size = New System.Drawing.Size(81, 13)
        Plot_OwnershipLabel.TabIndex = 11
        Plot_OwnershipLabel.Text = "Plot Ownership:"
        '
        'CostLabel
        '
        CostLabel.AutoSize = True
        CostLabel.Location = New System.Drawing.Point(323, 290)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(31, 13)
        CostLabel.TabIndex = 13
        CostLabel.Text = "Cost:"
        '
        'Gardener_NameLabel1
        '
        Gardener_NameLabel1.AutoSize = True
        Gardener_NameLabel1.Location = New System.Drawing.Point(47, 249)
        Gardener_NameLabel1.Name = "Gardener_NameLabel1"
        Gardener_NameLabel1.Size = New System.Drawing.Size(85, 13)
        Gardener_NameLabel1.TabIndex = 16
        Gardener_NameLabel1.Text = "Gardener Name:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(263, 57)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(74, 13)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Urban Garden"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(224, 340)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(104, 23)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "Submit"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'GardenDataSetLive
        '
        Me.GardenDataSetLive.DataSetName = "GardenDataSetLive"
        Me.GardenDataSetLive.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GardenerBindingSource
        '
        Me.GardenerBindingSource.DataMember = "Gardener"
        Me.GardenerBindingSource.DataSource = Me.GardenDataSetLive
        '
        'GardenerTableAdapter
        '
        Me.GardenerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GardenerTableAdapter = Me.GardenerTableAdapter
        Me.TableAdapterManager.UpdateOrder = Week4Day1GardenDemo.GardenDataSetLiveTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Plot_IDTextBox
        '
        Me.Plot_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GardenerBindingSource, "Plot ID", True))
        Me.Plot_IDTextBox.Location = New System.Drawing.Point(138, 208)
        Me.Plot_IDTextBox.Name = "Plot_IDTextBox"
        Me.Plot_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Plot_IDTextBox.TabIndex = 4
        '
        'Urban_Garden_NameTextBox
        '
        Me.Urban_Garden_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GardenerBindingSource, "Urban Garden Name", True))
        Me.Urban_Garden_NameTextBox.Location = New System.Drawing.Point(138, 287)
        Me.Urban_Garden_NameTextBox.Name = "Urban_Garden_NameTextBox"
        Me.Urban_Garden_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Urban_Garden_NameTextBox.TabIndex = 8
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GardenerBindingSource, "Location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(360, 206)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LocationTextBox.TabIndex = 10
        '
        'Plot_OwnershipTextBox
        '
        Me.Plot_OwnershipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GardenerBindingSource, "Plot Ownership", True))
        Me.Plot_OwnershipTextBox.Location = New System.Drawing.Point(360, 246)
        Me.Plot_OwnershipTextBox.Name = "Plot_OwnershipTextBox"
        Me.Plot_OwnershipTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Plot_OwnershipTextBox.TabIndex = 12
        '
        'CostTextBox
        '
        Me.CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GardenerBindingSource, "Cost", True))
        Me.CostTextBox.Location = New System.Drawing.Point(360, 287)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CostTextBox.TabIndex = 14
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.GardenerBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(552, 25)
        Me.BindingNavigator1.TabIndex = 15
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Week4Day1GardenDemo.My.Resources.Resources.save_button_icon_73092
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolSaveButton"
        '
        'picGarden
        '
        Me.picGarden.Image = Global.Week4Day1GardenDemo.My.Resources.Resources.Garden
        Me.picGarden.Location = New System.Drawing.Point(12, 37)
        Me.picGarden.Name = "picGarden"
        Me.picGarden.Size = New System.Drawing.Size(228, 150)
        Me.picGarden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGarden.TabIndex = 0
        Me.picGarden.TabStop = False
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Location = New System.Drawing.Point(199, 385)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(41, 13)
        Me.lblDisplay.TabIndex = 16
        Me.lblDisplay.Text = "Display"
        Me.lblDisplay.Visible = False
        '
        'Gardener_NameComboBox
        '
        Me.Gardener_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GardenerBindingSource, "Gardener Name", True))
        Me.Gardener_NameComboBox.DataSource = Me.GardenerBindingSource
        Me.Gardener_NameComboBox.DisplayMember = "Gardener Name"
        Me.Gardener_NameComboBox.FormattingEnabled = True
        Me.Gardener_NameComboBox.Location = New System.Drawing.Point(138, 246)
        Me.Gardener_NameComboBox.Name = "Gardener_NameComboBox"
        Me.Gardener_NameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Gardener_NameComboBox.TabIndex = 17
        '
        'frmUrbanGarden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 430)
        Me.Controls.Add(Gardener_NameLabel1)
        Me.Controls.Add(Me.Gardener_NameComboBox)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(CostLabel)
        Me.Controls.Add(Me.CostTextBox)
        Me.Controls.Add(Plot_OwnershipLabel)
        Me.Controls.Add(Me.Plot_OwnershipTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Urban_Garden_NameLabel)
        Me.Controls.Add(Me.Urban_Garden_NameTextBox)
        Me.Controls.Add(Plot_IDLabel)
        Me.Controls.Add(Me.Plot_IDTextBox)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picGarden)
        Me.Name = "frmUrbanGarden"
        Me.Text = "Urban Garden"
        CType(Me.GardenDataSetLive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GardenerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.picGarden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picGarden As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents GardenDataSetLive As Week4Day1GardenDemo.GardenDataSetLive
    Friend WithEvents GardenerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GardenerTableAdapter As Week4Day1GardenDemo.GardenDataSetLiveTableAdapters.GardenerTableAdapter
    Friend WithEvents TableAdapterManager As Week4Day1GardenDemo.GardenDataSetLiveTableAdapters.TableAdapterManager
    Friend WithEvents Plot_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Urban_Garden_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Plot_OwnershipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents Gardener_NameComboBox As System.Windows.Forms.ComboBox

End Class
