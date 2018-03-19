namespace Building_Managment.Views.RentalDBView {
    partial class RentalDBView {
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
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarGroupViews = new DevExpress.XtraBars.Navigation.TileBarGroup();
						this.tileBarItemBuildingCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemExpensCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemExpensessDetaileCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemExpenseTypeCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemUser_TableCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemPriv_TableCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemScreen_Priv_TableCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemPurchaseCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemPurchasesDetailCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemPurchasesTypeCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemRentCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemCustomerCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemCustomersAttachmentCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemCustomerTypeCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemPaymentMethodCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemRentDetaileCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemPaymentTypeCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemShopCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemElectricity_ShopsBillsCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemUsersGroupCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemOwnerCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						            this.SuspendLayout();
			/// 
            // tileBar
            // 
            this.tileBar.AllowDrag = false;
			this.tileBar.AllowGlyphSkinning = true;
			this.tileBar.AllowSelectedItem = true;
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.Groups.Add(this.tileBarGroupViews);
			this.tileBar.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(29, 11, 29, 11);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
			this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.WideTileWidth = 150;
            this.tileBar.MinimumSize = new System.Drawing.Size(100, 110);
			this.tileBar.MaximumSize = new System.Drawing.Size(0, 110);
			this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.Text = "tileBar";
			//
			//tileBarGroupTables
			//
			this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
			// 
            // tileBarGroupViews
            // 
            this.tileBarGroupViews.Name = "tileBarGroupViews";
            this.tileBarGroupViews.Text = "VIEWS";
            			//
			//tileBarItemBuildingCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementBuildingCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementBuildingCollectionView.Text = "Buildings";
            tileItemElementBuildingCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemBuildingCollectionView.Elements.Add(tileItemElementBuildingCollectionView);
			this.tileBarItemBuildingCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.tileBarItemBuildingCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemBuildingCollectionView);
						//
			//tileBarItemExpensCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementExpensCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementExpensCollectionView.Text = "Expenses";
            tileItemElementExpensCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemExpensCollectionView.Elements.Add(tileItemElementExpensCollectionView);
			this.tileBarItemExpensCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tileBarItemExpensCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemExpensCollectionView);
						//
			//tileBarItemExpensessDetaileCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementExpensessDetaileCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementExpensessDetaileCollectionView.Text = "Expensess Detailes";
            tileItemElementExpensessDetaileCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemExpensessDetaileCollectionView.Elements.Add(tileItemElementExpensessDetaileCollectionView);
			this.tileBarItemExpensessDetaileCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.tileBarItemExpensessDetaileCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemExpensessDetaileCollectionView);
						//
			//tileBarItemExpenseTypeCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementExpenseTypeCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementExpenseTypeCollectionView.Text = "Expense Types";
            tileItemElementExpenseTypeCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemExpenseTypeCollectionView.Elements.Add(tileItemElementExpenseTypeCollectionView);
			this.tileBarItemExpenseTypeCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.tileBarItemExpenseTypeCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemExpenseTypeCollectionView);
						//
			//tileBarItemUser_TableCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementUser_TableCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementUser_TableCollectionView.Text = "User Table";
            tileItemElementUser_TableCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemUser_TableCollectionView.Elements.Add(tileItemElementUser_TableCollectionView);
			this.tileBarItemUser_TableCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(56)))));
            this.tileBarItemUser_TableCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemUser_TableCollectionView);
						//
			//tileBarItemPriv_TableCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementPriv_TableCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementPriv_TableCollectionView.Text = "Priv Table";
            tileItemElementPriv_TableCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemPriv_TableCollectionView.Elements.Add(tileItemElementPriv_TableCollectionView);
			this.tileBarItemPriv_TableCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.tileBarItemPriv_TableCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemPriv_TableCollectionView);
						//
			//tileBarItemScreen_Priv_TableCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementScreen_Priv_TableCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementScreen_Priv_TableCollectionView.Text = "Screen Priv Table";
            tileItemElementScreen_Priv_TableCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemScreen_Priv_TableCollectionView.Elements.Add(tileItemElementScreen_Priv_TableCollectionView);
			this.tileBarItemScreen_Priv_TableCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tileBarItemScreen_Priv_TableCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemScreen_Priv_TableCollectionView);
						//
			//tileBarItemPurchaseCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementPurchaseCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementPurchaseCollectionView.Text = "Purchases";
            tileItemElementPurchaseCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemPurchaseCollectionView.Elements.Add(tileItemElementPurchaseCollectionView);
			this.tileBarItemPurchaseCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.tileBarItemPurchaseCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemPurchaseCollectionView);
						//
			//tileBarItemPurchasesDetailCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementPurchasesDetailCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementPurchasesDetailCollectionView.Text = "Purchases Details";
            tileItemElementPurchasesDetailCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemPurchasesDetailCollectionView.Elements.Add(tileItemElementPurchasesDetailCollectionView);
			this.tileBarItemPurchasesDetailCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.tileBarItemPurchasesDetailCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemPurchasesDetailCollectionView);
						//
			//tileBarItemPurchasesTypeCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementPurchasesTypeCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementPurchasesTypeCollectionView.Text = "Purchases Types";
            tileItemElementPurchasesTypeCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemPurchasesTypeCollectionView.Elements.Add(tileItemElementPurchasesTypeCollectionView);
			this.tileBarItemPurchasesTypeCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(56)))));
            this.tileBarItemPurchasesTypeCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemPurchasesTypeCollectionView);
						//
			//tileBarItemRentCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementRentCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementRentCollectionView.Text = "Rents";
            tileItemElementRentCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemRentCollectionView.Elements.Add(tileItemElementRentCollectionView);
			this.tileBarItemRentCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.tileBarItemRentCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemRentCollectionView);
						//
			//tileBarItemCustomerCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementCustomerCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementCustomerCollectionView.Text = "Customers";
            tileItemElementCustomerCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemCustomerCollectionView.Elements.Add(tileItemElementCustomerCollectionView);
			this.tileBarItemCustomerCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tileBarItemCustomerCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemCustomerCollectionView);
						//
			//tileBarItemCustomersAttachmentCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementCustomersAttachmentCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementCustomersAttachmentCollectionView.Text = "Customers Attachments";
            tileItemElementCustomersAttachmentCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemCustomersAttachmentCollectionView.Elements.Add(tileItemElementCustomersAttachmentCollectionView);
			this.tileBarItemCustomersAttachmentCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.tileBarItemCustomersAttachmentCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemCustomersAttachmentCollectionView);
						//
			//tileBarItemCustomerTypeCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementCustomerTypeCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementCustomerTypeCollectionView.Text = "Customer Types";
            tileItemElementCustomerTypeCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemCustomerTypeCollectionView.Elements.Add(tileItemElementCustomerTypeCollectionView);
			this.tileBarItemCustomerTypeCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.tileBarItemCustomerTypeCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemCustomerTypeCollectionView);
						//
			//tileBarItemPaymentMethodCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementPaymentMethodCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementPaymentMethodCollectionView.Text = "Payment Methods";
            tileItemElementPaymentMethodCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemPaymentMethodCollectionView.Elements.Add(tileItemElementPaymentMethodCollectionView);
			this.tileBarItemPaymentMethodCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(56)))));
            this.tileBarItemPaymentMethodCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemPaymentMethodCollectionView);
						//
			//tileBarItemRentDetaileCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementRentDetaileCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementRentDetaileCollectionView.Text = "Rent Detailes";
            tileItemElementRentDetaileCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemRentDetaileCollectionView.Elements.Add(tileItemElementRentDetaileCollectionView);
			this.tileBarItemRentDetaileCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.tileBarItemRentDetaileCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemRentDetaileCollectionView);
						//
			//tileBarItemPaymentTypeCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementPaymentTypeCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementPaymentTypeCollectionView.Text = "Payment Types";
            tileItemElementPaymentTypeCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemPaymentTypeCollectionView.Elements.Add(tileItemElementPaymentTypeCollectionView);
			this.tileBarItemPaymentTypeCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tileBarItemPaymentTypeCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemPaymentTypeCollectionView);
						//
			//tileBarItemShopCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementShopCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementShopCollectionView.Text = "Shops";
            tileItemElementShopCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemShopCollectionView.Elements.Add(tileItemElementShopCollectionView);
			this.tileBarItemShopCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.tileBarItemShopCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemShopCollectionView);
						//
			//tileBarItemElectricity_ShopsBillsCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementElectricity_ShopsBillsCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementElectricity_ShopsBillsCollectionView.Text = "Electricity Shops Bills";
            tileItemElementElectricity_ShopsBillsCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemElectricity_ShopsBillsCollectionView.Elements.Add(tileItemElementElectricity_ShopsBillsCollectionView);
			this.tileBarItemElectricity_ShopsBillsCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.tileBarItemElectricity_ShopsBillsCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemElectricity_ShopsBillsCollectionView);
						//
			//tileBarItemUsersGroupCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementUsersGroupCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementUsersGroupCollectionView.Text = "Users Groups";
            tileItemElementUsersGroupCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemUsersGroupCollectionView.Elements.Add(tileItemElementUsersGroupCollectionView);
			this.tileBarItemUsersGroupCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(56)))));
            this.tileBarItemUsersGroupCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemUsersGroupCollectionView);
						//
			//tileBarItemOwnerCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementOwnerCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementOwnerCollectionView.Text = "Owners";
            tileItemElementOwnerCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemOwnerCollectionView.Elements.Add(tileItemElementOwnerCollectionView);
			this.tileBarItemOwnerCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.tileBarItemOwnerCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemOwnerCollectionView);
						
				
			// 
            // navigationFrame
            // 
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.SelectedPage = null;
            this.navigationFrame.SelectedPageIndex = -1;
            this.navigationFrame.Text = "navigationFrame";
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(Building_Managment.ViewModels.RentalDBViewModel);
			// 
            // RentalDBView
            // 
			this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "RentalDBView";
			this.Text = "RentalDBView";
            this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupViews;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemBuildingCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemExpensCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemExpensessDetaileCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemExpenseTypeCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemUser_TableCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemPriv_TableCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemScreen_Priv_TableCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemPurchaseCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemPurchasesDetailCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemPurchasesTypeCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemRentCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemCustomerCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemCustomersAttachmentCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemCustomerTypeCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemPaymentMethodCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemRentDetaileCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemPaymentTypeCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemShopCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemElectricity_ShopsBillsCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemUsersGroupCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemOwnerCollectionView;
					}
}
