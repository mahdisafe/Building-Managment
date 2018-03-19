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
    /// Represents the single Electricity_ShopsBills object view model.
    /// </summary>
    public partial class Electricity_ShopsBillsViewModel : SingleObjectViewModel<Electricity_ShopsBills, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Electricity_ShopsBillsViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Electricity_ShopsBillsViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Electricity_ShopsBillsViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Electricity_ShopsBillsViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Electricity_ShopsBillsViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Electricity_ShopsBillsViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Electricity_ShopsBills, x => x.Bill_ID) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Shops for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Shop> LookUpShops {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Electricity_ShopsBillsViewModel x) => x.LookUpShops,
                    getRepositoryFunc: x => x.Shops);
            }
        }

    }
}
