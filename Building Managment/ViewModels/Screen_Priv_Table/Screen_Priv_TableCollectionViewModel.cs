using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using Building_Managment.RentalDBDataModel;
using Building_Managment.Common;
using Building_Managment.MyCode;

namespace Building_Managment.ViewModels {

    /// <summary>
    /// Represents the Screen_Priv_Table collection view model.
    /// </summary>
    public partial class Screen_Priv_TableCollectionViewModel : CollectionViewModel<Screen_Priv_Table, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Screen_Priv_TableCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Screen_Priv_TableCollectionViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Screen_Priv_TableCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Screen_Priv_TableCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Screen_Priv_TableCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Screen_Priv_TableCollectionViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Screen_Priv_Table) {
        }
    }
}