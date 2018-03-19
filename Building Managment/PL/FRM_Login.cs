using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Building_Managment.PL
{
    public partial class FRM_Login : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();

        public FRM_Login()
        {
            InitializeComponent();
        }
        private bool CheackConnection()
        {
            SqlConnection con = new SqlConnection(DAL.DataAccessLayer.Constr);
            try
            {

                con.Open();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        private void BtnLoginUsers_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Please enter your username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return;
            }
            if (txtPWD.Text == "")
            {
                MessageBox.Show("Please Enter Yor Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return;
            }
            DAL.DataAccessLayer.Constr = "Data Source= " + Sever.Text.Trim() + ";Initial Catalog=PropertyDB;User ID=Property;Password=0922792724";


            if (CheackConnection() == false)
            {

                XtraMessageBox.Show("Be sure To Connect to DataBase ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }


            global::Building_Managment.Properties.Settings.Default.ServerName = Sever.Text.Trim();
            global::Building_Managment.Properties.Settings.Default.UserName = txtID.Text.Trim();
            global::Building_Managment.Properties.Settings.Default.Save();

            DataTable Dt = log.LOGIN(txtID.Text, txtPWD.Text);

            if (Dt.Rows.Count > 0)
            {
                splashScreenManager1.ShowWaitForm();
                Program.userId = Dt.Rows[0]["User_ID"].ToString();
                Program.UserName = Dt.Rows[0]["UserName"].ToString();
                FRM_Main main = new FRM_Main();
                this.Hide();
                splashScreenManager1.CloseWaitForm();
                main.ShowDialog();

            }
            else
            {
                XtraMessageBox.Show("Make sure the data is correct Username Password and try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}