namespace Building_Managment.Views.OwnerView {
    partial class OwnerView {
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
						this.BuildingsGridControl = new DevExpress.XtraGrid.GridControl();
			this.BuildingsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.BuildingsBarManager = new DevExpress.XtraBars.BarManager();
			this.BuildingsBar = new DevExpress.XtraBars.Bar();
			this.BuildingsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.BuildingsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiBuildingsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiBuildingsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiBuildingsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiBuildingsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.BuildingsBarManager)).BeginInit();
						 
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
			this.ownerViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ownerViewBindingSource.DataSource = typeof(Building_Managment.MyCode.Owner);
			this.dataLayoutControl1.DataSource = ownerViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//BuildingsGridControl
			//
			this.BuildingsGridControl.MainView = this.BuildingsGridView;
			this.BuildingsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuildingsGridControl.Name = "BuildingsGridControl";
            this.BuildingsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.BuildingsGridView});
			//
			//BuildingsGridView
			//
            this.BuildingsGridView.GridControl = this.BuildingsGridControl;
            this.BuildingsGridView.Name = "BuildingsGridView";
            this.BuildingsGridView.OptionsBehavior.Editable = false;
            this.BuildingsGridView.OptionsBehavior.ReadOnly = true;
			this.BuildingsGridView.OptionsView.ShowGroupPanel = false;
			//
			//BuildingsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters BuildingsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters OwnerBuildingsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            OwnerBuildingsChildPopulateColumnParameters_NotVisible.FieldName = "Owner";
		    OwnerBuildingsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			BuildingsPopulateColumnsParameters.CustomColumnParameters.Add(OwnerBuildingsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ExpensesBuildingsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ExpensesBuildingsChildPopulateColumnParameters_NotVisible.FieldName = "Expenses";
		    ExpensesBuildingsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			BuildingsPopulateColumnsParameters.CustomColumnParameters.Add(ExpensesBuildingsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PurchasesBuildingsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PurchasesBuildingsChildPopulateColumnParameters_NotVisible.FieldName = "Purchases";
		    PurchasesBuildingsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			BuildingsPopulateColumnsParameters.CustomColumnParameters.Add(PurchasesBuildingsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ShopsBuildingsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ShopsBuildingsChildPopulateColumnParameters_NotVisible.FieldName = "Shops";
		    ShopsBuildingsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			BuildingsPopulateColumnsParameters.CustomColumnParameters.Add(ShopsBuildingsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters BuildingsBuildingsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            BuildingsBuildingsChildPopulateColumnParameters.FieldName = "BuildingsBuildings";
            BuildingsBuildingsChildPopulateColumnParameters.Path = "Buildings.BuildingLable";
			BuildingsPopulateColumnsParameters.CustomColumnParameters.Add(BuildingsBuildingsChildPopulateColumnParameters);
			 
		    this.BuildingsGridView.PopulateColumns(typeof(Building_Managment.MyCode.Building),BuildingsPopulateColumnsParameters);
			//
			//BuildingsBindingSource
			//
			System.Windows.Forms.BindingSource BuildingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			BuildingsBindingSource.DataSource = typeof(Building_Managment.MyCode.Building);
            this.BuildingsGridControl.DataSource = BuildingsBindingSource;
			//
			//BuildingsXtraUserControl
			//
            this.BuildingsXtraUserControl.Controls.Add(BuildingsGridControl);
			this.BuildingsXtraUserControl.Name = "BuildingsXtraUserControl";
			this.BuildingsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//BuildingsNew
			//
			this.bbiBuildingsNew.Caption = "New";
			this.bbiBuildingsNew.Name = "bbiBuildingsNew";
			this.bbiBuildingsNew.ImageUri.Uri = "New";
			this.bbiBuildingsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.BuildingsBarManager.Items.Add(this.bbiBuildingsNew);
			this.BuildingsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiBuildingsNew));
			this.BuildingsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiBuildingsNew));
						//
			//BuildingsEdit
			//
			this.bbiBuildingsEdit.Caption = "Edit";
			this.bbiBuildingsEdit.Name = "bbiBuildingsEdit";
			this.bbiBuildingsEdit.ImageUri.Uri = "Edit";
			this.bbiBuildingsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.BuildingsBarManager.Items.Add(this.bbiBuildingsEdit);
			this.BuildingsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiBuildingsEdit));
			this.BuildingsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiBuildingsEdit));
						//
			//BuildingsDelete
			//
			this.bbiBuildingsDelete.Caption = "Delete";
			this.bbiBuildingsDelete.Name = "bbiBuildingsDelete";
			this.bbiBuildingsDelete.ImageUri.Uri = "Delete";
			this.bbiBuildingsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.BuildingsBarManager.Items.Add(this.bbiBuildingsDelete);
			this.BuildingsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiBuildingsDelete));
			this.BuildingsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiBuildingsDelete));
						//
			//BuildingsRefresh
			//
			this.bbiBuildingsRefresh.Caption = "Refresh";
			this.bbiBuildingsRefresh.Name = "bbiBuildingsRefresh";
			this.bbiBuildingsRefresh.ImageUri.Uri = "Refresh";
			this.bbiBuildingsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.BuildingsBarManager.Items.Add(this.bbiBuildingsRefresh);
			this.BuildingsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiBuildingsRefresh));
			this.BuildingsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiBuildingsRefresh));
						//
			//BuildingsBar
			//
			this.BuildingsBar.BarName = "Buildings";
            this.BuildingsBar.DockCol = 0;
            this.BuildingsBar.DockRow = 0;
            this.BuildingsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.BuildingsBar.OptionsBar.AllowQuickCustomization = false;
            this.BuildingsBar.OptionsBar.DrawDragBorder = false;
            this.BuildingsBar.Text = "Buildings";
			//
			//BuildingsBarManager
			//
			this.BuildingsBarManager.AllowCustomization = false;
            this.BuildingsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.BuildingsBar});
            this.BuildingsBarManager.Form = BuildingsXtraUserControl;
            this.BuildingsBarManager.MainMenu = this.BuildingsBar;
			// 
            // BuildingsPopUpMenu
            // 
            this.BuildingsPopUpMenu.Manager = this.BuildingsBarManager;
            this.BuildingsPopUpMenu.Name = "BuildingsPopUpMenu";
			//
			//BuildingsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters BuildingsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            BuildingsRetriveFieldParameters.FieldName = "Buildings";
            BuildingsRetriveFieldParameters.ControlForField = BuildingsXtraUserControl;
			BuildingsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(BuildingsRetriveFieldParameters);
						 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(Building_Managment.ViewModels.OwnerViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "Owner - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//OwnerView
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
            this.Name = "OwnerView";
						((System.ComponentModel.ISupportInitialize)(this.BuildingsBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource ownerViewBindingSource;
				private DevExpress.XtraGrid.GridControl BuildingsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView BuildingsGridView;
		private DevExpress.XtraBars.BarManager BuildingsBarManager;
		private DevExpress.XtraBars.Bar BuildingsBar;
		private DevExpress.XtraEditors.XtraUserControl BuildingsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu BuildingsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiBuildingsNew;
				private DevExpress.XtraBars.BarButtonItem bbiBuildingsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiBuildingsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiBuildingsRefresh;
						 
	}
}
