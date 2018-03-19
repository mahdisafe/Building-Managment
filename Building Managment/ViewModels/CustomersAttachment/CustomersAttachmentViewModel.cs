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
    /// Represents the single CustomersAttachment object view model.
    /// </summary>
    public partial class CustomersAttachmentViewModel : SingleObjectViewModel<CustomersAttachment, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CustomersAttachmentViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CustomersAttachmentViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CustomersAttachmentViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CustomersAttachmentViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CustomersAttachmentViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CustomersAttachmentViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.CustomersAttachments, x => x.AttachmentName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer> LookUpCustomers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CustomersAttachmentViewModel x) => x.LookUpCustomers,
                    getRepositoryFunc: x => x.Customers);
            }
        }

    }
}
