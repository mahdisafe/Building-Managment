using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Building_Managment.Views.PaymentTypeView{
    public partial class PaymentTypeView : XtraUserControl {
        public PaymentTypeView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Building_Managment.ViewModels.PaymentTypeViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                paymentTypeViewBindingSource, x => x.Entity, x => x.Update());
						#region Rents Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(RentsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.PaymentTypeRentsDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.Rent,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(RentsGridView, "RowClick")
						 .EventToCommand(
						     x => x.PaymentTypeRentsDetails.Edit(null), x => x.PaymentTypeRentsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			RentsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    RentsPopUpMenu.ShowPopup(RentsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the PaymentTypeRentsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(RentsGridControl, g => g.DataSource, x => x.PaymentTypeRentsDetails.Entities);
			
														fluentAPI.BindCommand(bbiRentsNew, x => x.PaymentTypeRentsDetails.New());
																													fluentAPI.BindCommand(bbiRentsEdit,x => x.PaymentTypeRentsDetails.Edit(null), x=>x.PaymentTypeRentsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiRentsDelete,x => x.PaymentTypeRentsDetails.Delete(null), x=>x.PaymentTypeRentsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiRentsRefresh, x => x.PaymentTypeRentsDetails.Refresh());
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
