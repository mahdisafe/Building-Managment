using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Building_Managment.Views.BuildingView{
    public partial class BuildingView : XtraUserControl {
        public BuildingView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Building_Managment.ViewModels.BuildingViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                buildingViewBindingSource, x => x.Entity, x => x.Update());
						#region Expenses Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ExpensesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.BuildingExpensesDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.Expens,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ExpensesGridView, "RowClick")
						 .EventToCommand(
						     x => x.BuildingExpensesDetails.Edit(null), x => x.BuildingExpensesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ExpensesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ExpensesPopUpMenu.ShowPopup(ExpensesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the BuildingExpensesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ExpensesGridControl, g => g.DataSource, x => x.BuildingExpensesDetails.Entities);
			
														fluentAPI.BindCommand(bbiExpensesNew, x => x.BuildingExpensesDetails.New());
																													fluentAPI.BindCommand(bbiExpensesEdit,x => x.BuildingExpensesDetails.Edit(null), x=>x.BuildingExpensesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiExpensesDelete,x => x.BuildingExpensesDetails.Delete(null), x=>x.BuildingExpensesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiExpensesRefresh, x => x.BuildingExpensesDetails.Refresh());
																	#endregion
						#region Purchases Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(PurchasesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.BuildingPurchasesDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.Purchase,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(PurchasesGridView, "RowClick")
						 .EventToCommand(
						     x => x.BuildingPurchasesDetails.Edit(null), x => x.BuildingPurchasesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			PurchasesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    PurchasesPopUpMenu.ShowPopup(PurchasesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the BuildingPurchasesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(PurchasesGridControl, g => g.DataSource, x => x.BuildingPurchasesDetails.Entities);
			
														fluentAPI.BindCommand(bbiPurchasesNew, x => x.BuildingPurchasesDetails.New());
																													fluentAPI.BindCommand(bbiPurchasesEdit,x => x.BuildingPurchasesDetails.Edit(null), x=>x.BuildingPurchasesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiPurchasesDelete,x => x.BuildingPurchasesDetails.Delete(null), x=>x.BuildingPurchasesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiPurchasesRefresh, x => x.BuildingPurchasesDetails.Refresh());
																	#endregion
						#region Shops Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ShopsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.BuildingShopsDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.Shop,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ShopsGridView, "RowClick")
						 .EventToCommand(
						     x => x.BuildingShopsDetails.Edit(null), x => x.BuildingShopsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ShopsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ShopsPopUpMenu.ShowPopup(ShopsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the BuildingShopsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ShopsGridControl, g => g.DataSource, x => x.BuildingShopsDetails.Entities);
			
														fluentAPI.BindCommand(bbiShopsNew, x => x.BuildingShopsDetails.New());
																													fluentAPI.BindCommand(bbiShopsEdit,x => x.BuildingShopsDetails.Edit(null), x=>x.BuildingShopsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiShopsDelete,x => x.BuildingShopsDetails.Delete(null), x=>x.BuildingShopsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiShopsRefresh, x => x.BuildingShopsDetails.Refresh());
																	#endregion
									// Binding for Owner LookUp editor
			fluentAPI.SetBinding(OwnerLookUpEdit.Properties, p => p.DataSource, x => x.LookUpOwners.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
