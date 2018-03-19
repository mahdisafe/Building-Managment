using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Building_Managment.Views.CustomerTypeView{
    public partial class CustomerTypeView : XtraUserControl {
        public CustomerTypeView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Building_Managment.ViewModels.CustomerTypeViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                customerTypeViewBindingSource, x => x.Entity, x => x.Update());
						#region Customers Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(CustomersGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.CustomerTypeCustomersDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.Customer,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(CustomersGridView, "RowClick")
						 .EventToCommand(
						     x => x.CustomerTypeCustomersDetails.Edit(null), x => x.CustomerTypeCustomersDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			CustomersGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    CustomersPopUpMenu.ShowPopup(CustomersGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the CustomerTypeCustomersDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(CustomersGridControl, g => g.DataSource, x => x.CustomerTypeCustomersDetails.Entities);
			
														fluentAPI.BindCommand(bbiCustomersNew, x => x.CustomerTypeCustomersDetails.New());
																													fluentAPI.BindCommand(bbiCustomersEdit,x => x.CustomerTypeCustomersDetails.Edit(null), x=>x.CustomerTypeCustomersDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiCustomersDelete,x => x.CustomerTypeCustomersDetails.Delete(null), x=>x.CustomerTypeCustomersDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiCustomersRefresh, x => x.CustomerTypeCustomersDetails.Refresh());
																	#endregion
												fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
