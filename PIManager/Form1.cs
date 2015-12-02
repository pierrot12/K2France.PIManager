using SourceCode.Workflow.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using SourceCode.Workflow.Management;

namespace PIManager
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void displayActivity()
        {
            ddlActivities.Items.Clear();
            WorkflowManagementServer wms = new WorkflowManagementServer();
            wms.CreateConnection();
            wms.Connection.Open(ConfigurationManager.AppSettings["K2MgmCnxString"]);
            ddlActivities.Items.Add("Do nothing");
            ddlActivities.Items.Add("---------------------");
            foreach (Activity item in  wms.GetProcInstActivities(int.Parse(txtProcInstanceId.Text)))
            {
                ddlActivities.Items.Add(item.Name);
            }
            
            wms.Connection.Close();
        }

        private void btnLoadPI_Click(object sender, EventArgs e)
        {
            try
            {
                Connection cnx = new Connection();
                cnx.Open(ConfigurationManager.AppSettings["K2ServerName"]);
                SourceCode.Workflow.Client.ProcessInstance pi = cnx.OpenProcessInstance(int.Parse(txtProcInstanceId.Text));
                txtFolio.Text = pi.Folio;
                lblStatus.Text = pi.Status1.ToString();
                txtProcessFullName.Text = pi.FullName;
                DataTable dt = new DataTable("Datafields");
                dt.Columns.Add("Name");
                dt.Columns.Add("Value");

                foreach (DataField df in pi.DataFields)
                {
                    dt.Rows.Add(new object[] { df.Name, df.Value });
                }

                displayActivity();

                dgvDatafields.DataSource = dt;
                dgvDatafields.Refresh();
                dgvDatafields.AutoResizeColumn(0);
                dgvDatafields.Columns[0].ReadOnly = true;
                dgvDatafields.AutoResizeColumn(1);

                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PI Manager eror");
            }
        }

        private void dgvDatafields_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            try
            {
                Connection cnx = new Connection();
                cnx.Open(ConfigurationManager.AppSettings["K2ServerName"]);
                SourceCode.Workflow.Client.ProcessInstance pi = cnx.CreateProcessInstance(txtProcessFullName.Text);

                pi.Folio = txtFolio.Text;
                foreach (DataGridViewRow item in dgvDatafields.Rows)
                {
                    pi.DataFields[item.Cells[0].Value.ToString()].Value = item.Cells[1].Value.ToString();
                }

                cnx.StartProcessInstance(pi);
                int newProcId= pi.ID;

                cnx.Close();

                if (ddlActivities.SelectedIndex > 1)
                {
                    WorkflowManagementServer wms = new WorkflowManagementServer();
                    wms.CreateConnection();
                    wms.Connection.Open(ConfigurationManager.AppSettings["K2MgmCnxString"]);
                    wms.GotoActivity(newProcId, ddlActivities.SelectedItem.ToString());
                    wms.Connection.Close();
                }

                MessageBox.Show("L'instance à été dupliquée. (ID: " + newProcId.ToString() + ")", "PI Management");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PI Manager eror");
            }

        }

        private void chkChangeFolio_CheckedChanged(object sender, EventArgs e)
        {
            txtFolio.Enabled = chkChangeFolio.Checked;
        }
    }
}
