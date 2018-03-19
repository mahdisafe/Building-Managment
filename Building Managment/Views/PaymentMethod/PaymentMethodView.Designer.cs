namespace Building_Managment.Views.PaymentMethodView {
    partial class PaymentMethodView {
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
			this.paymentMethodViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.paymentMethodViewBindingSource.DataSource = typeof(Building_Managment.MyCode.PaymentMethod);
			this.dataLayoutControl1.DataSource = paymentMethodViewBindingSource;
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
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters RentDetailesRentsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            RentDetailesRentsChildPopulateColumnParameters.FieldName = "RentDetailesRents";
            RentDetailesRentsChildPopulateColumnParameters.Path = "RentDetailes.RentDetaile_ID";
			RentsPopulateColumnsParameters.CustomColumnParameters.Add(RentDetailesRentsChildPopulateColumnParameters);
			 
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
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters RentsRentDetailesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            RentsRentDetailesChildPopulateColumnParameters.FieldName = "RentsRentDetailes";
            RentsRentDetailesChildPopulateColumnParameters.Path = "Rents.RentID";
			RentDetailesPopulateColumnsParameters.CustomColumnParameters.Add(RentsRentDetailesChildPopulateColumnParameters);
				
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
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(Building_Managment.ViewModels.PaymentMethodViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "PaymentMethod - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//PaymentMethodView
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
            this.Name = "PaymentMethodView";
						((System.ComponentModel.ISupportInitialize)(this.RentsBarManager)).EndInit();
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
		private System.Windows.Forms.BindingSource paymentMethodViewBindingSource;
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
						 
	}
}
