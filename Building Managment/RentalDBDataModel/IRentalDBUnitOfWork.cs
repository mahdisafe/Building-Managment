using Building_Managment.MyCode;
using DevExpress.Mvvm.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Building_Managment.RentalDBDataModel {

    /// <summary>
    /// IRentalDBUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IRentalDBUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The Building entities repository.
        /// </summary>
		IRepository<Building, int> Buildings { get; }
        
        /// <summary>
        /// The Expens entities repository.
        /// </summary>
		IRepository<Expens, int> Expenses { get; }
        
        /// <summary>
        /// The ExpensessDetaile entities repository.
        /// </summary>
		IRepository<ExpensessDetaile, int> ExpensessDetailes { get; }
        
        /// <summary>
        /// The ExpenseType entities repository.
        /// </summary>
		IRepository<ExpenseType, int> ExpenseTypes { get; }
        
        /// <summary>
        /// The User_Table entities repository.
        /// </summary>
		IRepository<User_Table, int> User_Table { get; }
        
        /// <summary>
        /// The Priv_Table entities repository.
        /// </summary>
		IRepository<Priv_Table, int> Priv_Table { get; }
        
        /// <summary>
        /// The Screen_Priv_Table entities repository.
        /// </summary>
		IRepository<Screen_Priv_Table, int> Screen_Priv_Table { get; }
        
        /// <summary>
        /// The Purchase entities repository.
        /// </summary>
		IRepository<Purchase, int> Purchases { get; }
        
        /// <summary>
        /// The PurchasesDetail entities repository.
        /// </summary>
		IRepository<PurchasesDetail, int> PurchasesDetails { get; }
        
        /// <summary>
        /// The PurchasesType entities repository.
        /// </summary>
		IRepository<PurchasesType, int> PurchasesTypes { get; }
        
        /// <summary>
        /// The Rent entities repository.
        /// </summary>
		IRepository<Rent, int> Rents { get; }
        
        /// <summary>
        /// The Customer entities repository.
        /// </summary>
		IRepository<Customer, int> Customers { get; }
        
        /// <summary>
        /// The CustomersAttachment entities repository.
        /// </summary>
		IRepository<CustomersAttachment, int> CustomersAttachments { get; }
        
        /// <summary>
        /// The CustomerType entities repository.
        /// </summary>
		IRepository<CustomerType, int> CustomerTypes { get; }
        
        /// <summary>
        /// The PaymentMethod entities repository.
        /// </summary>
		IRepository<PaymentMethod, int> PaymentMethods { get; }
        
        /// <summary>
        /// The RentDetaile entities repository.
        /// </summary>
		IRepository<RentDetaile, int> RentDetailes { get; }
        
        /// <summary>
        /// The PaymentType entities repository.
        /// </summary>
		IRepository<PaymentType, int> PaymentTypes { get; }
        
        /// <summary>
        /// The Shop entities repository.
        /// </summary>
		IRepository<Shop, int> Shops { get; }
        
        /// <summary>
        /// The Electricity_ShopsBills entities repository.
        /// </summary>
		IRepository<Electricity_ShopsBills, int> Electricity_ShopsBills { get; }
        
        /// <summary>
        /// The UsersGroup entities repository.
        /// </summary>
		IRepository<UsersGroup, int> UsersGroups { get; }
        
        /// <summary>
        /// The Owner entities repository.
        /// </summary>
		IRepository<Owner, int> Owners { get; }
    }
}
