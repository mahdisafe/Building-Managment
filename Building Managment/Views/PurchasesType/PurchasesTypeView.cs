using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Building_Managment.Views.PurchasesTypeView{
    public partial class PurchasesTypeView : XtraUserControl {
        public PurchasesTypeView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Building_Managment.ViewModels.PurchasesTypeViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                purchasesTypeViewBindingSource, x => x.Entity, x => x.Update());
						#region Purchases Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(PurchasesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.PurchasesTypePurchasesDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.Purchase,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(PurchasesGridView, "RowClick")
						 .EventToCommand(
						     x => x.PurchasesTypePurchasesDetails.Edit(null), x => x.PurchasesTypePurchasesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			PurchasesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    PurchasesPopUpMenu.ShowPopup(PurchasesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the PurchasesTypePurchasesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(PurchasesGridControl, g => g.DataSource, x => x.PurchasesTypePurchasesDetails.Entities);
			
														fluentAPI.BindCommand(bbiPurchasesNew, x => x.PurchasesTypePurchasesDetails.New());
																													fluentAPI.BindCommand(bbiPurchasesEdit,x => x.PurchasesTypePurchasesDetails.Edit(null), x=>x.PurchasesTypePurchasesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiPurchasesDelete,x => x.PurchasesTypePurchasesDetails.Delete(null), x=>x.PurchasesTypePurchasesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiPurchasesRefresh, x => x.PurchasesTypePurchasesDetails.Refresh());
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
