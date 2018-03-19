using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Building_Managment.Views.RentView{
    public partial class RentView : XtraUserControl {
        public RentView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Building_Managment.ViewModels.RentViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                rentViewBindingSource, x => x.Entity, x => x.Update());
						#region RentDetailes Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(RentDetailesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.RentRentDetailesDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.RentDetaile,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(RentDetailesGridView, "RowClick")
						 .EventToCommand(
						     x => x.RentRentDetailesDetails.Edit(null), x => x.RentRentDetailesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			RentDetailesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    RentDetailesPopUpMenu.ShowPopup(RentDetailesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the RentRentDetailesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(RentDetailesGridControl, g => g.DataSource, x => x.RentRentDetailesDetails.Entities);
			
														fluentAPI.BindCommand(bbiRentDetailesNew, x => x.RentRentDetailesDetails.New());
																													fluentAPI.BindCommand(bbiRentDetailesEdit,x => x.RentRentDetailesDetails.Edit(null), x=>x.RentRentDetailesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiRentDetailesDelete,x => x.RentRentDetailesDetails.Delete(null), x=>x.RentRentDetailesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiRentDetailesRefresh, x => x.RentRentDetailesDetails.Refresh());
																	#endregion
									// Binding for Customer LookUp editor
			fluentAPI.SetBinding(CustomerLookUpEdit.Properties, p => p.DataSource, x => x.LookUpCustomers.Entities);
						// Binding for PaymentMethod LookUp editor
			fluentAPI.SetBinding(PaymentMethodLookUpEdit.Properties, p => p.DataSource, x => x.LookUpPaymentMethods.Entities);
						// Binding for PaymentType LookUp editor
			fluentAPI.SetBinding(PaymentTypeLookUpEdit.Properties, p => p.DataSource, x => x.LookUpPaymentTypes.Entities);
						// Binding for Shop LookUp editor
			fluentAPI.SetBinding(ShopLookUpEdit.Properties, p => p.DataSource, x => x.LookUpShops.Entities);
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
