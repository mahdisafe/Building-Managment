using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Building_Managment.Views.ShopView{
    public partial class ShopView : XtraUserControl {
        public ShopView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Building_Managment.ViewModels.ShopViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                shopViewBindingSource, x => x.Entity, x => x.Update());
						#region Rents Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(RentsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ShopRentsDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.Rent,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(RentsGridView, "RowClick")
						 .EventToCommand(
						     x => x.ShopRentsDetails.Edit(null), x => x.ShopRentsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			RentsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    RentsPopUpMenu.ShowPopup(RentsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the ShopRentsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(RentsGridControl, g => g.DataSource, x => x.ShopRentsDetails.Entities);
			
														fluentAPI.BindCommand(bbiRentsNew, x => x.ShopRentsDetails.New());
																													fluentAPI.BindCommand(bbiRentsEdit,x => x.ShopRentsDetails.Edit(null), x=>x.ShopRentsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiRentsDelete,x => x.ShopRentsDetails.Delete(null), x=>x.ShopRentsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiRentsRefresh, x => x.ShopRentsDetails.Refresh());
																	#endregion
						#region Electricity_ShopsBills Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Electricity_ShopsBillsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ShopElectricity_ShopsBillsDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.Electricity_ShopsBills,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Electricity_ShopsBillsGridView, "RowClick")
						 .EventToCommand(
						     x => x.ShopElectricity_ShopsBillsDetails.Edit(null), x => x.ShopElectricity_ShopsBillsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Electricity_ShopsBillsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Electricity_ShopsBillsPopUpMenu.ShowPopup(Electricity_ShopsBillsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the ShopElectricity_ShopsBillsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Electricity_ShopsBillsGridControl, g => g.DataSource, x => x.ShopElectricity_ShopsBillsDetails.Entities);
			
														fluentAPI.BindCommand(bbiElectricity_ShopsBillsNew, x => x.ShopElectricity_ShopsBillsDetails.New());
																													fluentAPI.BindCommand(bbiElectricity_ShopsBillsEdit,x => x.ShopElectricity_ShopsBillsDetails.Edit(null), x=>x.ShopElectricity_ShopsBillsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiElectricity_ShopsBillsDelete,x => x.ShopElectricity_ShopsBillsDetails.Delete(null), x=>x.ShopElectricity_ShopsBillsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiElectricity_ShopsBillsRefresh, x => x.ShopElectricity_ShopsBillsDetails.Refresh());
																	#endregion
									// Binding for Building LookUp editor
			fluentAPI.SetBinding(BuildingLookUpEdit.Properties, p => p.DataSource, x => x.LookUpBuildings.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
