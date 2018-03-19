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
    /// Represents the single ExpensessDetaile object view model.
    /// </summary>
    public partial class ExpensessDetaileViewModel : SingleObjectViewModel<ExpensessDetaile, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ExpensessDetaileViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ExpensessDetaileViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ExpensessDetaileViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ExpensessDetaileViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ExpensessDetaileViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ExpensessDetaileViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ExpensessDetailes, x => x.ExpensessName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Expenses for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Expens> LookUpExpenses {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ExpensessDetaileViewModel x) => x.LookUpExpenses,
                    getRepositoryFunc: x => x.Expenses);
            }
        }

    }
}
