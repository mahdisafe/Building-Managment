using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Building_Managment.Views.OwnerView{
    public partial class OwnerView : XtraUserControl {
        public OwnerView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Building_Managment.ViewModels.OwnerViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                ownerViewBindingSource, x => x.Entity, x => x.Update());
						#region Buildings Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(BuildingsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.OwnerBuildingsDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.Building,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(BuildingsGridView, "RowClick")
						 .EventToCommand(
						     x => x.OwnerBuildingsDetails.Edit(null), x => x.OwnerBuildingsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			BuildingsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    BuildingsPopUpMenu.ShowPopup(BuildingsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the OwnerBuildingsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(BuildingsGridControl, g => g.DataSource, x => x.OwnerBuildingsDetails.Entities);
			
														fluentAPI.BindCommand(bbiBuildingsNew, x => x.OwnerBuildingsDetails.New());
																													fluentAPI.BindCommand(bbiBuildingsEdit,x => x.OwnerBuildingsDetails.Edit(null), x=>x.OwnerBuildingsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiBuildingsDelete,x => x.OwnerBuildingsDetails.Delete(null), x=>x.OwnerBuildingsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiBuildingsRefresh, x => x.OwnerBuildingsDetails.Refresh());
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
