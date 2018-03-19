using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Building_Managment.Views.CustomerView{
    public partial class CustomerView : XtraUserControl {
        public CustomerView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Building_Managment.ViewModels.CustomerViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                customerViewBindingSource, x => x.Entity, x => x.Update());
						#region Rents Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(RentsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.CustomerRentsDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.Rent,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(RentsGridView, "RowClick")
						 .EventToCommand(
						     x => x.CustomerRentsDetails.Edit(null), x => x.CustomerRentsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			RentsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    RentsPopUpMenu.ShowPopup(RentsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the CustomerRentsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(RentsGridControl, g => g.DataSource, x => x.CustomerRentsDetails.Entities);
			
														fluentAPI.BindCommand(bbiRentsNew, x => x.CustomerRentsDetails.New());
																													fluentAPI.BindCommand(bbiRentsEdit,x => x.CustomerRentsDetails.Edit(null), x=>x.CustomerRentsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiRentsDelete,x => x.CustomerRentsDetails.Delete(null), x=>x.CustomerRentsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiRentsRefresh, x => x.CustomerRentsDetails.Refresh());
																	#endregion
						#region CustomersAttachments Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(CustomersAttachmentsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.CustomerCustomersAttachmentsDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.CustomersAttachment,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(CustomersAttachmentsGridView, "RowClick")
						 .EventToCommand(
						     x => x.CustomerCustomersAttachmentsDetails.Edit(null), x => x.CustomerCustomersAttachmentsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			CustomersAttachmentsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    CustomersAttachmentsPopUpMenu.ShowPopup(CustomersAttachmentsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the CustomerCustomersAttachmentsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(CustomersAttachmentsGridControl, g => g.DataSource, x => x.CustomerCustomersAttachmentsDetails.Entities);
			
														fluentAPI.BindCommand(bbiCustomersAttachmentsNew, x => x.CustomerCustomersAttachmentsDetails.New());
																													fluentAPI.BindCommand(bbiCustomersAttachmentsEdit,x => x.CustomerCustomersAttachmentsDetails.Edit(null), x=>x.CustomerCustomersAttachmentsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiCustomersAttachmentsDelete,x => x.CustomerCustomersAttachmentsDetails.Delete(null), x=>x.CustomerCustomersAttachmentsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiCustomersAttachmentsRefresh, x => x.CustomerCustomersAttachmentsDetails.Refresh());
																	#endregion
									// Binding for CustomerType LookUp editor
			fluentAPI.SetBinding(CustomerTypeLookUpEdit.Properties, p => p.DataSource, x => x.LookUpCustomerTypes.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
