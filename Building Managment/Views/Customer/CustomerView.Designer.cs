namespace Building_Managment.Views.CustomerView {
    partial class CustomerView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		 #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.windowsUIButtonPanelCloseButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
			this.labelControl = new DevExpress.XtraEditors.LabelControl();
						this.RentsGridControl = new DevExpress.XtraGrid.GridControl();
			this.RentsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.RentsBarManager = new DevExpress.XtraBars.BarManager();
			this.RentsBar = new DevExpress.XtraBars.Bar();
			this.RentsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.RentsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiRentsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiRentsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiRentsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiRentsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.RentsBarManager)).BeginInit();
						this.CustomersAttachmentsGridControl = new DevExpress.XtraGrid.GridControl();
			this.CustomersAttachmentsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.CustomersAttachmentsBarManager = new DevExpress.XtraBars.BarManager();
			this.CustomersAttachmentsBar = new DevExpress.XtraBars.Bar();
			this.CustomersAttachmentsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.CustomersAttachmentsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiCustomersAttachmentsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiCustomersAttachmentsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiCustomersAttachmentsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiCustomersAttachmentsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.CustomersAttachmentsBarManager)).BeginInit();
									this.CustomerTypeLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.CustomerTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			 
			this.SuspendLayout();
			// 
            // windowsUIButtonPanelCloseButton
            // 
            this.windowsUIButtonPanelCloseButton.ButtonInterval = 0;
            this.windowsUIButtonPanelCloseButton.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", null, "Backward;Size32x32;GrayScaled")});
            this.windowsUIButtonPanelCloseButton.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.windowsUIButtonPanelCloseButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.windowsUIButtonPanelCloseButton.ForeColor = System.Drawing.Color.Gray;
            this.windowsUIButtonPanelCloseButton.MaximumSize = new System.Drawing.Size(45, 0);
            this.windowsUIButtonPanelCloseButton.MinimumSize = new System.Drawing.Size(45, 0);
            this.windowsUIButtonPanelCloseButton.Name = "windowsUIButtonPanelCloseButton";
            this.windowsUIButtonPanelCloseButton.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.windowsUIButtonPanelCloseButton.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.windowsUIButtonPanelCloseButton.Text = "windowsUIButtonPanel1";
			// 
            // windowsUIButtonPanelMain
            // 
			this.windowsUIButtonPanelMain.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.windowsUIButtonPanelMain.EnableImageTransparency = true;
            this.windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain";
			this.windowsUIButtonPanelMain.MinimumSize = new System.Drawing.Size(60, 60);
			this.windowsUIButtonPanelMain.MaximumSize = new System.Drawing.Size(0, 60);
            this.windowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.windowsUIButtonPanelMain.UseButtonBackgroundImages = false;
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save", null, "Save;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And Close", null, "SaveAndClose;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And New", null, "SaveAndNew;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Reset Changes", null, "Reset;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", null, "Edit/Delete;Size32x32;GrayScaled"));
						// 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.TextVisible = false;
			// 
            // dataLayoutControl1item.CommandPropertyName
            // 
            this.dataLayoutControl1.AllowCustomization = false;
			this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataLayoutControl1.Root = this.layoutControlGroup1;
			this.customerViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.customerViewBindingSource.DataSource = typeof(Building_Managment.MyCode.Customer);
			this.dataLayoutControl1.DataSource = customerViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//RentsGridControl
			//
			this.RentsGridControl.MainView = this.RentsGridView;
			this.RentsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RentsGridControl.Name = "RentsGridControl";
            this.RentsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.RentsGridView});
			//
			//RentsGridView
			//
            this.RentsGridView.GridControl = this.RentsGridControl;
            this.RentsGridView.Name = "RentsGridView";
            this.RentsGridView.OptionsBehavior.Editable = false;
            this.RentsGridView.OptionsBehavior.ReadOnly = true;
			this.RentsGridView.OptionsView.ShowGroupPanel = false;
			//
			//RentsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters RentsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CustomerRentsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CustomerRentsChildPopulateColumnParameters_NotVisible.FieldName = "Customer";
		    CustomerRentsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			RentsPopulateColumnsParameters.CustomColumnParameters.Add(CustomerRentsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PaymentMethodRentsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PaymentMethodRentsChildPopulateColumnParameters_NotVisible.FieldName = "PaymentMethod";
		    PaymentMethodRentsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			RentsPopulateColumnsParameters.CustomColumnParameters.Add(PaymentMethodRentsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PaymentTypeRentsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PaymentTypeRentsChildPopulateColumnParameters_NotVisible.FieldName = "PaymentType";
		    PaymentTypeRentsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			RentsPopulateColumnsParameters.CustomColumnParameters.Add(PaymentTypeRentsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters RentDetailesRentsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            RentDetailesRentsChildPopulateColumnParameters_NotVisible.FieldName = "RentDetailes";
		    RentDetailesRentsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			RentsPopulateColumnsParameters.CustomColumnParameters.Add(RentDetailesRentsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ShopRentsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ShopRentsChildPopulateColumnParameters_NotVisible.FieldName = "Shop";
		    ShopRentsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			RentsPopulateColumnsParameters.CustomColumnParameters.Add(ShopRentsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_TableRentsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_TableRentsChildPopulateColumnParameters_NotVisible.FieldName = "User_Table";
		    User_TableRentsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			RentsPopulateColumnsParameters.CustomColumnParameters.Add(User_TableRentsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters RentsRentsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            RentsRentsChildPopulateColumnParameters.FieldName = "RentsRents";
            RentsRentsChildPopulateColumnParameters.Path = "Rents.RentID";
			RentsPopulateColumnsParameters.CustomColumnParameters.Add(RentsRentsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CustomerTypeRentsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CustomerTypeRentsChildPopulateColumnParameters.FieldName = "CustomerTypeRents";
            CustomerTypeRentsChildPopulateColumnParameters.Path = "CustomerType.CustomerType1";
			RentsPopulateColumnsParameters.CustomColumnParameters.Add(CustomerTypeRentsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CustomersAttachmentsRentsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CustomersAttachmentsRentsChildPopulateColumnParameters.FieldName = "CustomersAttachmentsRents";
            CustomersAttachmentsRentsChildPopulateColumnParameters.Path = "CustomersAttachments.AttachmentName";
			RentsPopulateColumnsParameters.CustomColumnParameters.Add(CustomersAttachmentsRentsChildPopulateColumnParameters);
			 
		    this.RentsGridView.PopulateColumns(typeof(Building_Managment.MyCode.Rent),RentsPopulateColumnsParameters);
			//
			//RentsBindingSource
			//
			System.Windows.Forms.BindingSource RentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			RentsBindingSource.DataSource = typeof(Building_Managment.MyCode.Rent);
            this.RentsGridControl.DataSource = RentsBindingSource;
			//
			//RentsXtraUserControl
			//
            this.RentsXtraUserControl.Controls.Add(RentsGridControl);
			this.RentsXtraUserControl.Name = "RentsXtraUserControl";
			this.RentsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//RentsNew
			//
			this.bbiRentsNew.Caption = "New";
			this.bbiRentsNew.Name = "bbiRentsNew";
			this.bbiRentsNew.ImageUri.Uri = "New";
			this.bbiRentsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.RentsBarManager.Items.Add(this.bbiRentsNew);
			this.RentsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentsNew));
			this.RentsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentsNew));
						//
			//RentsEdit
			//
			this.bbiRentsEdit.Caption = "Edit";
			this.bbiRentsEdit.Name = "bbiRentsEdit";
			this.bbiRentsEdit.ImageUri.Uri = "Edit";
			this.bbiRentsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.RentsBarManager.Items.Add(this.bbiRentsEdit);
			this.RentsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentsEdit));
			this.RentsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentsEdit));
						//
			//RentsDelete
			//
			this.bbiRentsDelete.Caption = "Delete";
			this.bbiRentsDelete.Name = "bbiRentsDelete";
			this.bbiRentsDelete.ImageUri.Uri = "Delete";
			this.bbiRentsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.RentsBarManager.Items.Add(this.bbiRentsDelete);
			this.RentsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentsDelete));
			this.RentsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentsDelete));
						//
			//RentsRefresh
			//
			this.bbiRentsRefresh.Caption = "Refresh";
			this.bbiRentsRefresh.Name = "bbiRentsRefresh";
			this.bbiRentsRefresh.ImageUri.Uri = "Refresh";
			this.bbiRentsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.RentsBarManager.Items.Add(this.bbiRentsRefresh);
			this.RentsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentsRefresh));
			this.RentsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentsRefresh));
						//
			//RentsBar
			//
			this.RentsBar.BarName = "Rents";
            this.RentsBar.DockCol = 0;
            this.RentsBar.DockRow = 0;
            this.RentsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.RentsBar.OptionsBar.AllowQuickCustomization = false;
            this.RentsBar.OptionsBar.DrawDragBorder = false;
            this.RentsBar.Text = "Rents";
			//
			//RentsBarManager
			//
			this.RentsBarManager.AllowCustomization = false;
            this.RentsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.RentsBar});
            this.RentsBarManager.Form = RentsXtraUserControl;
            this.RentsBarManager.MainMenu = this.RentsBar;
			// 
            // RentsPopUpMenu
            // 
            this.RentsPopUpMenu.Manager = this.RentsBarManager;
            this.RentsPopUpMenu.Name = "RentsPopUpMenu";
			//
			//RentsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters RentsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            RentsRetriveFieldParameters.FieldName = "Rents";
            RentsRetriveFieldParameters.ControlForField = RentsXtraUserControl;
			RentsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(RentsRetriveFieldParameters);
						//
			//CustomersAttachmentsGridControl
			//
			this.CustomersAttachmentsGridControl.MainView = this.CustomersAttachmentsGridView;
			this.CustomersAttachmentsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersAttachmentsGridControl.Name = "CustomersAttachmentsGridControl";
            this.CustomersAttachmentsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CustomersAttachmentsGridView});
			//
			//CustomersAttachmentsGridView
			//
            this.CustomersAttachmentsGridView.GridControl = this.CustomersAttachmentsGridControl;
            this.CustomersAttachmentsGridView.Name = "CustomersAttachmentsGridView";
            this.CustomersAttachmentsGridView.OptionsBehavior.Editable = false;
            this.CustomersAttachmentsGridView.OptionsBehavior.ReadOnly = true;
			this.CustomersAttachmentsGridView.OptionsView.ShowGroupPanel = false;
			//
			//CustomersAttachmentsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters CustomersAttachmentsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CustomerCustomersAttachmentsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CustomerCustomersAttachmentsChildPopulateColumnParameters_NotVisible.FieldName = "Customer";
		    CustomerCustomersAttachmentsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			CustomersAttachmentsPopulateColumnsParameters.CustomColumnParameters.Add(CustomerCustomersAttachmentsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters RentsCustomersAttachmentsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            RentsCustomersAttachmentsChildPopulateColumnParameters.FieldName = "RentsCustomersAttachments";
            RentsCustomersAttachmentsChildPopulateColumnParameters.Path = "Rents.RentID";
			CustomersAttachmentsPopulateColumnsParameters.CustomColumnParameters.Add(RentsCustomersAttachmentsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CustomerTypeCustomersAttachmentsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CustomerTypeCustomersAttachmentsChildPopulateColumnParameters.FieldName = "CustomerTypeCustomersAttachments";
            CustomerTypeCustomersAttachmentsChildPopulateColumnParameters.Path = "CustomerType.CustomerType1";
			CustomersAttachmentsPopulateColumnsParameters.CustomColumnParameters.Add(CustomerTypeCustomersAttachmentsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CustomersAttachmentsCustomersAttachmentsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CustomersAttachmentsCustomersAttachmentsChildPopulateColumnParameters.FieldName = "CustomersAttachmentsCustomersAttachments";
            CustomersAttachmentsCustomersAttachmentsChildPopulateColumnParameters.Path = "CustomersAttachments.AttachmentName";
			CustomersAttachmentsPopulateColumnsParameters.CustomColumnParameters.Add(CustomersAttachmentsCustomersAttachmentsChildPopulateColumnParameters);
			 
		    this.CustomersAttachmentsGridView.PopulateColumns(typeof(Building_Managment.MyCode.CustomersAttachment),CustomersAttachmentsPopulateColumnsParameters);
			//
			//CustomersAttachmentsBindingSource
			//
			System.Windows.Forms.BindingSource CustomersAttachmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			CustomersAttachmentsBindingSource.DataSource = typeof(Building_Managment.MyCode.CustomersAttachment);
            this.CustomersAttachmentsGridControl.DataSource = CustomersAttachmentsBindingSource;
			//
			//CustomersAttachmentsXtraUserControl
			//
            this.CustomersAttachmentsXtraUserControl.Controls.Add(CustomersAttachmentsGridControl);
			this.CustomersAttachmentsXtraUserControl.Name = "CustomersAttachmentsXtraUserControl";
			this.CustomersAttachmentsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//CustomersAttachmentsNew
			//
			this.bbiCustomersAttachmentsNew.Caption = "New";
			this.bbiCustomersAttachmentsNew.Name = "bbiCustomersAttachmentsNew";
			this.bbiCustomersAttachmentsNew.ImageUri.Uri = "New";
			this.bbiCustomersAttachmentsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.CustomersAttachmentsBarManager.Items.Add(this.bbiCustomersAttachmentsNew);
			this.CustomersAttachmentsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCustomersAttachmentsNew));
			this.CustomersAttachmentsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCustomersAttachmentsNew));
						//
			//CustomersAttachmentsEdit
			//
			this.bbiCustomersAttachmentsEdit.Caption = "Edit";
			this.bbiCustomersAttachmentsEdit.Name = "bbiCustomersAttachmentsEdit";
			this.bbiCustomersAttachmentsEdit.ImageUri.Uri = "Edit";
			this.bbiCustomersAttachmentsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.CustomersAttachmentsBarManager.Items.Add(this.bbiCustomersAttachmentsEdit);
			this.CustomersAttachmentsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCustomersAttachmentsEdit));
			this.CustomersAttachmentsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCustomersAttachmentsEdit));
						//
			//CustomersAttachmentsDelete
			//
			this.bbiCustomersAttachmentsDelete.Caption = "Delete";
			this.bbiCustomersAttachmentsDelete.Name = "bbiCustomersAttachmentsDelete";
			this.bbiCustomersAttachmentsDelete.ImageUri.Uri = "Delete";
			this.bbiCustomersAttachmentsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.CustomersAttachmentsBarManager.Items.Add(this.bbiCustomersAttachmentsDelete);
			this.CustomersAttachmentsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCustomersAttachmentsDelete));
			this.CustomersAttachmentsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCustomersAttachmentsDelete));
						//
			//CustomersAttachmentsRefresh
			//
			this.bbiCustomersAttachmentsRefresh.Caption = "Refresh";
			this.bbiCustomersAttachmentsRefresh.Name = "bbiCustomersAttachmentsRefresh";
			this.bbiCustomersAttachmentsRefresh.ImageUri.Uri = "Refresh";
			this.bbiCustomersAttachmentsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.CustomersAttachmentsBarManager.Items.Add(this.bbiCustomersAttachmentsRefresh);
			this.CustomersAttachmentsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCustomersAttachmentsRefresh));
			this.CustomersAttachmentsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCustomersAttachmentsRefresh));
						//
			//CustomersAttachmentsBar
			//
			this.CustomersAttachmentsBar.BarName = "CustomersAttachments";
            this.CustomersAttachmentsBar.DockCol = 0;
            this.CustomersAttachmentsBar.DockRow = 0;
            this.CustomersAttachmentsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.CustomersAttachmentsBar.OptionsBar.AllowQuickCustomization = false;
            this.CustomersAttachmentsBar.OptionsBar.DrawDragBorder = false;
            this.CustomersAttachmentsBar.Text = "CustomersAttachments";
			//
			//CustomersAttachmentsBarManager
			//
			this.CustomersAttachmentsBarManager.AllowCustomization = false;
            this.CustomersAttachmentsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.CustomersAttachmentsBar});
            this.CustomersAttachmentsBarManager.Form = CustomersAttachmentsXtraUserControl;
            this.CustomersAttachmentsBarManager.MainMenu = this.CustomersAttachmentsBar;
			// 
            // CustomersAttachmentsPopUpMenu
            // 
            this.CustomersAttachmentsPopUpMenu.Manager = this.CustomersAttachmentsBarManager;
            this.CustomersAttachmentsPopUpMenu.Name = "CustomersAttachmentsPopUpMenu";
			//
			//CustomersAttachmentsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters CustomersAttachmentsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            CustomersAttachmentsRetriveFieldParameters.FieldName = "CustomersAttachments";
            CustomersAttachmentsRetriveFieldParameters.ControlForField = CustomersAttachmentsXtraUserControl;
			CustomersAttachmentsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(CustomersAttachmentsRetriveFieldParameters);
									//
			//CustomerTypeLookUpEdit
			//
			this.CustomerTypeBindingSource.DataSource = typeof(Building_Managment.MyCode.CustomerType);
			this.CustomerTypeLookUpEdit.Properties.ValueMember = "CustTypeID"; 
			this.CustomerTypeLookUpEdit.Properties.DisplayMember = "CustomerType1";
			this.CustomerTypeLookUpEdit.Properties.DataSource = this.CustomerTypeBindingSource;
			this.CustomerTypeLookUpEdit.Name = "CustomerTypeLookUpEdit";
			this.CustomerTypeLookUpEdit.DataBindings.Add("EditValue", customerViewBindingSource, "TypeID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters CustomerTypeLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            CustomerTypeLookUpEditRetrieveFieldParameters.FieldName = "TypeID";
            CustomerTypeLookUpEditRetrieveFieldParameters.ControlForField = this.CustomerTypeLookUpEdit;
			parameters.CustomListParameters.Add(CustomerTypeLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters CustomerTypeLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    CustomerTypeLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "CustomerType";
		    CustomerTypeLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(CustomerTypeLookUpEditRetrieveFieldParameters_NotGenerate);
			 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(Building_Managment.ViewModels.CustomerViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "Customer - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//CustomerView
			//
			this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.labelControl);
            this.Controls.Add(this.windowsUIButtonPanelCloseButton);
            this.Controls.Add(this.windowsUIButtonPanelMain);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "CustomerView";
						((System.ComponentModel.ISupportInitialize)(this.RentsBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.CustomersAttachmentsBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource customerViewBindingSource;
				private DevExpress.XtraGrid.GridControl RentsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView RentsGridView;
		private DevExpress.XtraBars.BarManager RentsBarManager;
		private DevExpress.XtraBars.Bar RentsBar;
		private DevExpress.XtraEditors.XtraUserControl RentsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu RentsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiRentsNew;
				private DevExpress.XtraBars.BarButtonItem bbiRentsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiRentsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiRentsRefresh;
						private DevExpress.XtraGrid.GridControl CustomersAttachmentsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView CustomersAttachmentsGridView;
		private DevExpress.XtraBars.BarManager CustomersAttachmentsBarManager;
		private DevExpress.XtraBars.Bar CustomersAttachmentsBar;
		private DevExpress.XtraEditors.XtraUserControl CustomersAttachmentsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu CustomersAttachmentsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiCustomersAttachmentsNew;
				private DevExpress.XtraBars.BarButtonItem bbiCustomersAttachmentsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiCustomersAttachmentsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiCustomersAttachmentsRefresh;
								private DevExpress.XtraEditors.GridLookUpEdit CustomerTypeLookUpEdit;
		private System.Windows.Forms.BindingSource CustomerTypeBindingSource;
		 
	}
}
