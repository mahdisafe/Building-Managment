namespace Building_Managment.Views.RentView {
    partial class RentView {
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
						this.RentDetailesGridControl = new DevExpress.XtraGrid.GridControl();
			this.RentDetailesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.RentDetailesBarManager = new DevExpress.XtraBars.BarManager();
			this.RentDetailesBar = new DevExpress.XtraBars.Bar();
			this.RentDetailesXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.RentDetailesPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiRentDetailesNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiRentDetailesEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiRentDetailesDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiRentDetailesRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.RentDetailesBarManager)).BeginInit();
									this.CustomerLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
						this.PaymentMethodLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.PaymentMethodBindingSource = new System.Windows.Forms.BindingSource(this.components);
						this.PaymentTypeLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.PaymentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
						this.ShopLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.ShopBindingSource = new System.Windows.Forms.BindingSource(this.components);
						this.User_TableLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.User_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			 
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
			this.rentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.rentViewBindingSource.DataSource = typeof(Building_Managment.MyCode.Rent);
			this.dataLayoutControl1.DataSource = rentViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//RentDetailesGridControl
			//
			this.RentDetailesGridControl.MainView = this.RentDetailesGridView;
			this.RentDetailesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RentDetailesGridControl.Name = "RentDetailesGridControl";
            this.RentDetailesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.RentDetailesGridView});
			//
			//RentDetailesGridView
			//
            this.RentDetailesGridView.GridControl = this.RentDetailesGridControl;
            this.RentDetailesGridView.Name = "RentDetailesGridView";
            this.RentDetailesGridView.OptionsBehavior.Editable = false;
            this.RentDetailesGridView.OptionsBehavior.ReadOnly = true;
			this.RentDetailesGridView.OptionsView.ShowGroupPanel = false;
			//
			//RentDetailesPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters RentDetailesPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PaymentMethodRentDetailesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PaymentMethodRentDetailesChildPopulateColumnParameters_NotVisible.FieldName = "PaymentMethod";
		    PaymentMethodRentDetailesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			RentDetailesPopulateColumnsParameters.CustomColumnParameters.Add(PaymentMethodRentDetailesChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters RentRentDetailesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            RentRentDetailesChildPopulateColumnParameters_NotVisible.FieldName = "Rent";
		    RentRentDetailesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			RentDetailesPopulateColumnsParameters.CustomColumnParameters.Add(RentRentDetailesChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CustomerRentDetailesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CustomerRentDetailesChildPopulateColumnParameters.FieldName = "CustomerRentDetailes";
            CustomerRentDetailesChildPopulateColumnParameters.Path = "Customer.CustomerName";
			RentDetailesPopulateColumnsParameters.CustomColumnParameters.Add(CustomerRentDetailesChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PaymentMethodRentDetailesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PaymentMethodRentDetailesChildPopulateColumnParameters.FieldName = "PaymentMethodRentDetailes";
            PaymentMethodRentDetailesChildPopulateColumnParameters.Path = "PaymentMethod.PaymentType";
			RentDetailesPopulateColumnsParameters.CustomColumnParameters.Add(PaymentMethodRentDetailesChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PaymentTypeRentDetailesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PaymentTypeRentDetailesChildPopulateColumnParameters.FieldName = "PaymentTypeRentDetailes";
            PaymentTypeRentDetailesChildPopulateColumnParameters.Path = "PaymentType.Type";
			RentDetailesPopulateColumnsParameters.CustomColumnParameters.Add(PaymentTypeRentDetailesChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ShopRentDetailesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ShopRentDetailesChildPopulateColumnParameters.FieldName = "ShopRentDetailes";
            ShopRentDetailesChildPopulateColumnParameters.Path = "Shop.ShopLable";
			RentDetailesPopulateColumnsParameters.CustomColumnParameters.Add(ShopRentDetailesChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_TableRentDetailesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_TableRentDetailesChildPopulateColumnParameters.FieldName = "User_TableRentDetailes";
            User_TableRentDetailesChildPopulateColumnParameters.Path = "User_Table.UserName";
			RentDetailesPopulateColumnsParameters.CustomColumnParameters.Add(User_TableRentDetailesChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters RentDetailesRentDetailesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            RentDetailesRentDetailesChildPopulateColumnParameters.FieldName = "RentDetailesRentDetailes";
            RentDetailesRentDetailesChildPopulateColumnParameters.Path = "RentDetailes.RentDetaile_ID";
			RentDetailesPopulateColumnsParameters.CustomColumnParameters.Add(RentDetailesRentDetailesChildPopulateColumnParameters);
			 
		    this.RentDetailesGridView.PopulateColumns(typeof(Building_Managment.MyCode.RentDetaile),RentDetailesPopulateColumnsParameters);
			//
			//RentDetailesBindingSource
			//
			System.Windows.Forms.BindingSource RentDetailesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			RentDetailesBindingSource.DataSource = typeof(Building_Managment.MyCode.RentDetaile);
            this.RentDetailesGridControl.DataSource = RentDetailesBindingSource;
			//
			//RentDetailesXtraUserControl
			//
            this.RentDetailesXtraUserControl.Controls.Add(RentDetailesGridControl);
			this.RentDetailesXtraUserControl.Name = "RentDetailesXtraUserControl";
			this.RentDetailesXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//RentDetailesNew
			//
			this.bbiRentDetailesNew.Caption = "New";
			this.bbiRentDetailesNew.Name = "bbiRentDetailesNew";
			this.bbiRentDetailesNew.ImageUri.Uri = "New";
			this.bbiRentDetailesNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.RentDetailesBarManager.Items.Add(this.bbiRentDetailesNew);
			this.RentDetailesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentDetailesNew));
			this.RentDetailesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentDetailesNew));
						//
			//RentDetailesEdit
			//
			this.bbiRentDetailesEdit.Caption = "Edit";
			this.bbiRentDetailesEdit.Name = "bbiRentDetailesEdit";
			this.bbiRentDetailesEdit.ImageUri.Uri = "Edit";
			this.bbiRentDetailesEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.RentDetailesBarManager.Items.Add(this.bbiRentDetailesEdit);
			this.RentDetailesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentDetailesEdit));
			this.RentDetailesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentDetailesEdit));
						//
			//RentDetailesDelete
			//
			this.bbiRentDetailesDelete.Caption = "Delete";
			this.bbiRentDetailesDelete.Name = "bbiRentDetailesDelete";
			this.bbiRentDetailesDelete.ImageUri.Uri = "Delete";
			this.bbiRentDetailesDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.RentDetailesBarManager.Items.Add(this.bbiRentDetailesDelete);
			this.RentDetailesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentDetailesDelete));
			this.RentDetailesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentDetailesDelete));
						//
			//RentDetailesRefresh
			//
			this.bbiRentDetailesRefresh.Caption = "Refresh";
			this.bbiRentDetailesRefresh.Name = "bbiRentDetailesRefresh";
			this.bbiRentDetailesRefresh.ImageUri.Uri = "Refresh";
			this.bbiRentDetailesRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.RentDetailesBarManager.Items.Add(this.bbiRentDetailesRefresh);
			this.RentDetailesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentDetailesRefresh));
			this.RentDetailesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentDetailesRefresh));
						//
			//RentDetailesBar
			//
			this.RentDetailesBar.BarName = "RentDetailes";
            this.RentDetailesBar.DockCol = 0;
            this.RentDetailesBar.DockRow = 0;
            this.RentDetailesBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.RentDetailesBar.OptionsBar.AllowQuickCustomization = false;
            this.RentDetailesBar.OptionsBar.DrawDragBorder = false;
            this.RentDetailesBar.Text = "RentDetailes";
			//
			//RentDetailesBarManager
			//
			this.RentDetailesBarManager.AllowCustomization = false;
            this.RentDetailesBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.RentDetailesBar});
            this.RentDetailesBarManager.Form = RentDetailesXtraUserControl;
            this.RentDetailesBarManager.MainMenu = this.RentDetailesBar;
			// 
            // RentDetailesPopUpMenu
            // 
            this.RentDetailesPopUpMenu.Manager = this.RentDetailesBarManager;
            this.RentDetailesPopUpMenu.Name = "RentDetailesPopUpMenu";
			//
			//RentDetailesRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters RentDetailesRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            RentDetailesRetriveFieldParameters.FieldName = "RentDetailes";
            RentDetailesRetriveFieldParameters.ControlForField = RentDetailesXtraUserControl;
			RentDetailesRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(RentDetailesRetriveFieldParameters);
									//
			//CustomerLookUpEdit
			//
			this.CustomerBindingSource.DataSource = typeof(Building_Managment.MyCode.Customer);
			this.CustomerLookUpEdit.Properties.ValueMember = "CutomerID"; 
			this.CustomerLookUpEdit.Properties.DisplayMember = "CustomerName";
			this.CustomerLookUpEdit.Properties.DataSource = this.CustomerBindingSource;
			this.CustomerLookUpEdit.Name = "CustomerLookUpEdit";
			this.CustomerLookUpEdit.DataBindings.Add("EditValue", rentViewBindingSource, "CutomerID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters CustomerLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            CustomerLookUpEditRetrieveFieldParameters.FieldName = "CutomerID";
            CustomerLookUpEditRetrieveFieldParameters.ControlForField = this.CustomerLookUpEdit;
			parameters.CustomListParameters.Add(CustomerLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters CustomerLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    CustomerLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Customer";
		    CustomerLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(CustomerLookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//PaymentMethodLookUpEdit
			//
			this.PaymentMethodBindingSource.DataSource = typeof(Building_Managment.MyCode.PaymentMethod);
			this.PaymentMethodLookUpEdit.Properties.ValueMember = "MethodID"; 
			this.PaymentMethodLookUpEdit.Properties.DisplayMember = "PaymentType";
			this.PaymentMethodLookUpEdit.Properties.DataSource = this.PaymentMethodBindingSource;
			this.PaymentMethodLookUpEdit.Name = "PaymentMethodLookUpEdit";
			this.PaymentMethodLookUpEdit.DataBindings.Add("EditValue", rentViewBindingSource, "MethodID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters PaymentMethodLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            PaymentMethodLookUpEditRetrieveFieldParameters.FieldName = "MethodID";
            PaymentMethodLookUpEditRetrieveFieldParameters.ControlForField = this.PaymentMethodLookUpEdit;
			parameters.CustomListParameters.Add(PaymentMethodLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters PaymentMethodLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    PaymentMethodLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "PaymentMethod";
		    PaymentMethodLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(PaymentMethodLookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//PaymentTypeLookUpEdit
			//
			this.PaymentTypeBindingSource.DataSource = typeof(Building_Managment.MyCode.PaymentType);
			this.PaymentTypeLookUpEdit.Properties.ValueMember = "Pay_ID"; 
			this.PaymentTypeLookUpEdit.Properties.DisplayMember = "Type";
			this.PaymentTypeLookUpEdit.Properties.DataSource = this.PaymentTypeBindingSource;
			this.PaymentTypeLookUpEdit.Name = "PaymentTypeLookUpEdit";
			this.PaymentTypeLookUpEdit.DataBindings.Add("EditValue", rentViewBindingSource, "Pay_ID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters PaymentTypeLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            PaymentTypeLookUpEditRetrieveFieldParameters.FieldName = "Pay_ID";
            PaymentTypeLookUpEditRetrieveFieldParameters.ControlForField = this.PaymentTypeLookUpEdit;
			parameters.CustomListParameters.Add(PaymentTypeLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters PaymentTypeLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    PaymentTypeLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "PaymentType";
		    PaymentTypeLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(PaymentTypeLookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//ShopLookUpEdit
			//
			this.ShopBindingSource.DataSource = typeof(Building_Managment.MyCode.Shop);
			this.ShopLookUpEdit.Properties.ValueMember = "ShopID"; 
			this.ShopLookUpEdit.Properties.DisplayMember = "ShopLable";
			this.ShopLookUpEdit.Properties.DataSource = this.ShopBindingSource;
			this.ShopLookUpEdit.Name = "ShopLookUpEdit";
			this.ShopLookUpEdit.DataBindings.Add("EditValue", rentViewBindingSource, "ShopID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters ShopLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            ShopLookUpEditRetrieveFieldParameters.FieldName = "ShopID";
            ShopLookUpEditRetrieveFieldParameters.ControlForField = this.ShopLookUpEdit;
			parameters.CustomListParameters.Add(ShopLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters ShopLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    ShopLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Shop";
		    ShopLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(ShopLookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//User_TableLookUpEdit
			//
			this.User_TableBindingSource.DataSource = typeof(Building_Managment.MyCode.User_Table);
			this.User_TableLookUpEdit.Properties.ValueMember = "User_ID"; 
			this.User_TableLookUpEdit.Properties.DisplayMember = "UserName";
			this.User_TableLookUpEdit.Properties.DataSource = this.User_TableBindingSource;
			this.User_TableLookUpEdit.Name = "User_TableLookUpEdit";
			this.User_TableLookUpEdit.DataBindings.Add("EditValue", rentViewBindingSource, "CreatedBy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters User_TableLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            User_TableLookUpEditRetrieveFieldParameters.FieldName = "CreatedBy";
            User_TableLookUpEditRetrieveFieldParameters.ControlForField = this.User_TableLookUpEdit;
			parameters.CustomListParameters.Add(User_TableLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters User_TableLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    User_TableLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "User_Table";
		    User_TableLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(User_TableLookUpEditRetrieveFieldParameters_NotGenerate);
			 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(Building_Managment.ViewModels.RentViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "Rent - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//RentView
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
            this.Name = "RentView";
						((System.ComponentModel.ISupportInitialize)(this.RentDetailesBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource rentViewBindingSource;
				private DevExpress.XtraGrid.GridControl RentDetailesGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView RentDetailesGridView;
		private DevExpress.XtraBars.BarManager RentDetailesBarManager;
		private DevExpress.XtraBars.Bar RentDetailesBar;
		private DevExpress.XtraEditors.XtraUserControl RentDetailesXtraUserControl;
		private DevExpress.XtraBars.PopupMenu RentDetailesPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiRentDetailesNew;
				private DevExpress.XtraBars.BarButtonItem bbiRentDetailesEdit;
				private DevExpress.XtraBars.BarButtonItem bbiRentDetailesDelete;
				private DevExpress.XtraBars.BarButtonItem bbiRentDetailesRefresh;
								private DevExpress.XtraEditors.GridLookUpEdit CustomerLookUpEdit;
		private System.Windows.Forms.BindingSource CustomerBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit PaymentMethodLookUpEdit;
		private System.Windows.Forms.BindingSource PaymentMethodBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit PaymentTypeLookUpEdit;
		private System.Windows.Forms.BindingSource PaymentTypeBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit ShopLookUpEdit;
		private System.Windows.Forms.BindingSource ShopBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit User_TableLookUpEdit;
		private System.Windows.Forms.BindingSource User_TableBindingSource;
		 
	}
}
