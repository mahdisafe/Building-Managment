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
    /// Represents the single Expens object view model.
    /// </summary>
    public partial class ExpensViewModel : SingleObjectViewModel<Expens, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ExpensViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ExpensViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ExpensViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ExpensViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ExpensViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ExpensViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Expenses, x => x.ExpensessDescription) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Buildings for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Building> LookUpBuildings {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ExpensViewModel x) => x.LookUpBuildings,
                    getRepositoryFunc: x => x.Buildings);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of ExpenseTypes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ExpenseType> LookUpExpenseTypes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ExpensViewModel x) => x.LookUpExpenseTypes,
                    getRepositoryFunc: x => x.ExpenseTypes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of User_Table for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<User_Table> LookUpUser_Table {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ExpensViewModel x) => x.LookUpUser_Table,
                    getRepositoryFunc: x => x.User_Table);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of ExpensessDetailes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ExpensessDetaile> LookUpExpensessDetailes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ExpensViewModel x) => x.LookUpExpensessDetailes,
                    getRepositoryFunc: x => x.ExpensessDetailes);
            }
        }


        /// <summary>
        /// The view model for the ExpensExpensessDetailes detail collection.
        /// </summary>
        public CollectionViewModelBase<ExpensessDetaile, ExpensessDetaile, int, IRentalDBUnitOfWork> ExpensExpensessDetailesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ExpensViewModel x) => x.ExpensExpensessDetailesDetails,
                    getRepositoryFunc: x => x.ExpensessDetailes,
                    foreignKeyExpression: x => x.Expensess_ID,
                    navigationExpression: x => x.Expens);
            }
        }
    }
}
