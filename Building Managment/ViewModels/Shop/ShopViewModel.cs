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
    /// Represents the single Shop object view model.
    /// </summary>
    public partial class ShopViewModel : SingleObjectViewModel<Shop, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ShopViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ShopViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ShopViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ShopViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ShopViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ShopViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Shops, x => x.ShopLable) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Rents for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Rent> LookUpRents {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ShopViewModel x) => x.LookUpRents,
                    getRepositoryFunc: x => x.Rents);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Buildings for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Building> LookUpBuildings {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ShopViewModel x) => x.LookUpBuildings,
                    getRepositoryFunc: x => x.Buildings);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Electricity_ShopsBills for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Electricity_ShopsBills> LookUpElectricity_ShopsBills {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ShopViewModel x) => x.LookUpElectricity_ShopsBills,
                    getRepositoryFunc: x => x.Electricity_ShopsBills);
            }
        }


        /// <summary>
        /// The view model for the ShopRents detail collection.
        /// </summary>
        public CollectionViewModelBase<Rent, Rent, int, IRentalDBUnitOfWork> ShopRentsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ShopViewModel x) => x.ShopRentsDetails,
                    getRepositoryFunc: x => x.Rents,
                    foreignKeyExpression: x => x.ShopID,
                    navigationExpression: x => x.Shop);
            }
        }

        /// <summary>
        /// The view model for the ShopElectricity_ShopsBills detail collection.
        /// </summary>
        public CollectionViewModelBase<Electricity_ShopsBills, Electricity_ShopsBills, int, IRentalDBUnitOfWork> ShopElectricity_ShopsBillsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ShopViewModel x) => x.ShopElectricity_ShopsBillsDetails,
                    getRepositoryFunc: x => x.Electricity_ShopsBills,
                    foreignKeyExpression: x => x.ShopLable,
                    navigationExpression: x => x.Shop);
            }
        }
    }
}
