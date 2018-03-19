﻿using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using Building_Managment.RentalDBDataModel;
using Building_Managment.Common;
using Building_Managment.MyCode;

namespace Building_Managment.ViewModels {

    /// <summary>
    /// Represents the Rents collection view model.
    /// </summary>
    public partial class RentCollectionViewModel : CollectionViewModel<Rent, int, IRentalDBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of RentCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static RentCollectionViewModel Create(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new RentCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the RentCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the RentCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected RentCollectionViewModel(IUnitOfWorkFactory<IRentalDBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Rents) {
        }
    }
}