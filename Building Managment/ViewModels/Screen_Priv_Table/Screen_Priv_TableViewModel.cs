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
    /// Represents the single Screen_Priv_Table object view model.
    /// </summary>
    public partial class Screen_Priv_TableViewModel : SingleObjectViewModel<Screen_Priv_Table, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Screen_Priv_TableViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Screen_Priv_TableViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Screen_Priv_TableViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Screen_Priv_TableViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Screen_Priv_TableViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Screen_Priv_TableViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Screen_Priv_Table, x => x.Screen_Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Priv_Table for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Priv_Table> LookUpPriv_Table {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Screen_Priv_TableViewModel x) => x.LookUpPriv_Table,
                    getRepositoryFunc: x => x.Priv_Table);
            }
        }


        /// <summary>
        /// The view model for the Screen_Priv_TablePriv_Table detail collection.
        /// </summary>
        public CollectionViewModelBase<Priv_Table, Priv_Table, int, IRentalDBUnitOfWork> Screen_Priv_TablePriv_TableDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Screen_Priv_TableViewModel x) => x.Screen_Priv_TablePriv_TableDetails,
                    getRepositoryFunc: x => x.Priv_Table,
                    foreignKeyExpression: x => x.Priv_Screen_No,
                    navigationExpression: x => x.Screen_Priv_Table);
            }
        }
    }
}
