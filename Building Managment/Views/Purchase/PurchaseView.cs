﻿using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Building_Managment.Views.PurchaseView{
    public partial class PurchaseView : XtraUserControl {
        public PurchaseView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Building_Managment.ViewModels.PurchaseViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                purchaseViewBindingSource, x => x.Entity, x => x.Update());
						#region PurchasesDetails Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(PurchasesDetailsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.PurchasePurchasesDetailsDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.PurchasesDetail,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(PurchasesDetailsGridView, "RowClick")
						 .EventToCommand(
						     x => x.PurchasePurchasesDetailsDetails.Edit(null), x => x.PurchasePurchasesDetailsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			PurchasesDetailsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    PurchasesDetailsPopUpMenu.ShowPopup(PurchasesDetailsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the PurchasePurchasesDetailsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(PurchasesDetailsGridControl, g => g.DataSource, x => x.PurchasePurchasesDetailsDetails.Entities);
			
														fluentAPI.BindCommand(bbiPurchasesDetailsNew, x => x.PurchasePurchasesDetailsDetails.New());
																													fluentAPI.BindCommand(bbiPurchasesDetailsEdit,x => x.PurchasePurchasesDetailsDetails.Edit(null), x=>x.PurchasePurchasesDetailsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiPurchasesDetailsDelete,x => x.PurchasePurchasesDetailsDetails.Delete(null), x=>x.PurchasePurchasesDetailsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiPurchasesDetailsRefresh, x => x.PurchasePurchasesDetailsDetails.Refresh());
																	#endregion
									// Binding for Building LookUp editor
			fluentAPI.SetBinding(BuildingLookUpEdit.Properties, p => p.DataSource, x => x.LookUpBuildings.Entities);
						// Binding for PurchasesType1 LookUp editor
			fluentAPI.SetBinding(PurchasesType1LookUpEdit.Properties, p => p.DataSource, x => x.LookUpPurchasesTypes.Entities);
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
