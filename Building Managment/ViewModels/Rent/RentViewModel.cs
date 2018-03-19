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
    /// Represents the single Rent object view model.
    /// </summary>
    public partial class RentViewModel : SingleObjectViewModel<Rent, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of RentViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static RentViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new RentViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the RentViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the RentViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected RentViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Rents, x => x.RentID) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer> LookUpCustomers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RentViewModel x) => x.LookUpCustomers,
                    getRepositoryFunc: x => x.Customers);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of PaymentMethods for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<PaymentMethod> LookUpPaymentMethods {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RentViewModel x) => x.LookUpPaymentMethods,
                    getRepositoryFunc: x => x.PaymentMethods);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of PaymentTypes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<PaymentType> LookUpPaymentTypes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RentViewModel x) => x.LookUpPaymentTypes,
                    getRepositoryFunc: x => x.PaymentTypes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Shops for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Shop> LookUpShops {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RentViewModel x) => x.LookUpShops,
                    getRepositoryFunc: x => x.Shops);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of User_Table for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<User_Table> LookUpUser_Table {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RentViewModel x) => x.LookUpUser_Table,
                    getRepositoryFunc: x => x.User_Table);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of RentDetailes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<RentDetaile> LookUpRentDetailes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RentViewModel x) => x.LookUpRentDetailes,
                    getRepositoryFunc: x => x.RentDetailes);
            }
        }


        /// <summary>
        /// The view model for the RentRentDetailes detail collection.
        /// </summary>
        public CollectionViewModelBase<RentDetaile, RentDetaile, int, IRentalDBUnitOfWork> RentRentDetailesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (RentViewModel x) => x.RentRentDetailesDetails,
                    getRepositoryFunc: x => x.RentDetailes,
                    foreignKeyExpression: x => x.RentID,
                    navigationExpression: x => x.Rent);
            }
        }
    }
}
