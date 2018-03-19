namespace Building_Managment.Views.ExpensView {
    partial class ExpensView {
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
						this.ExpensessDetailesGridControl = new DevExpress.XtraGrid.GridControl();
			this.ExpensessDetailesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ExpensessDetailesBarManager = new DevExpress.XtraBars.BarManager();
			this.ExpensessDetailesBar = new DevExpress.XtraBars.Bar();
			this.ExpensessDetailesXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.ExpensessDetailesPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiExpensessDetailesNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiExpensessDetailesEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiExpensessDetailesDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiExpensessDetailesRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.ExpensessDetailesBarManager)).BeginInit();
									this.BuildingLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.BuildingBindingSource = new System.Windows.Forms.BindingSource(this.components);
						this.ExpenseTypeLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.ExpenseTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
			this.expensViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.expensViewBindingSource.DataSource = typeof(Building_Managment.MyCode.Expens);
			this.dataLayoutControl1.DataSource = expensViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//ExpensessDetailesGridControl
			//
			this.ExpensessDetailesGridControl.MainView = this.ExpensessDetailesGridView;
			this.ExpensessDetailesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpensessDetailesGridControl.Name = "ExpensessDetailesGridControl";
            this.ExpensessDetailesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ExpensessDetailesGridView});
			//
			//ExpensessDetailesGridView
			//
            this.ExpensessDetailesGridView.GridControl = this.ExpensessDetailesGridControl;
            this.ExpensessDetailesGridView.Name = "ExpensessDetailesGridView";
            this.ExpensessDetailesGridView.OptionsBehavior.Editable = false;
            this.ExpensessDetailesGridView.OptionsBehavior.ReadOnly = true;
			this.ExpensessDetailesGridView.OptionsView.ShowGroupPanel = false;
			//
			//ExpensessDetailesPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters ExpensessDetailesPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ExpensExpensessDetailesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ExpensExpensessDetailesChildPopulateColumnParameters_NotVisible.FieldName = "Expens";
		    ExpensExpensessDetailesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ExpensessDetailesPopulateColumnsParameters.CustomColumnParameters.Add(ExpensExpensessDetailesChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters BuildingExpensessDetailesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            BuildingExpensessDetailesChildPopulateColumnParameters.FieldName = "BuildingExpensessDetailes";
            BuildingExpensessDetailesChildPopulateColumnParameters.Path = "Building.BuildingLable";
			ExpensessDetailesPopulateColumnsParameters.CustomColumnParameters.Add(BuildingExpensessDetailesChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ExpenseTypeExpensessDetailesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ExpenseTypeExpensessDetailesChildPopulateColumnParameters.FieldName = "ExpenseTypeExpensessDetailes";
            ExpenseTypeExpensessDetailesChildPopulateColumnParameters.Path = "ExpenseType.DescriptionExpenses";
			ExpensessDetailesPopulateColumnsParameters.CustomColumnParameters.Add(ExpenseTypeExpensessDetailesChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_TableExpensessDetailesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_TableExpensessDetailesChildPopulateColumnParameters.FieldName = "User_TableExpensessDetailes";
            User_TableExpensessDetailesChildPopulateColumnParameters.Path = "User_Table.UserName";
			ExpensessDetailesPopulateColumnsParameters.CustomColumnParameters.Add(User_TableExpensessDetailesChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ExpensessDetailesExpensessDetailesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ExpensessDetailesExpensessDetailesChildPopulateColumnParameters.FieldName = "ExpensessDetailesExpensessDetailes";
            ExpensessDetailesExpensessDetailesChildPopulateColumnParameters.Path = "ExpensessDetailes.ExpensessName";
			ExpensessDetailesPopulateColumnsParameters.CustomColumnParameters.Add(ExpensessDetailesExpensessDetailesChildPopulateColumnParameters);
			 
		    this.ExpensessDetailesGridView.PopulateColumns(typeof(Building_Managment.MyCode.ExpensessDetaile),ExpensessDetailesPopulateColumnsParameters);
			//
			//ExpensessDetailesBindingSource
			//
			System.Windows.Forms.BindingSource ExpensessDetailesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			ExpensessDetailesBindingSource.DataSource = typeof(Building_Managment.MyCode.ExpensessDetaile);
            this.ExpensessDetailesGridControl.DataSource = ExpensessDetailesBindingSource;
			//
			//ExpensessDetailesXtraUserControl
			//
            this.ExpensessDetailesXtraUserControl.Controls.Add(ExpensessDetailesGridControl);
			this.ExpensessDetailesXtraUserControl.Name = "ExpensessDetailesXtraUserControl";
			this.ExpensessDetailesXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//ExpensessDetailesNew
			//
			this.bbiExpensessDetailesNew.Caption = "New";
			this.bbiExpensessDetailesNew.Name = "bbiExpensessDetailesNew";
			this.bbiExpensessDetailesNew.ImageUri.Uri = "New";
			this.bbiExpensessDetailesNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ExpensessDetailesBarManager.Items.Add(this.bbiExpensessDetailesNew);
			this.ExpensessDetailesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiExpensessDetailesNew));
			this.ExpensessDetailesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiExpensessDetailesNew));
						//
			//ExpensessDetailesEdit
			//
			this.bbiExpensessDetailesEdit.Caption = "Edit";
			this.bbiExpensessDetailesEdit.Name = "bbiExpensessDetailesEdit";
			this.bbiExpensessDetailesEdit.ImageUri.Uri = "Edit";
			this.bbiExpensessDetailesEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ExpensessDetailesBarManager.Items.Add(this.bbiExpensessDetailesEdit);
			this.ExpensessDetailesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiExpensessDetailesEdit));
			this.ExpensessDetailesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiExpensessDetailesEdit));
						//
			//ExpensessDetailesDelete
			//
			this.bbiExpensessDetailesDelete.Caption = "Delete";
			this.bbiExpensessDetailesDelete.Name = "bbiExpensessDetailesDelete";
			this.bbiExpensessDetailesDelete.ImageUri.Uri = "Delete";
			this.bbiExpensessDetailesDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ExpensessDetailesBarManager.Items.Add(this.bbiExpensessDetailesDelete);
			this.ExpensessDetailesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiExpensessDetailesDelete));
			this.ExpensessDetailesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiExpensessDetailesDelete));
						//
			//ExpensessDetailesRefresh
			//
			this.bbiExpensessDetailesRefresh.Caption = "Refresh";
			this.bbiExpensessDetailesRefresh.Name = "bbiExpensessDetailesRefresh";
			this.bbiExpensessDetailesRefresh.ImageUri.Uri = "Refresh";
			this.bbiExpensessDetailesRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ExpensessDetailesBarManager.Items.Add(this.bbiExpensessDetailesRefresh);
			this.ExpensessDetailesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiExpensessDetailesRefresh));
			this.ExpensessDetailesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiExpensessDetailesRefresh));
						//
			//ExpensessDetailesBar
			//
			this.ExpensessDetailesBar.BarName = "ExpensessDetailes";
            this.ExpensessDetailesBar.DockCol = 0;
            this.ExpensessDetailesBar.DockRow = 0;
            this.ExpensessDetailesBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.ExpensessDetailesBar.OptionsBar.AllowQuickCustomization = false;
            this.ExpensessDetailesBar.OptionsBar.DrawDragBorder = false;
            this.ExpensessDetailesBar.Text = "ExpensessDetailes";
			//
			//ExpensessDetailesBarManager
			//
			this.ExpensessDetailesBarManager.AllowCustomization = false;
            this.ExpensessDetailesBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.ExpensessDetailesBar});
            this.ExpensessDetailesBarManager.Form = ExpensessDetailesXtraUserControl;
            this.ExpensessDetailesBarManager.MainMenu = this.ExpensessDetailesBar;
			// 
            // ExpensessDetailesPopUpMenu
            // 
            this.ExpensessDetailesPopUpMenu.Manager = this.ExpensessDetailesBarManager;
            this.ExpensessDetailesPopUpMenu.Name = "ExpensessDetailesPopUpMenu";
			//
			//ExpensessDetailesRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters ExpensessDetailesRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            ExpensessDetailesRetriveFieldParameters.FieldName = "ExpensessDetailes";
            ExpensessDetailesRetriveFieldParameters.ControlForField = ExpensessDetailesXtraUserControl;
			ExpensessDetailesRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(ExpensessDetailesRetriveFieldParameters);
									//
			//BuildingLookUpEdit
			//
			this.BuildingBindingSource.DataSource = typeof(Building_Managment.MyCode.Building);
			this.BuildingLookUpEdit.Properties.ValueMember = "BuildingID"; 
			this.BuildingLookUpEdit.Properties.DisplayMember = "BuildingLable";
			this.BuildingLookUpEdit.Properties.DataSource = this.BuildingBindingSource;
			this.BuildingLookUpEdit.Name = "BuildingLookUpEdit";
			this.BuildingLookUpEdit.DataBindings.Add("EditValue", expensViewBindingSource, "Building_ID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters BuildingLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            BuildingLookUpEditRetrieveFieldParameters.FieldName = "Building_ID";
            BuildingLookUpEditRetrieveFieldParameters.ControlForField = this.BuildingLookUpEdit;
			parameters.CustomListParameters.Add(BuildingLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters BuildingLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    BuildingLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Building";
		    BuildingLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(BuildingLookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//ExpenseTypeLookUpEdit
			//
			this.ExpenseTypeBindingSource.DataSource = typeof(Building_Managment.MyCode.ExpenseType);
			this.ExpenseTypeLookUpEdit.Properties.ValueMember = "ID"; 
			this.ExpenseTypeLookUpEdit.Properties.DisplayMember = "DescriptionExpenses";
			this.ExpenseTypeLookUpEdit.Properties.DataSource = this.ExpenseTypeBindingSource;
			this.ExpenseTypeLookUpEdit.Name = "ExpenseTypeLookUpEdit";
			this.ExpenseTypeLookUpEdit.DataBindings.Add("EditValue", expensViewBindingSource, "ExpType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters ExpenseTypeLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            ExpenseTypeLookUpEditRetrieveFieldParameters.FieldName = "ExpType";
            ExpenseTypeLookUpEditRetrieveFieldParameters.ControlForField = this.ExpenseTypeLookUpEdit;
			parameters.CustomListParameters.Add(ExpenseTypeLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters ExpenseTypeLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    ExpenseTypeLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "ExpenseType";
		    ExpenseTypeLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(ExpenseTypeLookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//User_TableLookUpEdit
			//
			this.User_TableBindingSource.DataSource = typeof(Building_Managment.MyCode.User_Table);
			this.User_TableLookUpEdit.Properties.ValueMember = "User_ID"; 
			this.User_TableLookUpEdit.Properties.DisplayMember = "UserName";
			this.User_TableLookUpEdit.Properties.DataSource = this.User_TableBindingSource;
			this.User_TableLookUpEdit.Name = "User_TableLookUpEdit";
			this.User_TableLookUpEdit.DataBindings.Add("EditValue", expensViewBindingSource, "CreatedBy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
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
            this.mvvmContext.ViewModelType = typeof(Building_Managment.ViewModels.ExpensViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "Expens - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//ExpensView
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
            this.Name = "ExpensView";
						((System.ComponentModel.ISupportInitialize)(this.ExpensessDetailesBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource expensViewBindingSource;
				private DevExpress.XtraGrid.GridControl ExpensessDetailesGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView ExpensessDetailesGridView;
		private DevExpress.XtraBars.BarManager ExpensessDetailesBarManager;
		private DevExpress.XtraBars.Bar ExpensessDetailesBar;
		private DevExpress.XtraEditors.XtraUserControl ExpensessDetailesXtraUserControl;
		private DevExpress.XtraBars.PopupMenu ExpensessDetailesPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiExpensessDetailesNew;
				private DevExpress.XtraBars.BarButtonItem bbiExpensessDetailesEdit;
				private DevExpress.XtraBars.BarButtonItem bbiExpensessDetailesDelete;
				private DevExpress.XtraBars.BarButtonItem bbiExpensessDetailesRefresh;
								private DevExpress.XtraEditors.GridLookUpEdit BuildingLookUpEdit;
		private System.Windows.Forms.BindingSource BuildingBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit ExpenseTypeLookUpEdit;
		private System.Windows.Forms.BindingSource ExpenseTypeBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit User_TableLookUpEdit;
		private System.Windows.Forms.BindingSource User_TableBindingSource;
		 
	}
}
