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
    /// Represents the single PurchasesDetail object view model.
    /// </summary>
    public partial class PurchasesDetailViewModel : SingleObjectViewModel<PurchasesDetail, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PurchasesDetailViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PurchasesDetailViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PurchasesDetailViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PurchasesDetailViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PurchasesDetailViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PurchasesDetailViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.PurchasesDetails, x => x.PurchesName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Purchases for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Purchase> LookUpPurchases {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PurchasesDetailViewModel x) => x.LookUpPurchases,
                    getRepositoryFunc: x => x.Purchases);
            }
        }

    }
}
