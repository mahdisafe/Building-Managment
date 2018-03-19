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
    /// Represents the single Customer object view model.
    /// </summary>
    public partial class CustomerViewModel : SingleObjectViewModel<Customer, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CustomerViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CustomerViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CustomerViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CustomerViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CustomerViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CustomerViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Customers, x => x.CustomerName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Rents for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Rent> LookUpRents {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CustomerViewModel x) => x.LookUpRents,
                    getRepositoryFunc: x => x.Rents);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of CustomerTypes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<CustomerType> LookUpCustomerTypes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CustomerViewModel x) => x.LookUpCustomerTypes,
                    getRepositoryFunc: x => x.CustomerTypes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of CustomersAttachments for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<CustomersAttachment> LookUpCustomersAttachments {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CustomerViewModel x) => x.LookUpCustomersAttachments,
                    getRepositoryFunc: x => x.CustomersAttachments);
            }
        }


        /// <summary>
        /// The view model for the CustomerRents detail collection.
        /// </summary>
        public CollectionViewModelBase<Rent, Rent, int, IRentalDBUnitOfWork> CustomerRentsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (CustomerViewModel x) => x.CustomerRentsDetails,
                    getRepositoryFunc: x => x.Rents,
                    foreignKeyExpression: x => x.CutomerID,
                    navigationExpression: x => x.Customer);
            }
        }

        /// <summary>
        /// The view model for the CustomerCustomersAttachments detail collection.
        /// </summary>
        public CollectionViewModelBase<CustomersAttachment, CustomersAttachment, int, IRentalDBUnitOfWork> CustomerCustomersAttachmentsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (CustomerViewModel x) => x.CustomerCustomersAttachmentsDetails,
                    getRepositoryFunc: x => x.CustomersAttachments,
                    foreignKeyExpression: x => x.CustomerID,
                    navigationExpression: x => x.Customer);
            }
        }
    }
}
