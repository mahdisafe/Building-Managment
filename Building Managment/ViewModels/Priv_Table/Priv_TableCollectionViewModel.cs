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
    /// Represents the Priv_Table collection view model.
    /// </summary>
    public partial class Priv_TableCollectionViewModel : CollectionViewModel<Priv_Table, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Priv_TableCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Priv_TableCollectionViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Priv_TableCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Priv_TableCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Priv_TableCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Priv_TableCollectionViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Priv_Table) {
        }
    }
}