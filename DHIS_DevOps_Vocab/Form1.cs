using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DHIS_DevOps_Vocab
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string dtType = cbDBType.SelectedItem.ToString();

            if (dtType.Equals("SQL Server"))
            {
                string tbConnBldr =
                    "Data Source = " + tbServer.Text.Trim() +
                    "; Initial Catalog = " + tbCatalog.Text.Trim() +
                    "; Persist Security Info=True" +
                    ";User Id=" + tbUserName.Text.Trim() +
                    ";Password=" + tbPwd.Text.Trim() + ";";
                tbConnStr.Text = tbConnBldr;

                //if (string.IsNullOrEmpty(tbConnStr.Text))
                //{
                //    validateTextBox(tbServer);
                //    validateTextBox(tbCatalog);
                //    validateTextBox(tbUserName);
                //    validateTextBox(tbPwd);
                //    return;
                //}
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sCon = tbConnStr.Text.ToString();  // Allows user to alter Conn String on the fly.
            SqlConnection cnSS = new SqlConnection(sCon);
            SqlDataAdapter ssDa = new SqlDataAdapter();
            SqlCommand sqlCmd = new SqlCommand();
            DataTable ssDt = new DataTable();
            try
            {
                cnSS.Open();
                ssDa.SelectCommand = sqlCmd;
                sqlCmd.Connection = cnSS;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = tbSQLCode.Text;
                ssDa.Fill(ssDt);

                dataGridView1.DataSource = ssDt;
                cnSS.Close();

                tabControl1.SelectedIndex = 1;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                ssDa.Dispose();
                ssDt = null;
                cnSS = null;
            }
        }


        private void form1_Load(object sender, EventArgs e)
        {
            tbServer.Text = "";
            tbCatalog.Text = "";
            tbUserName.Text = "";
            tbPwd.Text = "";
            tbSQLCode.Text = "SELECT Value_Set_Name, \"Standard Code\", \"Concept Name\" " + Environment.NewLine +
                             "FROM Concepts " + Environment.NewLine +
                             "WHERE Value_Set_Name = 'PHVS_Microorganism_CDC'";
            cbDBType.SelectedIndex = 0;
        }

        //private void validateTextBox(TextBox tb)
        //{
        //    if (string.IsNullOrEmpty(tb.Text))
        //    {
        //        MessageBox.Show(tb.Name + " must be filled");
        //    }
        //}

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbConnStr.Text = "";
        }

    }

}
