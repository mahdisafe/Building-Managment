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
    /// Represents the single Building object view model.
    /// </summary>
    public partial class BuildingViewModel : SingleObjectViewModel<Building, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of BuildingViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static BuildingViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new BuildingViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the BuildingViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the BuildingViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected BuildingViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Buildings, x => x.BuildingLable) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Owners for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Owner> LookUpOwners {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (BuildingViewModel x) => x.LookUpOwners,
                    getRepositoryFunc: x => x.Owners);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Expenses for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Expens> LookUpExpenses {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (BuildingViewModel x) => x.LookUpExpenses,
                    getRepositoryFunc: x => x.Expenses);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Purchases for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Purchase> LookUpPurchases {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (BuildingViewModel x) => x.LookUpPurchases,
                    getRepositoryFunc: x => x.Purchases);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Shops for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Shop> LookUpShops {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (BuildingViewModel x) => x.LookUpShops,
                    getRepositoryFunc: x => x.Shops);
            }
        }


        /// <summary>
        /// The view model for the BuildingExpenses detail collection.
        /// </summary>
        public CollectionViewModelBase<Expens, Expens, int, IRentalDBUnitOfWork> BuildingExpensesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (BuildingViewModel x) => x.BuildingExpensesDetails,
                    getRepositoryFunc: x => x.Expenses,
                    foreignKeyExpression: x => x.Building_ID,
                    navigationExpression: x => x.Building);
            }
        }

        /// <summary>
        /// The view model for the BuildingPurchases detail collection.
        /// </summary>
        public CollectionViewModelBase<Purchase, Purchase, int, IRentalDBUnitOfWork> BuildingPurchasesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (BuildingViewModel x) => x.BuildingPurchasesDetails,
                    getRepositoryFunc: x => x.Purchases,
                    foreignKeyExpression: x => x.Building_ID,
                    navigationExpression: x => x.Building);
            }
        }

        /// <summary>
        /// The view model for the BuildingShops detail collection.
        /// </summary>
        public CollectionViewModelBase<Shop, Shop, int, IRentalDBUnitOfWork> BuildingShopsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (BuildingViewModel x) => x.BuildingShopsDetails,
                    getRepositoryFunc: x => x.Shops,
                    foreignKeyExpression: x => x.BuildingName,
                    navigationExpression: x => x.Building);
            }
        }
    }
}
