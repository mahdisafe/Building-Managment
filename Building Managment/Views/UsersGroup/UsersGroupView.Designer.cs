namespace Building_Managment.Views.UsersGroupView {
    partial class UsersGroupView {
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
						this.User_TableGridControl = new DevExpress.XtraGrid.GridControl();
			this.User_TableGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.User_TableBarManager = new DevExpress.XtraBars.BarManager();
			this.User_TableBar = new DevExpress.XtraBars.Bar();
			this.User_TableXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.User_TablePopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiUser_TableNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiUser_TableEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiUser_TableDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiUser_TableRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.User_TableBarManager)).BeginInit();
						 
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
			this.usersGroupViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.usersGroupViewBindingSource.DataSource = typeof(Building_Managment.MyCode.UsersGroup);
			this.dataLayoutControl1.DataSource = usersGroupViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//User_TableGridControl
			//
			this.User_TableGridControl.MainView = this.User_TableGridView;
			this.User_TableGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_TableGridControl.Name = "User_TableGridControl";
            this.User_TableGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.User_TableGridView});
			//
			//User_TableGridView
			//
            this.User_TableGridView.GridControl = this.User_TableGridControl;
            this.User_TableGridView.Name = "User_TableGridView";
            this.User_TableGridView.OptionsBehavior.Editable = false;
            this.User_TableGridView.OptionsBehavior.ReadOnly = true;
			this.User_TableGridView.OptionsView.ShowGroupPanel = false;
			//
			//User_TablePopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters User_TablePopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ExpensesUser_TableChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ExpensesUser_TableChildPopulateColumnParameters_NotVisible.FieldName = "Expenses";
		    ExpensesUser_TableChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			User_TablePopulateColumnsParameters.CustomColumnParameters.Add(ExpensesUser_TableChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Priv_TableUser_TableChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Priv_TableUser_TableChildPopulateColumnParameters_NotVisible.FieldName = "Priv_Table";
		    Priv_TableUser_TableChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			User_TablePopulateColumnsParameters.CustomColumnParameters.Add(Priv_TableUser_TableChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PurchasesUser_TableChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PurchasesUser_TableChildPopulateColumnParameters_NotVisible.FieldName = "Purchases";
		    PurchasesUser_TableChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			User_TablePopulateColumnsParameters.CustomColumnParameters.Add(PurchasesUser_TableChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters RentsUser_TableChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            RentsUser_TableChildPopulateColumnParameters_NotVisible.FieldName = "Rents";
		    RentsUser_TableChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			User_TablePopulateColumnsParameters.CustomColumnParameters.Add(RentsUser_TableChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters UsersGroupUser_TableChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            UsersGroupUser_TableChildPopulateColumnParameters_NotVisible.FieldName = "UsersGroup";
		    UsersGroupUser_TableChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			User_TablePopulateColumnsParameters.CustomColumnParameters.Add(UsersGroupUser_TableChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_TableUser_TableChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_TableUser_TableChildPopulateColumnParameters.FieldName = "User_TableUser_Table";
            User_TableUser_TableChildPopulateColumnParameters.Path = "User_Table.UserName";
			User_TablePopulateColumnsParameters.CustomColumnParameters.Add(User_TableUser_TableChildPopulateColumnParameters);
			 
		    this.User_TableGridView.PopulateColumns(typeof(Building_Managment.MyCode.User_Table),User_TablePopulateColumnsParameters);
			//
			//User_TableBindingSource
			//
			System.Windows.Forms.BindingSource User_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			User_TableBindingSource.DataSource = typeof(Building_Managment.MyCode.User_Table);
            this.User_TableGridControl.DataSource = User_TableBindingSource;
			//
			//User_TableXtraUserControl
			//
            this.User_TableXtraUserControl.Controls.Add(User_TableGridControl);
			this.User_TableXtraUserControl.Name = "User_TableXtraUserControl";
			this.User_TableXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//User_TableNew
			//
			this.bbiUser_TableNew.Caption = "New";
			this.bbiUser_TableNew.Name = "bbiUser_TableNew";
			this.bbiUser_TableNew.ImageUri.Uri = "New";
			this.bbiUser_TableNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.User_TableBarManager.Items.Add(this.bbiUser_TableNew);
			this.User_TableBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUser_TableNew));
			this.User_TablePopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUser_TableNew));
						//
			//User_TableEdit
			//
			this.bbiUser_TableEdit.Caption = "Edit";
			this.bbiUser_TableEdit.Name = "bbiUser_TableEdit";
			this.bbiUser_TableEdit.ImageUri.Uri = "Edit";
			this.bbiUser_TableEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.User_TableBarManager.Items.Add(this.bbiUser_TableEdit);
			this.User_TableBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUser_TableEdit));
			this.User_TablePopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUser_TableEdit));
						//
			//User_TableDelete
			//
			this.bbiUser_TableDelete.Caption = "Delete";
			this.bbiUser_TableDelete.Name = "bbiUser_TableDelete";
			this.bbiUser_TableDelete.ImageUri.Uri = "Delete";
			this.bbiUser_TableDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.User_TableBarManager.Items.Add(this.bbiUser_TableDelete);
			this.User_TableBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUser_TableDelete));
			this.User_TablePopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUser_TableDelete));
						//
			//User_TableRefresh
			//
			this.bbiUser_TableRefresh.Caption = "Refresh";
			this.bbiUser_TableRefresh.Name = "bbiUser_TableRefresh";
			this.bbiUser_TableRefresh.ImageUri.Uri = "Refresh";
			this.bbiUser_TableRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.User_TableBarManager.Items.Add(this.bbiUser_TableRefresh);
			this.User_TableBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUser_TableRefresh));
			this.User_TablePopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUser_TableRefresh));
						//
			//User_TableBar
			//
			this.User_TableBar.BarName = "User_Table";
            this.User_TableBar.DockCol = 0;
            this.User_TableBar.DockRow = 0;
            this.User_TableBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.User_TableBar.OptionsBar.AllowQuickCustomization = false;
            this.User_TableBar.OptionsBar.DrawDragBorder = false;
            this.User_TableBar.Text = "User_Table";
			//
			//User_TableBarManager
			//
			this.User_TableBarManager.AllowCustomization = false;
            this.User_TableBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.User_TableBar});
            this.User_TableBarManager.Form = User_TableXtraUserControl;
            this.User_TableBarManager.MainMenu = this.User_TableBar;
			// 
            // User_TablePopUpMenu
            // 
            this.User_TablePopUpMenu.Manager = this.User_TableBarManager;
            this.User_TablePopUpMenu.Name = "User_TablePopUpMenu";
			//
			//User_TableRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters User_TableRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            User_TableRetriveFieldParameters.FieldName = "User_Table";
            User_TableRetriveFieldParameters.ControlForField = User_TableXtraUserControl;
			User_TableRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(User_TableRetriveFieldParameters);
						 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(Building_Managment.ViewModels.UsersGroupViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "UsersGroup - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//UsersGroupView
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
            this.Name = "UsersGroupView";
						((System.ComponentModel.ISupportInitialize)(this.User_TableBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource usersGroupViewBindingSource;
				private DevExpress.XtraGrid.GridControl User_TableGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView User_TableGridView;
		private DevExpress.XtraBars.BarManager User_TableBarManager;
		private DevExpress.XtraBars.Bar User_TableBar;
		private DevExpress.XtraEditors.XtraUserControl User_TableXtraUserControl;
		private DevExpress.XtraBars.PopupMenu User_TablePopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiUser_TableNew;
				private DevExpress.XtraBars.BarButtonItem bbiUser_TableEdit;
				private DevExpress.XtraBars.BarButtonItem bbiUser_TableDelete;
				private DevExpress.XtraBars.BarButtonItem bbiUser_TableRefresh;
						 
	}
}
