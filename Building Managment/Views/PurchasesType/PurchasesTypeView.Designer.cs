namespace Building_Managment.Views.PurchasesTypeView {
    partial class PurchasesTypeView {
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
						this.PurchasesGridControl = new DevExpress.XtraGrid.GridControl();
			this.PurchasesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.PurchasesBarManager = new DevExpress.XtraBars.BarManager();
			this.PurchasesBar = new DevExpress.XtraBars.Bar();
			this.PurchasesXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.PurchasesPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiPurchasesNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiPurchasesEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiPurchasesDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiPurchasesRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.PurchasesBarManager)).BeginInit();
						 
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
			this.purchasesTypeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.purchasesTypeViewBindingSource.DataSource = typeof(Building_Managment.MyCode.PurchasesType);
			this.dataLayoutControl1.DataSource = purchasesTypeViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//PurchasesGridControl
			//
			this.PurchasesGridControl.MainView = this.PurchasesGridView;
			this.PurchasesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PurchasesGridControl.Name = "PurchasesGridControl";
            this.PurchasesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PurchasesGridView});
			//
			//PurchasesGridView
			//
            this.PurchasesGridView.GridControl = this.PurchasesGridControl;
            this.PurchasesGridView.Name = "PurchasesGridView";
            this.PurchasesGridView.OptionsBehavior.Editable = false;
            this.PurchasesGridView.OptionsBehavior.ReadOnly = true;
			this.PurchasesGridView.OptionsView.ShowGroupPanel = false;
			//
			//PurchasesPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters PurchasesPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters BuildingPurchasesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            BuildingPurchasesChildPopulateColumnParameters_NotVisible.FieldName = "Building";
		    BuildingPurchasesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			PurchasesPopulateColumnsParameters.CustomColumnParameters.Add(BuildingPurchasesChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PurchasesType1PurchasesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PurchasesType1PurchasesChildPopulateColumnParameters_NotVisible.FieldName = "PurchasesType1";
		    PurchasesType1PurchasesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			PurchasesPopulateColumnsParameters.CustomColumnParameters.Add(PurchasesType1PurchasesChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_TablePurchasesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_TablePurchasesChildPopulateColumnParameters_NotVisible.FieldName = "User_Table";
		    User_TablePurchasesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			PurchasesPopulateColumnsParameters.CustomColumnParameters.Add(User_TablePurchasesChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PurchasesDetailsPurchasesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PurchasesDetailsPurchasesChildPopulateColumnParameters_NotVisible.FieldName = "PurchasesDetails";
		    PurchasesDetailsPurchasesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			PurchasesPopulateColumnsParameters.CustomColumnParameters.Add(PurchasesDetailsPurchasesChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PurchasesPurchasesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PurchasesPurchasesChildPopulateColumnParameters.FieldName = "PurchasesPurchases";
            PurchasesPurchasesChildPopulateColumnParameters.Path = "Purchases.Notes";
			PurchasesPopulateColumnsParameters.CustomColumnParameters.Add(PurchasesPurchasesChildPopulateColumnParameters);
			 
		    this.PurchasesGridView.PopulateColumns(typeof(Building_Managment.MyCode.Purchase),PurchasesPopulateColumnsParameters);
			//
			//PurchasesBindingSource
			//
			System.Windows.Forms.BindingSource PurchasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			PurchasesBindingSource.DataSource = typeof(Building_Managment.MyCode.Purchase);
            this.PurchasesGridControl.DataSource = PurchasesBindingSource;
			//
			//PurchasesXtraUserControl
			//
            this.PurchasesXtraUserControl.Controls.Add(PurchasesGridControl);
			this.PurchasesXtraUserControl.Name = "PurchasesXtraUserControl";
			this.PurchasesXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//PurchasesNew
			//
			this.bbiPurchasesNew.Caption = "New";
			this.bbiPurchasesNew.Name = "bbiPurchasesNew";
			this.bbiPurchasesNew.ImageUri.Uri = "New";
			this.bbiPurchasesNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.PurchasesBarManager.Items.Add(this.bbiPurchasesNew);
			this.PurchasesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPurchasesNew));
			this.PurchasesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPurchasesNew));
						//
			//PurchasesEdit
			//
			this.bbiPurchasesEdit.Caption = "Edit";
			this.bbiPurchasesEdit.Name = "bbiPurchasesEdit";
			this.bbiPurchasesEdit.ImageUri.Uri = "Edit";
			this.bbiPurchasesEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.PurchasesBarManager.Items.Add(this.bbiPurchasesEdit);
			this.PurchasesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPurchasesEdit));
			this.PurchasesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPurchasesEdit));
						//
			//PurchasesDelete
			//
			this.bbiPurchasesDelete.Caption = "Delete";
			this.bbiPurchasesDelete.Name = "bbiPurchasesDelete";
			this.bbiPurchasesDelete.ImageUri.Uri = "Delete";
			this.bbiPurchasesDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.PurchasesBarManager.Items.Add(this.bbiPurchasesDelete);
			this.PurchasesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPurchasesDelete));
			this.PurchasesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPurchasesDelete));
						//
			//PurchasesRefresh
			//
			this.bbiPurchasesRefresh.Caption = "Refresh";
			this.bbiPurchasesRefresh.Name = "bbiPurchasesRefresh";
			this.bbiPurchasesRefresh.ImageUri.Uri = "Refresh";
			this.bbiPurchasesRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.PurchasesBarManager.Items.Add(this.bbiPurchasesRefresh);
			this.PurchasesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPurchasesRefresh));
			this.PurchasesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPurchasesRefresh));
						//
			//PurchasesBar
			//
			this.PurchasesBar.BarName = "Purchases";
            this.PurchasesBar.DockCol = 0;
            this.PurchasesBar.DockRow = 0;
            this.PurchasesBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.PurchasesBar.OptionsBar.AllowQuickCustomization = false;
            this.PurchasesBar.OptionsBar.DrawDragBorder = false;
            this.PurchasesBar.Text = "Purchases";
			//
			//PurchasesBarManager
			//
			this.PurchasesBarManager.AllowCustomization = false;
            this.PurchasesBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.PurchasesBar});
            this.PurchasesBarManager.Form = PurchasesXtraUserControl;
            this.PurchasesBarManager.MainMenu = this.PurchasesBar;
			// 
            // PurchasesPopUpMenu
            // 
            this.PurchasesPopUpMenu.Manager = this.PurchasesBarManager;
            this.PurchasesPopUpMenu.Name = "PurchasesPopUpMenu";
			//
			//PurchasesRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters PurchasesRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            PurchasesRetriveFieldParameters.FieldName = "Purchases";
            PurchasesRetriveFieldParameters.ControlForField = PurchasesXtraUserControl;
			PurchasesRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(PurchasesRetriveFieldParameters);
						 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(Building_Managment.ViewModels.PurchasesTypeViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "PurchasesType - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//PurchasesTypeView
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
            this.Name = "PurchasesTypeView";
						((System.ComponentModel.ISupportInitialize)(this.PurchasesBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource purchasesTypeViewBindingSource;
				private DevExpress.XtraGrid.GridControl PurchasesGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView PurchasesGridView;
		private DevExpress.XtraBars.BarManager PurchasesBarManager;
		private DevExpress.XtraBars.Bar PurchasesBar;
		private DevExpress.XtraEditors.XtraUserControl PurchasesXtraUserControl;
		private DevExpress.XtraBars.PopupMenu PurchasesPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiPurchasesNew;
				private DevExpress.XtraBars.BarButtonItem bbiPurchasesEdit;
				private DevExpress.XtraBars.BarButtonItem bbiPurchasesDelete;
				private DevExpress.XtraBars.BarButtonItem bbiPurchasesRefresh;
						 
	}
}
