namespace Building_Managment.Views.PurchaseView {
    partial class PurchaseView {
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
						this.PurchasesDetailsGridControl = new DevExpress.XtraGrid.GridControl();
			this.PurchasesDetailsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.PurchasesDetailsBarManager = new DevExpress.XtraBars.BarManager();
			this.PurchasesDetailsBar = new DevExpress.XtraBars.Bar();
			this.PurchasesDetailsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.PurchasesDetailsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiPurchasesDetailsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiPurchasesDetailsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiPurchasesDetailsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiPurchasesDetailsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.PurchasesDetailsBarManager)).BeginInit();
									this.BuildingLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.BuildingBindingSource = new System.Windows.Forms.BindingSource(this.components);
						this.PurchasesType1LookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.PurchasesType1BindingSource = new System.Windows.Forms.BindingSource(this.components);
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
			this.purchaseViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.purchaseViewBindingSource.DataSource = typeof(Building_Managment.MyCode.Purchase);
			this.dataLayoutControl1.DataSource = purchaseViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//PurchasesDetailsGridControl
			//
			this.PurchasesDetailsGridControl.MainView = this.PurchasesDetailsGridView;
			this.PurchasesDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PurchasesDetailsGridControl.Name = "PurchasesDetailsGridControl";
            this.PurchasesDetailsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PurchasesDetailsGridView});
			//
			//PurchasesDetailsGridView
			//
            this.PurchasesDetailsGridView.GridControl = this.PurchasesDetailsGridControl;
            this.PurchasesDetailsGridView.Name = "PurchasesDetailsGridView";
            this.PurchasesDetailsGridView.OptionsBehavior.Editable = false;
            this.PurchasesDetailsGridView.OptionsBehavior.ReadOnly = true;
			this.PurchasesDetailsGridView.OptionsView.ShowGroupPanel = false;
			//
			//PurchasesDetailsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters PurchasesDetailsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PurchasePurchasesDetailsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PurchasePurchasesDetailsChildPopulateColumnParameters_NotVisible.FieldName = "Purchase";
		    PurchasePurchasesDetailsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			PurchasesDetailsPopulateColumnsParameters.CustomColumnParameters.Add(PurchasePurchasesDetailsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters BuildingPurchasesDetailsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            BuildingPurchasesDetailsChildPopulateColumnParameters.FieldName = "BuildingPurchasesDetails";
            BuildingPurchasesDetailsChildPopulateColumnParameters.Path = "Building.BuildingLable";
			PurchasesDetailsPopulateColumnsParameters.CustomColumnParameters.Add(BuildingPurchasesDetailsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PurchasesType1PurchasesDetailsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PurchasesType1PurchasesDetailsChildPopulateColumnParameters.FieldName = "PurchasesType1PurchasesDetails";
            PurchasesType1PurchasesDetailsChildPopulateColumnParameters.Path = "PurchasesType1.PurchasesDescription";
			PurchasesDetailsPopulateColumnsParameters.CustomColumnParameters.Add(PurchasesType1PurchasesDetailsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_TablePurchasesDetailsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_TablePurchasesDetailsChildPopulateColumnParameters.FieldName = "User_TablePurchasesDetails";
            User_TablePurchasesDetailsChildPopulateColumnParameters.Path = "User_Table.UserName";
			PurchasesDetailsPopulateColumnsParameters.CustomColumnParameters.Add(User_TablePurchasesDetailsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PurchasesDetailsPurchasesDetailsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PurchasesDetailsPurchasesDetailsChildPopulateColumnParameters.FieldName = "PurchasesDetailsPurchasesDetails";
            PurchasesDetailsPurchasesDetailsChildPopulateColumnParameters.Path = "PurchasesDetails.PurchesName";
			PurchasesDetailsPopulateColumnsParameters.CustomColumnParameters.Add(PurchasesDetailsPurchasesDetailsChildPopulateColumnParameters);
			 
		    this.PurchasesDetailsGridView.PopulateColumns(typeof(Building_Managment.MyCode.PurchasesDetail),PurchasesDetailsPopulateColumnsParameters);
			//
			//PurchasesDetailsBindingSource
			//
			System.Windows.Forms.BindingSource PurchasesDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			PurchasesDetailsBindingSource.DataSource = typeof(Building_Managment.MyCode.PurchasesDetail);
            this.PurchasesDetailsGridControl.DataSource = PurchasesDetailsBindingSource;
			//
			//PurchasesDetailsXtraUserControl
			//
            this.PurchasesDetailsXtraUserControl.Controls.Add(PurchasesDetailsGridControl);
			this.PurchasesDetailsXtraUserControl.Name = "PurchasesDetailsXtraUserControl";
			this.PurchasesDetailsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//PurchasesDetailsNew
			//
			this.bbiPurchasesDetailsNew.Caption = "New";
			this.bbiPurchasesDetailsNew.Name = "bbiPurchasesDetailsNew";
			this.bbiPurchasesDetailsNew.ImageUri.Uri = "New";
			this.bbiPurchasesDetailsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.PurchasesDetailsBarManager.Items.Add(this.bbiPurchasesDetailsNew);
			this.PurchasesDetailsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPurchasesDetailsNew));
			this.PurchasesDetailsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPurchasesDetailsNew));
						//
			//PurchasesDetailsEdit
			//
			this.bbiPurchasesDetailsEdit.Caption = "Edit";
			this.bbiPurchasesDetailsEdit.Name = "bbiPurchasesDetailsEdit";
			this.bbiPurchasesDetailsEdit.ImageUri.Uri = "Edit";
			this.bbiPurchasesDetailsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.PurchasesDetailsBarManager.Items.Add(this.bbiPurchasesDetailsEdit);
			this.PurchasesDetailsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPurchasesDetailsEdit));
			this.PurchasesDetailsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPurchasesDetailsEdit));
						//
			//PurchasesDetailsDelete
			//
			this.bbiPurchasesDetailsDelete.Caption = "Delete";
			this.bbiPurchasesDetailsDelete.Name = "bbiPurchasesDetailsDelete";
			this.bbiPurchasesDetailsDelete.ImageUri.Uri = "Delete";
			this.bbiPurchasesDetailsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.PurchasesDetailsBarManager.Items.Add(this.bbiPurchasesDetailsDelete);
			this.PurchasesDetailsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPurchasesDetailsDelete));
			this.PurchasesDetailsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPurchasesDetailsDelete));
						//
			//PurchasesDetailsRefresh
			//
			this.bbiPurchasesDetailsRefresh.Caption = "Refresh";
			this.bbiPurchasesDetailsRefresh.Name = "bbiPurchasesDetailsRefresh";
			this.bbiPurchasesDetailsRefresh.ImageUri.Uri = "Refresh";
			this.bbiPurchasesDetailsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.PurchasesDetailsBarManager.Items.Add(this.bbiPurchasesDetailsRefresh);
			this.PurchasesDetailsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPurchasesDetailsRefresh));
			this.PurchasesDetailsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPurchasesDetailsRefresh));
						//
			//PurchasesDetailsBar
			//
			this.PurchasesDetailsBar.BarName = "PurchasesDetails";
            this.PurchasesDetailsBar.DockCol = 0;
            this.PurchasesDetailsBar.DockRow = 0;
            this.PurchasesDetailsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.PurchasesDetailsBar.OptionsBar.AllowQuickCustomization = false;
            this.PurchasesDetailsBar.OptionsBar.DrawDragBorder = false;
            this.PurchasesDetailsBar.Text = "PurchasesDetails";
			//
			//PurchasesDetailsBarManager
			//
			this.PurchasesDetailsBarManager.AllowCustomization = false;
            this.PurchasesDetailsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.PurchasesDetailsBar});
            this.PurchasesDetailsBarManager.Form = PurchasesDetailsXtraUserControl;
            this.PurchasesDetailsBarManager.MainMenu = this.PurchasesDetailsBar;
			// 
            // PurchasesDetailsPopUpMenu
            // 
            this.PurchasesDetailsPopUpMenu.Manager = this.PurchasesDetailsBarManager;
            this.PurchasesDetailsPopUpMenu.Name = "PurchasesDetailsPopUpMenu";
			//
			//PurchasesDetailsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters PurchasesDetailsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            PurchasesDetailsRetriveFieldParameters.FieldName = "PurchasesDetails";
            PurchasesDetailsRetriveFieldParameters.ControlForField = PurchasesDetailsXtraUserControl;
			PurchasesDetailsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(PurchasesDetailsRetriveFieldParameters);
									//
			//BuildingLookUpEdit
			//
			this.BuildingBindingSource.DataSource = typeof(Building_Managment.MyCode.Building);
			this.BuildingLookUpEdit.Properties.ValueMember = "BuildingID"; 
			this.BuildingLookUpEdit.Properties.DisplayMember = "BuildingLable";
			this.BuildingLookUpEdit.Properties.DataSource = this.BuildingBindingSource;
			this.BuildingLookUpEdit.Name = "BuildingLookUpEdit";
			this.BuildingLookUpEdit.DataBindings.Add("EditValue", purchaseViewBindingSource, "Building_ID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters BuildingLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            BuildingLookUpEditRetrieveFieldParameters.FieldName = "Building_ID";
            BuildingLookUpEditRetrieveFieldParameters.ControlForField = this.BuildingLookUpEdit;
			parameters.CustomListParameters.Add(BuildingLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters BuildingLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    BuildingLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Building";
		    BuildingLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(BuildingLookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//PurchasesType1LookUpEdit
			//
			this.PurchasesType1BindingSource.DataSource = typeof(Building_Managment.MyCode.PurchasesType);
			this.PurchasesType1LookUpEdit.Properties.ValueMember = "ID"; 
			this.PurchasesType1LookUpEdit.Properties.DisplayMember = "PurchasesDescription";
			this.PurchasesType1LookUpEdit.Properties.DataSource = this.PurchasesType1BindingSource;
			this.PurchasesType1LookUpEdit.Name = "PurchasesType1LookUpEdit";
			this.PurchasesType1LookUpEdit.DataBindings.Add("EditValue", purchaseViewBindingSource, "PurchasesType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters PurchasesType1LookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            PurchasesType1LookUpEditRetrieveFieldParameters.FieldName = "PurchasesType";
            PurchasesType1LookUpEditRetrieveFieldParameters.ControlForField = this.PurchasesType1LookUpEdit;
			parameters.CustomListParameters.Add(PurchasesType1LookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters PurchasesType1LookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    PurchasesType1LookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "PurchasesType1";
		    PurchasesType1LookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(PurchasesType1LookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//User_TableLookUpEdit
			//
			this.User_TableBindingSource.DataSource = typeof(Building_Managment.MyCode.User_Table);
			this.User_TableLookUpEdit.Properties.ValueMember = "User_ID"; 
			this.User_TableLookUpEdit.Properties.DisplayMember = "UserName";
			this.User_TableLookUpEdit.Properties.DataSource = this.User_TableBindingSource;
			this.User_TableLookUpEdit.Name = "User_TableLookUpEdit";
			this.User_TableLookUpEdit.DataBindings.Add("EditValue", purchaseViewBindingSource, "CreatedBy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
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
            this.mvvmContext.ViewModelType = typeof(Building_Managment.ViewModels.PurchaseViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "Purchase - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//PurchaseView
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
            this.Name = "PurchaseView";
						((System.ComponentModel.ISupportInitialize)(this.PurchasesDetailsBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource purchaseViewBindingSource;
				private DevExpress.XtraGrid.GridControl PurchasesDetailsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView PurchasesDetailsGridView;
		private DevExpress.XtraBars.BarManager PurchasesDetailsBarManager;
		private DevExpress.XtraBars.Bar PurchasesDetailsBar;
		private DevExpress.XtraEditors.XtraUserControl PurchasesDetailsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu PurchasesDetailsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiPurchasesDetailsNew;
				private DevExpress.XtraBars.BarButtonItem bbiPurchasesDetailsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiPurchasesDetailsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiPurchasesDetailsRefresh;
								private DevExpress.XtraEditors.GridLookUpEdit BuildingLookUpEdit;
		private System.Windows.Forms.BindingSource BuildingBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit PurchasesType1LookUpEdit;
		private System.Windows.Forms.BindingSource PurchasesType1BindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit User_TableLookUpEdit;
		private System.Windows.Forms.BindingSource User_TableBindingSource;
		 
	}
}
