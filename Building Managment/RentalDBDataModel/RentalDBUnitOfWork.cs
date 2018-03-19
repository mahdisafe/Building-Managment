using Building_Managment.MyCode;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Building_Managment.RentalDBDataModel {

    /// <summary>
    /// A RentalDBUnitOfWork instance that represents the run-time implementation of the IRentalDBUnitOfWork interface.
    /// </summary>
    public class RentalDBUnitOfWork : DbUnitOfWork<RentalDB>, IRentalDBUnitOfWork {

        public RentalDBUnitOfWork(Func<RentalDB> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Building, int> IRentalDBUnitOfWork.Buildings {
            get { return GetRepository(x => x.Set<Building>(), (Building x) => x.BuildingID); }
        }

        IRepository<Expens, int> IRentalDBUnitOfWork.Expenses {
            get { return GetRepository(x => x.Set<Expens>(), (Expens x) => x.Expenses_ID); }
        }

        IRepository<ExpensessDetaile, int> IRentalDBUnitOfWork.ExpensessDetailes {
            get { return GetRepository(x => x.Set<ExpensessDetaile>(), (ExpensessDetaile x) => x.ExpensesDetaileID); }
        }

        IRepository<ExpenseType, int> IRentalDBUnitOfWork.ExpenseTypes {
            get { return GetRepository(x => x.Set<ExpenseType>(), (ExpenseType x) => x.ID); }
        }

        IRepository<User_Table, int> IRentalDBUnitOfWork.User_Table {
            get { return GetRepository(x => x.Set<User_Table>(), (User_Table x) => x.User_ID); }
        }

        IRepository<Priv_Table, int> IRentalDBUnitOfWork.Priv_Table {
            get { return GetRepository(x => x.Set<Priv_Table>(), (Priv_Table x) => x.ID); }
        }

        IRepository<Screen_Priv_Table, int> IRentalDBUnitOfWork.Screen_Priv_Table {
            get { return GetRepository(x => x.Set<Screen_Priv_Table>(), (Screen_Priv_Table x) => x.Screen_No); }
        }

        IRepository<Purchase, int> IRentalDBUnitOfWork.Purchases {
            get { return GetRepository(x => x.Set<Purchase>(), (Purchase x) => x.PurchaseID); }
        }

        IRepository<PurchasesDetail, int> IRentalDBUnitOfWork.PurchasesDetails {
            get { return GetRepository(x => x.Set<PurchasesDetail>(), (PurchasesDetail x) => x.PurchID); }
        }

        IRepository<PurchasesType, int> IRentalDBUnitOfWork.PurchasesTypes {
            get { return GetRepository(x => x.Set<PurchasesType>(), (PurchasesType x) => x.ID); }
        }

        IRepository<Rent, int> IRentalDBUnitOfWork.Rents {
            get { return GetRepository(x => x.Set<Rent>(), (Rent x) => x.RentID); }
        }

        IRepository<Customer, int> IRentalDBUnitOfWork.Customers {
            get { return GetRepository(x => x.Set<Customer>(), (Customer x) => x.CutomerID); }
        }

        IRepository<CustomersAttachment, int> IRentalDBUnitOfWork.CustomersAttachments {
            get { return GetRepository(x => x.Set<CustomersAttachment>(), (CustomersAttachment x) => x.Attach_ID); }
        }

        IRepository<CustomerType, int> IRentalDBUnitOfWork.CustomerTypes {
            get { return GetRepository(x => x.Set<CustomerType>(), (CustomerType x) => x.CustTypeID); }
        }

        IRepository<PaymentMethod, int> IRentalDBUnitOfWork.PaymentMethods {
            get { return GetRepository(x => x.Set<PaymentMethod>(), (PaymentMethod x) => x.MethodID); }
        }

        IRepository<RentDetaile, int> IRentalDBUnitOfWork.RentDetailes {
            get { return GetRepository(x => x.Set<RentDetaile>(), (RentDetaile x) => x.RentDetaile_ID); }
        }

        IRepository<PaymentType, int> IRentalDBUnitOfWork.PaymentTypes {
            get { return GetRepository(x => x.Set<PaymentType>(), (PaymentType x) => x.Pay_ID); }
        }

        IRepository<Shop, int> IRentalDBUnitOfWork.Shops {
            get { return GetRepository(x => x.Set<Shop>(), (Shop x) => x.ShopID); }
        }

        IRepository<Electricity_ShopsBills, int> IRentalDBUnitOfWork.Electricity_ShopsBills {
            get { return GetRepository(x => x.Set<Electricity_ShopsBills>(), (Electricity_ShopsBills x) => x.Bill_ID); }
        }

        IRepository<UsersGroup, int> IRentalDBUnitOfWork.UsersGroups {
            get { return GetRepository(x => x.Set<UsersGroup>(), (UsersGroup x) => x.GroupID); }
        }

        IRepository<Owner, int> IRentalDBUnitOfWork.Owners {
            get { return GetRepository(x => x.Set<Owner>(), (Owner x) => x.OwnerID); }
        }
    }
}
