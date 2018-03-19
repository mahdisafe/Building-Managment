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
    /// Represents the Electricity_ShopsBills collection view model.
    /// </summary>
    public partial class Electricity_ShopsBillsCollectionViewModel : CollectionViewModel<Electricity_ShopsBills, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Electricity_ShopsBillsCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Electricity_ShopsBillsCollectionViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Electricity_ShopsBillsCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Electricity_ShopsBillsCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Electricity_ShopsBillsCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Electricity_ShopsBillsCollectionViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Electricity_ShopsBills) {
        }
    }
}