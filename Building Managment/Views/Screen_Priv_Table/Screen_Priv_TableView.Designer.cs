namespace Building_Managment.Views.Screen_Priv_TableView {
    partial class Screen_Priv_TableView {
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
						this.Priv_TableGridControl = new DevExpress.XtraGrid.GridControl();
			this.Priv_TableGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.Priv_TableBarManager = new DevExpress.XtraBars.BarManager();
			this.Priv_TableBar = new DevExpress.XtraBars.Bar();
			this.Priv_TableXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.Priv_TablePopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiPriv_TableNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiPriv_TableEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiPriv_TableDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiPriv_TableRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.Priv_TableBarManager)).BeginInit();
						 
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
			this.screen_Priv_TableViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.screen_Priv_TableViewBindingSource.DataSource = typeof(Building_Managment.MyCode.Screen_Priv_Table);
			this.dataLayoutControl1.DataSource = screen_Priv_TableViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//Priv_TableGridControl
			//
			this.Priv_TableGridControl.MainView = this.Priv_TableGridView;
			this.Priv_TableGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Priv_TableGridControl.Name = "Priv_TableGridControl";
            this.Priv_TableGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Priv_TableGridView});
			//
			//Priv_TableGridView
			//
            this.Priv_TableGridView.GridControl = this.Priv_TableGridControl;
            this.Priv_TableGridView.Name = "Priv_TableGridView";
            this.Priv_TableGridView.OptionsBehavior.Editable = false;
            this.Priv_TableGridView.OptionsBehavior.ReadOnly = true;
			this.Priv_TableGridView.OptionsView.ShowGroupPanel = false;
			//
			//Priv_TablePopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters Priv_TablePopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Screen_Priv_TablePriv_TableChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Screen_Priv_TablePriv_TableChildPopulateColumnParameters_NotVisible.FieldName = "Screen_Priv_Table";
		    Screen_Priv_TablePriv_TableChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Priv_TablePopulateColumnsParameters.CustomColumnParameters.Add(Screen_Priv_TablePriv_TableChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_TablePriv_TableChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_TablePriv_TableChildPopulateColumnParameters_NotVisible.FieldName = "User_Table";
		    User_TablePriv_TableChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Priv_TablePopulateColumnsParameters.CustomColumnParameters.Add(User_TablePriv_TableChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Priv_TablePriv_TableChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Priv_TablePriv_TableChildPopulateColumnParameters.FieldName = "Priv_TablePriv_Table";
            Priv_TablePriv_TableChildPopulateColumnParameters.Path = "Priv_Table.ID";
			Priv_TablePopulateColumnsParameters.CustomColumnParameters.Add(Priv_TablePriv_TableChildPopulateColumnParameters);
			 
		    this.Priv_TableGridView.PopulateColumns(typeof(Building_Managment.MyCode.Priv_Table),Priv_TablePopulateColumnsParameters);
			//
			//Priv_TableBindingSource
			//
			System.Windows.Forms.BindingSource Priv_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			Priv_TableBindingSource.DataSource = typeof(Building_Managment.MyCode.Priv_Table);
            this.Priv_TableGridControl.DataSource = Priv_TableBindingSource;
			//
			//Priv_TableXtraUserControl
			//
            this.Priv_TableXtraUserControl.Controls.Add(Priv_TableGridControl);
			this.Priv_TableXtraUserControl.Name = "Priv_TableXtraUserControl";
			this.Priv_TableXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//Priv_TableNew
			//
			this.bbiPriv_TableNew.Caption = "New";
			this.bbiPriv_TableNew.Name = "bbiPriv_TableNew";
			this.bbiPriv_TableNew.ImageUri.Uri = "New";
			this.bbiPriv_TableNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Priv_TableBarManager.Items.Add(this.bbiPriv_TableNew);
			this.Priv_TableBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPriv_TableNew));
			this.Priv_TablePopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPriv_TableNew));
						//
			//Priv_TableEdit
			//
			this.bbiPriv_TableEdit.Caption = "Edit";
			this.bbiPriv_TableEdit.Name = "bbiPriv_TableEdit";
			this.bbiPriv_TableEdit.ImageUri.Uri = "Edit";
			this.bbiPriv_TableEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Priv_TableBarManager.Items.Add(this.bbiPriv_TableEdit);
			this.Priv_TableBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPriv_TableEdit));
			this.Priv_TablePopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPriv_TableEdit));
						//
			//Priv_TableDelete
			//
			this.bbiPriv_TableDelete.Caption = "Delete";
			this.bbiPriv_TableDelete.Name = "bbiPriv_TableDelete";
			this.bbiPriv_TableDelete.ImageUri.Uri = "Delete";
			this.bbiPriv_TableDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Priv_TableBarManager.Items.Add(this.bbiPriv_TableDelete);
			this.Priv_TableBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPriv_TableDelete));
			this.Priv_TablePopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPriv_TableDelete));
						//
			//Priv_TableRefresh
			//
			this.bbiPriv_TableRefresh.Caption = "Refresh";
			this.bbiPriv_TableRefresh.Name = "bbiPriv_TableRefresh";
			this.bbiPriv_TableRefresh.ImageUri.Uri = "Refresh";
			this.bbiPriv_TableRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Priv_TableBarManager.Items.Add(this.bbiPriv_TableRefresh);
			this.Priv_TableBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPriv_TableRefresh));
			this.Priv_TablePopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPriv_TableRefresh));
						//
			//Priv_TableBar
			//
			this.Priv_TableBar.BarName = "Priv_Table";
            this.Priv_TableBar.DockCol = 0;
            this.Priv_TableBar.DockRow = 0;
            this.Priv_TableBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Priv_TableBar.OptionsBar.AllowQuickCustomization = false;
            this.Priv_TableBar.OptionsBar.DrawDragBorder = false;
            this.Priv_TableBar.Text = "Priv_Table";
			//
			//Priv_TableBarManager
			//
			this.Priv_TableBarManager.AllowCustomization = false;
            this.Priv_TableBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.Priv_TableBar});
            this.Priv_TableBarManager.Form = Priv_TableXtraUserControl;
            this.Priv_TableBarManager.MainMenu = this.Priv_TableBar;
			// 
            // Priv_TablePopUpMenu
            // 
            this.Priv_TablePopUpMenu.Manager = this.Priv_TableBarManager;
            this.Priv_TablePopUpMenu.Name = "Priv_TablePopUpMenu";
			//
			//Priv_TableRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters Priv_TableRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            Priv_TableRetriveFieldParameters.FieldName = "Priv_Table";
            Priv_TableRetriveFieldParameters.ControlForField = Priv_TableXtraUserControl;
			Priv_TableRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(Priv_TableRetriveFieldParameters);
						 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(Building_Managment.ViewModels.Screen_Priv_TableViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "Screen_Priv_Table - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//Screen_Priv_TableView
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
            this.Name = "Screen_Priv_TableView";
						((System.ComponentModel.ISupportInitialize)(this.Priv_TableBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource screen_Priv_TableViewBindingSource;
				private DevExpress.XtraGrid.GridControl Priv_TableGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView Priv_TableGridView;
		private DevExpress.XtraBars.BarManager Priv_TableBarManager;
		private DevExpress.XtraBars.Bar Priv_TableBar;
		private DevExpress.XtraEditors.XtraUserControl Priv_TableXtraUserControl;
		private DevExpress.XtraBars.PopupMenu Priv_TablePopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiPriv_TableNew;
				private DevExpress.XtraBars.BarButtonItem bbiPriv_TableEdit;
				private DevExpress.XtraBars.BarButtonItem bbiPriv_TableDelete;
				private DevExpress.XtraBars.BarButtonItem bbiPriv_TableRefresh;
						 
	}
}
