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
    /// Represents the single PaymentMethod object view model.
    /// </summary>
    public partial class PaymentMethodViewModel : SingleObjectViewModel<PaymentMethod, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PaymentMethodViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PaymentMethodViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PaymentMethodViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PaymentMethodViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PaymentMethodViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PaymentMethodViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.PaymentMethods, x => x.PaymentType) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Rents for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Rent> LookUpRents {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PaymentMethodViewModel x) => x.LookUpRents,
                    getRepositoryFunc: x => x.Rents);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of RentDetailes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<RentDetaile> LookUpRentDetailes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PaymentMethodViewModel x) => x.LookUpRentDetailes,
                    getRepositoryFunc: x => x.RentDetailes);
            }
        }


        /// <summary>
        /// The view model for the PaymentMethodRents detail collection.
        /// </summary>
        public CollectionViewModelBase<Rent, Rent, int, IRentalDBUnitOfWork> PaymentMethodRentsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (PaymentMethodViewModel x) => x.PaymentMethodRentsDetails,
                    getRepositoryFunc: x => x.Rents,
                    foreignKeyExpression: x => x.MethodID,
                    navigationExpression: x => x.PaymentMethod);
            }
        }

        /// <summary>
        /// The view model for the PaymentMethodRentDetailes detail collection.
        /// </summary>
        public CollectionViewModelBase<RentDetaile, RentDetaile, int, IRentalDBUnitOfWork> PaymentMethodRentDetailesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (PaymentMethodViewModel x) => x.PaymentMethodRentDetailesDetails,
                    getRepositoryFunc: x => x.RentDetailes,
                    foreignKeyExpression: x => x.MethodID,
                    navigationExpression: x => x.PaymentMethod);
            }
        }
    }
}
