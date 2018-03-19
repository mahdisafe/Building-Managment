using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Building_Managment.Views.User_TableView{
    public partial class User_TableView : XtraUserControl {
        public User_TableView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Building_Managment.ViewModels.User_TableViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                user_TableViewBindingSource, x => x.Entity, x => x.Update());
						#region Expenses Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ExpensesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.User_TableExpensesDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.Expens,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ExpensesGridView, "RowClick")
						 .EventToCommand(
						     x => x.User_TableExpensesDetails.Edit(null), x => x.User_TableExpensesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ExpensesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ExpensesPopUpMenu.ShowPopup(ExpensesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the User_TableExpensesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ExpensesGridControl, g => g.DataSource, x => x.User_TableExpensesDetails.Entities);
			
														fluentAPI.BindCommand(bbiExpensesNew, x => x.User_TableExpensesDetails.New());
																													fluentAPI.BindCommand(bbiExpensesEdit,x => x.User_TableExpensesDetails.Edit(null), x=>x.User_TableExpensesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiExpensesDelete,x => x.User_TableExpensesDetails.Delete(null), x=>x.User_TableExpensesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiExpensesRefresh, x => x.User_TableExpensesDetails.Refresh());
																	#endregion
						#region Priv_Table Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Priv_TableGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.User_TablePriv_TableDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.Priv_Table,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Priv_TableGridView, "RowClick")
						 .EventToCommand(
						     x => x.User_TablePriv_TableDetails.Edit(null), x => x.User_TablePriv_TableDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Priv_TableGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Priv_TablePopUpMenu.ShowPopup(Priv_TableGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the User_TablePriv_TableDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Priv_TableGridControl, g => g.DataSource, x => x.User_TablePriv_TableDetails.Entities);
			
														fluentAPI.BindCommand(bbiPriv_TableNew, x => x.User_TablePriv_TableDetails.New());
																													fluentAPI.BindCommand(bbiPriv_TableEdit,x => x.User_TablePriv_TableDetails.Edit(null), x=>x.User_TablePriv_TableDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiPriv_TableDelete,x => x.User_TablePriv_TableDetails.Delete(null), x=>x.User_TablePriv_TableDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiPriv_TableRefresh, x => x.User_TablePriv_TableDetails.Refresh());
																	#endregion
						#region Purchases Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(PurchasesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.User_TablePurchasesDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.Purchase,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(PurchasesGridView, "RowClick")
						 .EventToCommand(
						     x => x.User_TablePurchasesDetails.Edit(null), x => x.User_TablePurchasesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			PurchasesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    PurchasesPopUpMenu.ShowPopup(PurchasesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the User_TablePurchasesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(PurchasesGridControl, g => g.DataSource, x => x.User_TablePurchasesDetails.Entities);
			
														fluentAPI.BindCommand(bbiPurchasesNew, x => x.User_TablePurchasesDetails.New());
																													fluentAPI.BindCommand(bbiPurchasesEdit,x => x.User_TablePurchasesDetails.Edit(null), x=>x.User_TablePurchasesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiPurchasesDelete,x => x.User_TablePurchasesDetails.Delete(null), x=>x.User_TablePurchasesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiPurchasesRefresh, x => x.User_TablePurchasesDetails.Refresh());
																	#endregion
						#region Rents Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(RentsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.User_TableRentsDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.Rent,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(RentsGridView, "RowClick")
						 .EventToCommand(
						     x => x.User_TableRentsDetails.Edit(null), x => x.User_TableRentsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			RentsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    RentsPopUpMenu.ShowPopup(RentsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the User_TableRentsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(RentsGridControl, g => g.DataSource, x => x.User_TableRentsDetails.Entities);
			
														fluentAPI.BindCommand(bbiRentsNew, x => x.User_TableRentsDetails.New());
																													fluentAPI.BindCommand(bbiRentsEdit,x => x.User_TableRentsDetails.Edit(null), x=>x.User_TableRentsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiRentsDelete,x => x.User_TableRentsDetails.Delete(null), x=>x.User_TableRentsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiRentsRefresh, x => x.User_TableRentsDetails.Refresh());
																	#endregion
									// Binding for UsersGroup LookUp editor
			fluentAPI.SetBinding(UsersGroupLookUpEdit.Properties, p => p.DataSource, x => x.LookUpUsersGroups.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
