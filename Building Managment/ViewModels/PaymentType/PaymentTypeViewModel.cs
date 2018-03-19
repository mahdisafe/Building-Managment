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
    /// Represents the single PaymentType object view model.
    /// </summary>
    public partial class PaymentTypeViewModel : SingleObjectViewModel<PaymentType, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PaymentTypeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PaymentTypeViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PaymentTypeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PaymentTypeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PaymentTypeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PaymentTypeViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.PaymentTypes, x => x.Type) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Rents for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Rent> LookUpRents {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PaymentTypeViewModel x) => x.LookUpRents,
                    getRepositoryFunc: x => x.Rents);
            }
        }


        /// <summary>
        /// The view model for the PaymentTypeRents detail collection.
        /// </summary>
        public CollectionViewModelBase<Rent, Rent, int, IRentalDBUnitOfWork> PaymentTypeRentsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (PaymentTypeViewModel x) => x.PaymentTypeRentsDetails,
                    getRepositoryFunc: x => x.Rents,
                    foreignKeyExpression: x => x.Pay_ID,
                    navigationExpression: x => x.PaymentType);
            }
        }
    }
}
