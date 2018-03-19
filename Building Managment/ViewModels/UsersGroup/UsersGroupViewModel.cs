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
    /// Represents the single UsersGroup object view model.
    /// </summary>
    public partial class UsersGroupViewModel : SingleObjectViewModel<UsersGroup, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of UsersGroupViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static UsersGroupViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new UsersGroupViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the UsersGroupViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the UsersGroupViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected UsersGroupViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.UsersGroups, x => x.GroupType) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of User_Table for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<User_Table> LookUpUser_Table {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersGroupViewModel x) => x.LookUpUser_Table,
                    getRepositoryFunc: x => x.User_Table);
            }
        }


        /// <summary>
        /// The view model for the UsersGroupUser_Table detail collection.
        /// </summary>
        public CollectionViewModelBase<User_Table, User_Table, int, IRentalDBUnitOfWork> UsersGroupUser_TableDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersGroupViewModel x) => x.UsersGroupUser_TableDetails,
                    getRepositoryFunc: x => x.User_Table,
                    foreignKeyExpression: x => x.GroupID,
                    navigationExpression: x => x.UsersGroup);
            }
        }
    }
}
