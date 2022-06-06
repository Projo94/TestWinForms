using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TestWinForms.Data;
using TestWinForms.Models;

namespace TestWinForms.Forms
{
    public partial class frmData : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable("Projects");
        public bool showForm = true;
        public frmData()
        {
            InitializeComponent();
            FillDatagrid();
        }

        private void FillDatagrid()
        {
            var allProjects = new List<Project>();

            try
            {
                allProjects = (List<Project>)DataAccess.ReturnAllProjects();

            }
            catch (Exception ex)
            {
                var errorMessage = $" An error happend while getting the projects from database.\n Error details: {ex.Message}";
                MessageBox.Show(errorMessage,
                                "Error message",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                showForm = false;
                return;
            }


            try
            {
                DataColumn uid = dt.Columns.Add("UID", typeof(Int32));
                uid.AllowDBNull = false;
                uid.Unique = true;

                dt.Columns.Add("Project name", typeof(String));
                dt.Columns.Add("Is accepting new visits", typeof(Boolean));
                dt.Columns.Add("Supported image type", typeof(String));

                foreach (var item in allProjects)
                {
                    DataRow pr = dt.NewRow();
                    pr["UID"] = item.ProjectUID;
                    pr["Project name"] = item.ProjectName;
                    pr["Is accepting new visits"] = item.IsAcceptingNewVisits;
                    pr["Supported image type"] = item.SupportedImageType;
                    dt.Rows.Add(pr);
                }

                dgvProjects.DataSource = dt;

                ((GridView)dgvProjects.MainView).Columns["UID"].Visible = false;
            }
            catch (Exception ex)
            {
                var errorMessage = $" An error happend while filling data grid with the projects.\n Error details: {ex.Message}";
                MessageBox.Show(errorMessage,
                                "Error message",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

        }

        private void dgvProjects_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = ((GridView)dgvProjects.MainView).GetSelectedRows();

                if (selectedRows.Length == 1)
                {
                    var row = ((GridView)dgvProjects.MainView).GetDataRow(selectedRows[0]);

                    var uid = row["UID"].ToString();
                    var projectName = row["Project name"].ToString().Trim();
                    var isAcceptingNewVisits = Convert.ToBoolean(row["Is accepting new visits"]);
                    var supportedImageType = row["Supported image type"].ToString().Trim();

                    var project = new Project(uid, projectName, isAcceptingNewVisits, supportedImageType);

                    var frmMain = new frmMain(project);
                    frmMain.TopMost = true;
                    frmMain.StartPosition = FormStartPosition.CenterScreen;
                    frmMain.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                var errorMessage = $" An error happend while clicking data grid.\n Error details: {ex.Message}";
                MessageBox.Show(errorMessage,
                                "Error message",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
        }
    }
}