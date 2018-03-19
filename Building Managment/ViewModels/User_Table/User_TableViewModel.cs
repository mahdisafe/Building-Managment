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
    /// Represents the single User_Table object view model.
    /// </summary>
    public partial class User_TableViewModel : SingleObjectViewModel<User_Table, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of User_TableViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static User_TableViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new User_TableViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the User_TableViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the User_TableViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected User_TableViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.User_Table, x => x.UserName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Expenses for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Expens> LookUpExpenses {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (User_TableViewModel x) => x.LookUpExpenses,
                    getRepositoryFunc: x => x.Expenses);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of UsersGroups for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<UsersGroup> LookUpUsersGroups {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (User_TableViewModel x) => x.LookUpUsersGroups,
                    getRepositoryFunc: x => x.UsersGroups);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Priv_Table for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Priv_Table> LookUpPriv_Table {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (User_TableViewModel x) => x.LookUpPriv_Table,
                    getRepositoryFunc: x => x.Priv_Table);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Purchases for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Purchase> LookUpPurchases {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (User_TableViewModel x) => x.LookUpPurchases,
                    getRepositoryFunc: x => x.Purchases);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Rents for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Rent> LookUpRents {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (User_TableViewModel x) => x.LookUpRents,
                    getRepositoryFunc: x => x.Rents);
            }
        }


        /// <summary>
        /// The view model for the User_TableExpenses detail collection.
        /// </summary>
        public CollectionViewModelBase<Expens, Expens, int, IRentalDBUnitOfWork> User_TableExpensesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (User_TableViewModel x) => x.User_TableExpensesDetails,
                    getRepositoryFunc: x => x.Expenses,
                    foreignKeyExpression: x => x.CreatedBy,
                    navigationExpression: x => x.User_Table);
            }
        }

        /// <summary>
        /// The view model for the User_TablePriv_Table detail collection.
        /// </summary>
        public CollectionViewModelBase<Priv_Table, Priv_Table, int, IRentalDBUnitOfWork> User_TablePriv_TableDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (User_TableViewModel x) => x.User_TablePriv_TableDetails,
                    getRepositoryFunc: x => x.Priv_Table,
                    foreignKeyExpression: x => x.Priv_User_ID,
                    navigationExpression: x => x.User_Table);
            }
        }

        /// <summary>
        /// The view model for the User_TablePurchases detail collection.
        /// </summary>
        public CollectionViewModelBase<Purchase, Purchase, int, IRentalDBUnitOfWork> User_TablePurchasesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (User_TableViewModel x) => x.User_TablePurchasesDetails,
                    getRepositoryFunc: x => x.Purchases,
                    foreignKeyExpression: x => x.CreatedBy,
                    navigationExpression: x => x.User_Table);
            }
        }

        /// <summary>
        /// The view model for the User_TableRents detail collection.
        /// </summary>
        public CollectionViewModelBase<Rent, Rent, int, IRentalDBUnitOfWork> User_TableRentsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (User_TableViewModel x) => x.User_TableRentsDetails,
                    getRepositoryFunc: x => x.Rents,
                    foreignKeyExpression: x => x.CreatedBy,
                    navigationExpression: x => x.User_Table);
            }
        }
    }
}
