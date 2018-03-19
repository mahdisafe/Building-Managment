using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.Utils.MVVM.Services;
using DevExpress.Utils.MVVM;
using DevExpress.XtraBars.Navigation;

namespace Building_Managment.Views.RentalDBView{
    public partial class RentalDBView : XtraUserControl {
        public RentalDBView() {
		     InitializeComponent();
			 if(!mvvmContext.IsDesignMode)
                InitializeNavigation();
        }
        void InitializeNavigation() {
			DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
            DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            DevExpress.XtraEditors.WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013");
            float fontSize = 10f;
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Segoe UI", fontSize);
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultMenuFont = new System.Drawing.Font("Segoe UI", fontSize);

			tileBar.SelectionColorMode = SelectionColorMode.UseItemBackColor;
            mvvmContext.RegisterService(DocumentManagerService.Create(navigationFrame));
            DevExpress.Utils.MVVM.MVVMContext.RegisterFlyoutDialogService();
            // We want to use buttons in Ribbon to show the specific modules
            var fluentAPI = mvvmContext.OfType<Building_Managment.ViewModels.RentalDBViewModel>();
						tileBar.SelectedItem = tileBarItemBuildingCollectionView;

			            fluentAPI.BindCommand(tileBarItemBuildingCollectionView, (x, m) => x.Show(m), x => x.Modules[0]);
			            fluentAPI.BindCommand(tileBarItemExpensCollectionView, (x, m) => x.Show(m), x => x.Modules[1]);
			            fluentAPI.BindCommand(tileBarItemExpensessDetaileCollectionView, (x, m) => x.Show(m), x => x.Modules[2]);
			            fluentAPI.BindCommand(tileBarItemExpenseTypeCollectionView, (x, m) => x.Show(m), x => x.Modules[3]);
			            fluentAPI.BindCommand(tileBarItemUser_TableCollectionView, (x, m) => x.Show(m), x => x.Modules[4]);
			            fluentAPI.BindCommand(tileBarItemPriv_TableCollectionView, (x, m) => x.Show(m), x => x.Modules[5]);
			            fluentAPI.BindCommand(tileBarItemScreen_Priv_TableCollectionView, (x, m) => x.Show(m), x => x.Modules[6]);
			            fluentAPI.BindCommand(tileBarItemPurchaseCollectionView, (x, m) => x.Show(m), x => x.Modules[7]);
			            fluentAPI.BindCommand(tileBarItemPurchasesDetailCollectionView, (x, m) => x.Show(m), x => x.Modules[8]);
			            fluentAPI.BindCommand(tileBarItemPurchasesTypeCollectionView, (x, m) => x.Show(m), x => x.Modules[9]);
			            fluentAPI.BindCommand(tileBarItemRentCollectionView, (x, m) => x.Show(m), x => x.Modules[10]);
			            fluentAPI.BindCommand(tileBarItemCustomerCollectionView, (x, m) => x.Show(m), x => x.Modules[11]);
			            fluentAPI.BindCommand(tileBarItemCustomersAttachmentCollectionView, (x, m) => x.Show(m), x => x.Modules[12]);
			            fluentAPI.BindCommand(tileBarItemCustomerTypeCollectionView, (x, m) => x.Show(m), x => x.Modules[13]);
			            fluentAPI.BindCommand(tileBarItemPaymentMethodCollectionView, (x, m) => x.Show(m), x => x.Modules[14]);
			            fluentAPI.BindCommand(tileBarItemRentDetaileCollectionView, (x, m) => x.Show(m), x => x.Modules[15]);
			            fluentAPI.BindCommand(tileBarItemPaymentTypeCollectionView, (x, m) => x.Show(m), x => x.Modules[16]);
			            fluentAPI.BindCommand(tileBarItemShopCollectionView, (x, m) => x.Show(m), x => x.Modules[17]);
			            fluentAPI.BindCommand(tileBarItemElectricity_ShopsBillsCollectionView, (x, m) => x.Show(m), x => x.Modules[18]);
			            fluentAPI.BindCommand(tileBarItemUsersGroupCollectionView, (x, m) => x.Show(m), x => x.Modules[19]);
			            fluentAPI.BindCommand(tileBarItemOwnerCollectionView, (x, m) => x.Show(m), x => x.Modules[20]);
						            // We want show the default module when our UserControl is loaded
            fluentAPI.WithEvent<EventArgs>(this, "Load")
                .EventToCommand(x => x.OnLoaded(null), x => x.DefaultModule);
		
        }
    }
}
