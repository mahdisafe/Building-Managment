﻿using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Building_Managment.Views.Screen_Priv_TableView{
    public partial class Screen_Priv_TableView : XtraUserControl {
        public Screen_Priv_TableView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Building_Managment.ViewModels.Screen_Priv_TableViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                screen_Priv_TableViewBindingSource, x => x.Entity, x => x.Update());
						#region Priv_Table Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Priv_TableGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.Screen_Priv_TablePriv_TableDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.Priv_Table,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Priv_TableGridView, "RowClick")
						 .EventToCommand(
						     x => x.Screen_Priv_TablePriv_TableDetails.Edit(null), x => x.Screen_Priv_TablePriv_TableDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Priv_TableGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Priv_TablePopUpMenu.ShowPopup(Priv_TableGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the Screen_Priv_TablePriv_TableDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Priv_TableGridControl, g => g.DataSource, x => x.Screen_Priv_TablePriv_TableDetails.Entities);
			
														fluentAPI.BindCommand(bbiPriv_TableNew, x => x.Screen_Priv_TablePriv_TableDetails.New());
																													fluentAPI.BindCommand(bbiPriv_TableEdit,x => x.Screen_Priv_TablePriv_TableDetails.Edit(null), x=>x.Screen_Priv_TablePriv_TableDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiPriv_TableDelete,x => x.Screen_Priv_TablePriv_TableDetails.Delete(null), x=>x.Screen_Priv_TablePriv_TableDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiPriv_TableRefresh, x => x.Screen_Priv_TablePriv_TableDetails.Refresh());
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
