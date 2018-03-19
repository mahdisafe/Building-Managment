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
    /// Represents the single Priv_Table object view model.
    /// </summary>
    public partial class Priv_TableViewModel : SingleObjectViewModel<Priv_Table, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Priv_TableViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Priv_TableViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Priv_TableViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Priv_TableViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Priv_TableViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Priv_TableViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Priv_Table, x => x.ID) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Screen_Priv_Table for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Screen_Priv_Table> LookUpScreen_Priv_Table {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Priv_TableViewModel x) => x.LookUpScreen_Priv_Table,
                    getRepositoryFunc: x => x.Screen_Priv_Table);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of User_Table for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<User_Table> LookUpUser_Table {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Priv_TableViewModel x) => x.LookUpUser_Table,
                    getRepositoryFunc: x => x.User_Table);
            }
        }

    }
}
