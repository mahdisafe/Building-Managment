using Building_Managment.MyCode;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using System;
using System.Collections;
using System.Linq;

namespace Building_Managment.RentalDBDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IRentalDBUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IRentalDBUnitOfWork>(() => new RentalDBUnitOfWork(() => new RentalDB()));
        }
    }
}