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
    /// Represents the single ExpenseType object view model.
    /// </summary>
    public partial class ExpenseTypeViewModel : SingleObjectViewModel<ExpenseType, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ExpenseTypeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ExpenseTypeViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ExpenseTypeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ExpenseTypeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ExpenseTypeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ExpenseTypeViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ExpenseTypes, x => x.DescriptionExpenses) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Expenses for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Expens> LookUpExpenses {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ExpenseTypeViewModel x) => x.LookUpExpenses,
                    getRepositoryFunc: x => x.Expenses);
            }
        }


        /// <summary>
        /// The view model for the ExpenseTypeExpenses detail collection.
        /// </summary>
        public CollectionViewModelBase<Expens, Expens, int, IRentalDBUnitOfWork> ExpenseTypeExpensesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ExpenseTypeViewModel x) => x.ExpenseTypeExpensesDetails,
                    getRepositoryFunc: x => x.Expenses,
                    foreignKeyExpression: x => x.ExpType,
                    navigationExpression: x => x.ExpenseType);
            }
        }
    }
}
