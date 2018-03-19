namespace Building_Managment.Views.CustomerTypeView {
    partial class CustomerTypeView {
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
						this.CustomersGridControl = new DevExpress.XtraGrid.GridControl();
			this.CustomersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.CustomersBarManager = new DevExpress.XtraBars.BarManager();
			this.CustomersBar = new DevExpress.XtraBars.Bar();
			this.CustomersXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.CustomersPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiCustomersNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiCustomersEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiCustomersDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiCustomersRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.CustomersBarManager)).BeginInit();
						 
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
			this.customerTypeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.customerTypeViewBindingSource.DataSource = typeof(Building_Managment.MyCode.CustomerType);
			this.dataLayoutControl1.DataSource = customerTypeViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//CustomersGridControl
			//
			this.CustomersGridControl.MainView = this.CustomersGridView;
			this.CustomersGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersGridControl.Name = "CustomersGridControl";
            this.CustomersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CustomersGridView});
			//
			//CustomersGridView
			//
            this.CustomersGridView.GridControl = this.CustomersGridControl;
            this.CustomersGridView.Name = "CustomersGridView";
            this.CustomersGridView.OptionsBehavior.Editable = false;
            this.CustomersGridView.OptionsBehavior.ReadOnly = true;
			this.CustomersGridView.OptionsView.ShowGroupPanel = false;
			//
			//CustomersPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters CustomersPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CustomerTypeCustomersChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CustomerTypeCustomersChildPopulateColumnParameters_NotVisible.FieldName = "CustomerType";
		    CustomerTypeCustomersChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			CustomersPopulateColumnsParameters.CustomColumnParameters.Add(CustomerTypeCustomersChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CustomersAttachmentsCustomersChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CustomersAttachmentsCustomersChildPopulateColumnParameters_NotVisible.FieldName = "CustomersAttachments";
		    CustomersAttachmentsCustomersChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			CustomersPopulateColumnsParameters.CustomColumnParameters.Add(CustomersAttachmentsCustomersChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters RentsCustomersChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            RentsCustomersChildPopulateColumnParameters_NotVisible.FieldName = "Rents";
		    RentsCustomersChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			CustomersPopulateColumnsParameters.CustomColumnParameters.Add(RentsCustomersChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CustomersCustomersChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CustomersCustomersChildPopulateColumnParameters.FieldName = "CustomersCustomers";
            CustomersCustomersChildPopulateColumnParameters.Path = "Customers.CustomerName";
			CustomersPopulateColumnsParameters.CustomColumnParameters.Add(CustomersCustomersChildPopulateColumnParameters);
			 
		    this.CustomersGridView.PopulateColumns(typeof(Building_Managment.MyCode.Customer),CustomersPopulateColumnsParameters);
			//
			//CustomersBindingSource
			//
			System.Windows.Forms.BindingSource CustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			CustomersBindingSource.DataSource = typeof(Building_Managment.MyCode.Customer);
            this.CustomersGridControl.DataSource = CustomersBindingSource;
			//
			//CustomersXtraUserControl
			//
            this.CustomersXtraUserControl.Controls.Add(CustomersGridControl);
			this.CustomersXtraUserControl.Name = "CustomersXtraUserControl";
			this.CustomersXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//CustomersNew
			//
			this.bbiCustomersNew.Caption = "New";
			this.bbiCustomersNew.Name = "bbiCustomersNew";
			this.bbiCustomersNew.ImageUri.Uri = "New";
			this.bbiCustomersNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.CustomersBarManager.Items.Add(this.bbiCustomersNew);
			this.CustomersBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCustomersNew));
			this.CustomersPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCustomersNew));
						//
			//CustomersEdit
			//
			this.bbiCustomersEdit.Caption = "Edit";
			this.bbiCustomersEdit.Name = "bbiCustomersEdit";
			this.bbiCustomersEdit.ImageUri.Uri = "Edit";
			this.bbiCustomersEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.CustomersBarManager.Items.Add(this.bbiCustomersEdit);
			this.CustomersBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCustomersEdit));
			this.CustomersPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCustomersEdit));
						//
			//CustomersDelete
			//
			this.bbiCustomersDelete.Caption = "Delete";
			this.bbiCustomersDelete.Name = "bbiCustomersDelete";
			this.bbiCustomersDelete.ImageUri.Uri = "Delete";
			this.bbiCustomersDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.CustomersBarManager.Items.Add(this.bbiCustomersDelete);
			this.CustomersBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCustomersDelete));
			this.CustomersPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCustomersDelete));
						//
			//CustomersRefresh
			//
			this.bbiCustomersRefresh.Caption = "Refresh";
			this.bbiCustomersRefresh.Name = "bbiCustomersRefresh";
			this.bbiCustomersRefresh.ImageUri.Uri = "Refresh";
			this.bbiCustomersRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.CustomersBarManager.Items.Add(this.bbiCustomersRefresh);
			this.CustomersBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCustomersRefresh));
			this.CustomersPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCustomersRefresh));
						//
			//CustomersBar
			//
			this.CustomersBar.BarName = "Customers";
            this.CustomersBar.DockCol = 0;
            this.CustomersBar.DockRow = 0;
            this.CustomersBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.CustomersBar.OptionsBar.AllowQuickCustomization = false;
            this.CustomersBar.OptionsBar.DrawDragBorder = false;
            this.CustomersBar.Text = "Customers";
			//
			//CustomersBarManager
			//
			this.CustomersBarManager.AllowCustomization = false;
            this.CustomersBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.CustomersBar});
            this.CustomersBarManager.Form = CustomersXtraUserControl;
            this.CustomersBarManager.MainMenu = this.CustomersBar;
			// 
            // CustomersPopUpMenu
            // 
            this.CustomersPopUpMenu.Manager = this.CustomersBarManager;
            this.CustomersPopUpMenu.Name = "CustomersPopUpMenu";
			//
			//CustomersRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters CustomersRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            CustomersRetriveFieldParameters.FieldName = "Customers";
            CustomersRetriveFieldParameters.ControlForField = CustomersXtraUserControl;
			CustomersRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(CustomersRetriveFieldParameters);
						 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(Building_Managment.ViewModels.CustomerTypeViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "CustomerType - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//CustomerTypeView
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
            this.Name = "CustomerTypeView";
						((System.ComponentModel.ISupportInitialize)(this.CustomersBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource customerTypeViewBindingSource;
				private DevExpress.XtraGrid.GridControl CustomersGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView CustomersGridView;
		private DevExpress.XtraBars.BarManager CustomersBarManager;
		private DevExpress.XtraBars.Bar CustomersBar;
		private DevExpress.XtraEditors.XtraUserControl CustomersXtraUserControl;
		private DevExpress.XtraBars.PopupMenu CustomersPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiCustomersNew;
				private DevExpress.XtraBars.BarButtonItem bbiCustomersEdit;
				private DevExpress.XtraBars.BarButtonItem bbiCustomersDelete;
				private DevExpress.XtraBars.BarButtonItem bbiCustomersRefresh;
						 
	}
}
