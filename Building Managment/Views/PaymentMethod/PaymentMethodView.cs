using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Building_Managment.Views.PaymentMethodView{
    public partial class PaymentMethodView : XtraUserControl {
        public PaymentMethodView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Building_Managment.ViewModels.PaymentMethodViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                paymentMethodViewBindingSource, x => x.Entity, x => x.Update());
						#region Rents Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(RentsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.PaymentMethodRentsDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.Rent,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(RentsGridView, "RowClick")
						 .EventToCommand(
						     x => x.PaymentMethodRentsDetails.Edit(null), x => x.PaymentMethodRentsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			RentsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    RentsPopUpMenu.ShowPopup(RentsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the PaymentMethodRentsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(RentsGridControl, g => g.DataSource, x => x.PaymentMethodRentsDetails.Entities);
			
														fluentAPI.BindCommand(bbiRentsNew, x => x.PaymentMethodRentsDetails.New());
																													fluentAPI.BindCommand(bbiRentsEdit,x => x.PaymentMethodRentsDetails.Edit(null), x=>x.PaymentMethodRentsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiRentsDelete,x => x.PaymentMethodRentsDetails.Delete(null), x=>x.PaymentMethodRentsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiRentsRefresh, x => x.PaymentMethodRentsDetails.Refresh());
																	#endregion
						#region RentDetailes Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(RentDetailesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.PaymentMethodRentDetailesDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.RentDetaile,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(RentDetailesGridView, "RowClick")
						 .EventToCommand(
						     x => x.PaymentMethodRentDetailesDetails.Edit(null), x => x.PaymentMethodRentDetailesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			RentDetailesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    RentDetailesPopUpMenu.ShowPopup(RentDetailesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the PaymentMethodRentDetailesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(RentDetailesGridControl, g => g.DataSource, x => x.PaymentMethodRentDetailesDetails.Entities);
			
														fluentAPI.BindCommand(bbiRentDetailesNew, x => x.PaymentMethodRentDetailesDetails.New());
																													fluentAPI.BindCommand(bbiRentDetailesEdit,x => x.PaymentMethodRentDetailesDetails.Edit(null), x=>x.PaymentMethodRentDetailesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiRentDetailesDelete,x => x.PaymentMethodRentDetailesDetails.Delete(null), x=>x.PaymentMethodRentDetailesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiRentDetailesRefresh, x => x.PaymentMethodRentDetailesDetails.Refresh());
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
