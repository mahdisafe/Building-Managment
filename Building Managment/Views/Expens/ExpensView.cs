using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Building_Managment.Views.ExpensView{
    public partial class ExpensView : XtraUserControl {
        public ExpensView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Building_Managment.ViewModels.ExpensViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                expensViewBindingSource, x => x.Entity, x => x.Update());
						#region ExpensessDetailes Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ExpensessDetailesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ExpensExpensessDetailesDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.ExpensessDetaile,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ExpensessDetailesGridView, "RowClick")
						 .EventToCommand(
						     x => x.ExpensExpensessDetailesDetails.Edit(null), x => x.ExpensExpensessDetailesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ExpensessDetailesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ExpensessDetailesPopUpMenu.ShowPopup(ExpensessDetailesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the ExpensExpensessDetailesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ExpensessDetailesGridControl, g => g.DataSource, x => x.ExpensExpensessDetailesDetails.Entities);
			
														fluentAPI.BindCommand(bbiExpensessDetailesNew, x => x.ExpensExpensessDetailesDetails.New());
																													fluentAPI.BindCommand(bbiExpensessDetailesEdit,x => x.ExpensExpensessDetailesDetails.Edit(null), x=>x.ExpensExpensessDetailesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiExpensessDetailesDelete,x => x.ExpensExpensessDetailesDetails.Delete(null), x=>x.ExpensExpensessDetailesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiExpensessDetailesRefresh, x => x.ExpensExpensessDetailesDetails.Refresh());
																	#endregion
									// Binding for Building LookUp editor
			fluentAPI.SetBinding(BuildingLookUpEdit.Properties, p => p.DataSource, x => x.LookUpBuildings.Entities);
						// Binding for ExpenseType LookUp editor
			fluentAPI.SetBinding(ExpenseTypeLookUpEdit.Properties, p => p.DataSource, x => x.LookUpExpenseTypes.Entities);
						// Binding for User_Table LookUp editor
			fluentAPI.SetBinding(User_TableLookUpEdit.Properties, p => p.DataSource, x => x.LookUpUser_Table.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
