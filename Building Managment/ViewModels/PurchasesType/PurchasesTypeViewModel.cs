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
    /// Represents the single PurchasesType object view model.
    /// </summary>
    public partial class PurchasesTypeViewModel : SingleObjectViewModel<PurchasesType, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PurchasesTypeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PurchasesTypeViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PurchasesTypeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PurchasesTypeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PurchasesTypeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PurchasesTypeViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.PurchasesTypes, x => x.PurchasesDescription) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Purchases for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Purchase> LookUpPurchases {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PurchasesTypeViewModel x) => x.LookUpPurchases,
                    getRepositoryFunc: x => x.Purchases);
            }
        }


        /// <summary>
        /// The view model for the PurchasesTypePurchases detail collection.
        /// </summary>
        public CollectionViewModelBase<Purchase, Purchase, int, IRentalDBUnitOfWork> PurchasesTypePurchasesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (PurchasesTypeViewModel x) => x.PurchasesTypePurchasesDetails,
                    getRepositoryFunc: x => x.Purchases,
                    foreignKeyExpression: x => x.PurchasesType,
                    navigationExpression: x => x.PurchasesType1);
            }
        }
    }
}
