using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Building_Managment.Views.UsersGroupView{
    public partial class UsersGroupView : XtraUserControl {
        public UsersGroupView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Building_Managment.ViewModels.UsersGroupViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                usersGroupViewBindingSource, x => x.Entity, x => x.Update());
						#region User_Table Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(User_TableGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersGroupUser_TableDetails.SelectedEntity,
                    args => args.Row as Building_Managment.MyCode.User_Table,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(User_TableGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersGroupUser_TableDetails.Edit(null), x => x.UsersGroupUser_TableDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			User_TableGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    User_TablePopUpMenu.ShowPopup(User_TableGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersGroupUser_TableDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(User_TableGridControl, g => g.DataSource, x => x.UsersGroupUser_TableDetails.Entities);
			
														fluentAPI.BindCommand(bbiUser_TableNew, x => x.UsersGroupUser_TableDetails.New());
																													fluentAPI.BindCommand(bbiUser_TableEdit,x => x.UsersGroupUser_TableDetails.Edit(null), x=>x.UsersGroupUser_TableDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiUser_TableDelete,x => x.UsersGroupUser_TableDetails.Delete(null), x=>x.UsersGroupUser_TableDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiUser_TableRefresh, x => x.UsersGroupUser_TableDetails.Refresh());
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
