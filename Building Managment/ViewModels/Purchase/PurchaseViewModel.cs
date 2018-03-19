using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using Building_Managment.RentalDBDataModel;
using Building_Managment.Common;
using Building_Managment.MyCode;

namespace Building_Managment.ViewModels {

    /// <summary>
    /// Represents the single Purchase object view model.
    /// </summary>
    public partial class PurchaseViewModel : SingleObjectViewModel<Purchase, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PurchaseViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PurchaseViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PurchaseViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PurchaseViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PurchaseViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PurchaseViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Purchases, x => x.Notes) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Buildings for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Building> LookUpBuildings {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PurchaseViewModel x) => x.LookUpBuildings,
                    getRepositoryFunc: x => x.Buildings);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of PurchasesTypes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<PurchasesType> LookUpPurchasesTypes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PurchaseViewModel x) => x.LookUpPurchasesTypes,
                    getRepositoryFunc: x => x.PurchasesTypes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of User_Table for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<User_Table> LookUpUser_Table {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PurchaseViewModel x) => x.LookUpUser_Table,
                    getRepositoryFunc: x => x.User_Table);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of PurchasesDetails for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<PurchasesDetail> LookUpPurchasesDetails {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PurchaseViewModel x) => x.LookUpPurchasesDetails,
                    getRepositoryFunc: x => x.PurchasesDetails);
            }
        }


        /// <summary>
        /// The view model for the PurchasePurchasesDetails detail collection.
        /// </summary>
        public CollectionViewModelBase<PurchasesDetail, PurchasesDetail, int, IRentalDBUnitOfWork> PurchasePurchasesDetailsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (PurchaseViewModel x) => x.PurchasePurchasesDetailsDetails,
                    getRepositoryFunc: x => x.PurchasesDetails,
                    foreignKeyExpression: x => x.PurchaseID,
                    navigationExpression: x => x.Purchase);
            }
        }
    }
}
