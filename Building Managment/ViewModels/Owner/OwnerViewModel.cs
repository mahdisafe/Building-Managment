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
    /// Represents the single Owner object view model.
    /// </summary>
    public partial class OwnerViewModel : SingleObjectViewModel<Owner, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of OwnerViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static OwnerViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new OwnerViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the OwnerViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the OwnerViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected OwnerViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Owners, x => x.OwnerName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Buildings for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Building> LookUpBuildings {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (OwnerViewModel x) => x.LookUpBuildings,
                    getRepositoryFunc: x => x.Buildings);
            }
        }


        /// <summary>
        /// The view model for the OwnerBuildings detail collection.
        /// </summary>
        public CollectionViewModelBase<Building, Building, int, IRentalDBUnitOfWork> OwnerBuildingsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (OwnerViewModel x) => x.OwnerBuildingsDetails,
                    getRepositoryFunc: x => x.Buildings,
                    foreignKeyExpression: x => x.BuildingOwner,
                    navigationExpression: x => x.Owner);
            }
        }
    }
}
