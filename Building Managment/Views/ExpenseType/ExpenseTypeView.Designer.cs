namespace Building_Managment.Views.ExpenseTypeView {
    partial class ExpenseTypeView {
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
						this.ExpensesGridControl = new DevExpress.XtraGrid.GridControl();
			this.ExpensesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ExpensesBarManager = new DevExpress.XtraBars.BarManager();
			this.ExpensesBar = new DevExpress.XtraBars.Bar();
			this.ExpensesXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.ExpensesPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiExpensesNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiExpensesEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiExpensesDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiExpensesRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.ExpensesBarManager)).BeginInit();
						 
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
			this.expenseTypeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.expenseTypeViewBindingSource.DataSource = typeof(Building_Managment.MyCode.ExpenseType);
			this.dataLayoutControl1.DataSource = expenseTypeViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//ExpensesGridControl
			//
			this.ExpensesGridControl.MainView = this.ExpensesGridView;
			this.ExpensesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpensesGridControl.Name = "ExpensesGridControl";
            this.ExpensesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ExpensesGridView});
			//
			//ExpensesGridView
			//
            this.ExpensesGridView.GridControl = this.ExpensesGridControl;
            this.ExpensesGridView.Name = "ExpensesGridView";
            this.ExpensesGridView.OptionsBehavior.Editable = false;
            this.ExpensesGridView.OptionsBehavior.ReadOnly = true;
			this.ExpensesGridView.OptionsView.ShowGroupPanel = false;
			//
			//ExpensesPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters ExpensesPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters BuildingExpensesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            BuildingExpensesChildPopulateColumnParameters_NotVisible.FieldName = "Building";
		    BuildingExpensesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ExpensesPopulateColumnsParameters.CustomColumnParameters.Add(BuildingExpensesChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ExpenseTypeExpensesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ExpenseTypeExpensesChildPopulateColumnParameters_NotVisible.FieldName = "ExpenseType";
		    ExpenseTypeExpensesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ExpensesPopulateColumnsParameters.CustomColumnParameters.Add(ExpenseTypeExpensesChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_TableExpensesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_TableExpensesChildPopulateColumnParameters_NotVisible.FieldName = "User_Table";
		    User_TableExpensesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ExpensesPopulateColumnsParameters.CustomColumnParameters.Add(User_TableExpensesChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ExpensessDetailesExpensesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ExpensessDetailesExpensesChildPopulateColumnParameters_NotVisible.FieldName = "ExpensessDetailes";
		    ExpensessDetailesExpensesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ExpensesPopulateColumnsParameters.CustomColumnParameters.Add(ExpensessDetailesExpensesChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ExpensesExpensesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ExpensesExpensesChildPopulateColumnParameters.FieldName = "ExpensesExpenses";
            ExpensesExpensesChildPopulateColumnParameters.Path = "Expenses.ExpensessDescription";
			ExpensesPopulateColumnsParameters.CustomColumnParameters.Add(ExpensesExpensesChildPopulateColumnParameters);
			 
		    this.ExpensesGridView.PopulateColumns(typeof(Building_Managment.MyCode.Expens),ExpensesPopulateColumnsParameters);
			//
			//ExpensesBindingSource
			//
			System.Windows.Forms.BindingSource ExpensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			ExpensesBindingSource.DataSource = typeof(Building_Managment.MyCode.Expens);
            this.ExpensesGridControl.DataSource = ExpensesBindingSource;
			//
			//ExpensesXtraUserControl
			//
            this.ExpensesXtraUserControl.Controls.Add(ExpensesGridControl);
			this.ExpensesXtraUserControl.Name = "ExpensesXtraUserControl";
			this.ExpensesXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//ExpensesNew
			//
			this.bbiExpensesNew.Caption = "New";
			this.bbiExpensesNew.Name = "bbiExpensesNew";
			this.bbiExpensesNew.ImageUri.Uri = "New";
			this.bbiExpensesNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ExpensesBarManager.Items.Add(this.bbiExpensesNew);
			this.ExpensesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiExpensesNew));
			this.ExpensesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiExpensesNew));
						//
			//ExpensesEdit
			//
			this.bbiExpensesEdit.Caption = "Edit";
			this.bbiExpensesEdit.Name = "bbiExpensesEdit";
			this.bbiExpensesEdit.ImageUri.Uri = "Edit";
			this.bbiExpensesEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ExpensesBarManager.Items.Add(this.bbiExpensesEdit);
			this.ExpensesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiExpensesEdit));
			this.ExpensesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiExpensesEdit));
						//
			//ExpensesDelete
			//
			this.bbiExpensesDelete.Caption = "Delete";
			this.bbiExpensesDelete.Name = "bbiExpensesDelete";
			this.bbiExpensesDelete.ImageUri.Uri = "Delete";
			this.bbiExpensesDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ExpensesBarManager.Items.Add(this.bbiExpensesDelete);
			this.ExpensesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiExpensesDelete));
			this.ExpensesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiExpensesDelete));
						//
			//ExpensesRefresh
			//
			this.bbiExpensesRefresh.Caption = "Refresh";
			this.bbiExpensesRefresh.Name = "bbiExpensesRefresh";
			this.bbiExpensesRefresh.ImageUri.Uri = "Refresh";
			this.bbiExpensesRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ExpensesBarManager.Items.Add(this.bbiExpensesRefresh);
			this.ExpensesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiExpensesRefresh));
			this.ExpensesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiExpensesRefresh));
						//
			//ExpensesBar
			//
			this.ExpensesBar.BarName = "Expenses";
            this.ExpensesBar.DockCol = 0;
            this.ExpensesBar.DockRow = 0;
            this.ExpensesBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.ExpensesBar.OptionsBar.AllowQuickCustomization = false;
            this.ExpensesBar.OptionsBar.DrawDragBorder = false;
            this.ExpensesBar.Text = "Expenses";
			//
			//ExpensesBarManager
			//
			this.ExpensesBarManager.AllowCustomization = false;
            this.ExpensesBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.ExpensesBar});
            this.ExpensesBarManager.Form = ExpensesXtraUserControl;
            this.ExpensesBarManager.MainMenu = this.ExpensesBar;
			// 
            // ExpensesPopUpMenu
            // 
            this.ExpensesPopUpMenu.Manager = this.ExpensesBarManager;
            this.ExpensesPopUpMenu.Name = "ExpensesPopUpMenu";
			//
			//ExpensesRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters ExpensesRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            ExpensesRetriveFieldParameters.FieldName = "Expenses";
            ExpensesRetriveFieldParameters.ControlForField = ExpensesXtraUserControl;
			ExpensesRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(ExpensesRetriveFieldParameters);
						 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(Building_Managment.ViewModels.ExpenseTypeViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "ExpenseType - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//ExpenseTypeView
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
            this.Name = "ExpenseTypeView";
						((System.ComponentModel.ISupportInitialize)(this.ExpensesBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource expenseTypeViewBindingSource;
				private DevExpress.XtraGrid.GridControl ExpensesGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView ExpensesGridView;
		private DevExpress.XtraBars.BarManager ExpensesBarManager;
		private DevExpress.XtraBars.Bar ExpensesBar;
		private DevExpress.XtraEditors.XtraUserControl ExpensesXtraUserControl;
		private DevExpress.XtraBars.PopupMenu ExpensesPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiExpensesNew;
				private DevExpress.XtraBars.BarButtonItem bbiExpensesEdit;
				private DevExpress.XtraBars.BarButtonItem bbiExpensesDelete;
				private DevExpress.XtraBars.BarButtonItem bbiExpensesRefresh;
						 
	}
}
