using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using Building_Managment.RentalDBDataModel;

namespace Building_Managment.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the RentalDB data model.
    /// </summary>
    public partial class RentalDBViewModel : DocumentsViewModel<RentalDBModuleDescription, IRentalDBUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of RentalDBViewModel as a POCO view model.
        /// </summary>
        public static RentalDBViewModel Create() {
            return ViewModelSource.Create(() => new RentalDBViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the RentalDBViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the RentalDBViewModel type without the POCO proxy factory.
        /// </summary>
        protected RentalDBViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override RentalDBModuleDescription[] CreateModules() {
			return new RentalDBModuleDescription[] {
                new RentalDBModuleDescription( "Buildings", "BuildingCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Buildings)),
                new RentalDBModuleDescription( "Expenses", "ExpensCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Expenses)),
                new RentalDBModuleDescription( "Expensess Detailes", "ExpensessDetaileCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.ExpensessDetailes)),
                new RentalDBModuleDescription( "Expense Types", "ExpenseTypeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.ExpenseTypes)),
                new RentalDBModuleDescription( "User Table", "User_TableCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.User_Table)),
                new RentalDBModuleDescription( "Priv Table", "Priv_TableCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Priv_Table)),
                new RentalDBModuleDescription( "Screen Priv Table", "Screen_Priv_TableCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Screen_Priv_Table)),
                new RentalDBModuleDescription( "Purchases", "PurchaseCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Purchases)),
                new RentalDBModuleDescription( "Purchases Details", "PurchasesDetailCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.PurchasesDetails)),
                new RentalDBModuleDescription( "Purchases Types", "PurchasesTypeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.PurchasesTypes)),
                new RentalDBModuleDescription( "Rents", "RentCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Rents)),
                new RentalDBModuleDescription( "Customers", "CustomerCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Customers)),
                new RentalDBModuleDescription( "Customers Attachments", "CustomersAttachmentCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.CustomersAttachments)),
                new RentalDBModuleDescription( "Customer Types", "CustomerTypeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.CustomerTypes)),
                new RentalDBModuleDescription( "Payment Methods", "PaymentMethodCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.PaymentMethods)),
                new RentalDBModuleDescription( "Rent Detailes", "RentDetaileCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.RentDetailes)),
                new RentalDBModuleDescription( "Payment Types", "PaymentTypeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.PaymentTypes)),
                new RentalDBModuleDescription( "Shops", "ShopCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Shops)),
                new RentalDBModuleDescription( "Electricity Shops Bills", "Electricity_ShopsBillsCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Electricity_ShopsBills)),
                new RentalDBModuleDescription( "Users Groups", "UsersGroupCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.UsersGroups)),
                new RentalDBModuleDescription( "Owners", "OwnerCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Owners)),
			};
        }
                		protected override void OnActiveModuleChanged(RentalDBModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class RentalDBModuleDescription : ModuleDescription<RentalDBModuleDescription> {
        public RentalDBModuleDescription(string title, string documentType, string group, Func<RentalDBModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}