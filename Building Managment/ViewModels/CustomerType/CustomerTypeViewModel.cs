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
    /// Represents the single CustomerType object view model.
    /// </summary>
    public partial class CustomerTypeViewModel : SingleObjectViewModel<CustomerType, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CustomerTypeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CustomerTypeViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CustomerTypeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CustomerTypeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CustomerTypeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CustomerTypeViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.CustomerTypes, x => x.CustomerType1) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer> LookUpCustomers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CustomerTypeViewModel x) => x.LookUpCustomers,
                    getRepositoryFunc: x => x.Customers);
            }
        }


        /// <summary>
        /// The view model for the CustomerTypeCustomers detail collection.
        /// </summary>
        public CollectionViewModelBase<Customer, Customer, int, IRentalDBUnitOfWork> CustomerTypeCustomersDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (CustomerTypeViewModel x) => x.CustomerTypeCustomersDetails,
                    getRepositoryFunc: x => x.Customers,
                    foreignKeyExpression: x => x.TypeID,
                    navigationExpression: x => x.CustomerType);
            }
        }
    }
}
