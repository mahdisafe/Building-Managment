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
    /// Represents the single RentDetaile object view model.
    /// </summary>
    public partial class RentDetaileViewModel : SingleObjectViewModel<RentDetaile, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of RentDetaileViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static RentDetaileViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new RentDetaileViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the RentDetaileViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the RentDetaileViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected RentDetaileViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.RentDetailes, x => x.RentDetaile_ID) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of PaymentMethods for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<PaymentMethod> LookUpPaymentMethods {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RentDetaileViewModel x) => x.LookUpPaymentMethods,
                    getRepositoryFunc: x => x.PaymentMethods);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Rents for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Rent> LookUpRents {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RentDetaileViewModel x) => x.LookUpRents,
                    getRepositoryFunc: x => x.Rents);
            }
        }

    }
}
