using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestWinForms.Data;
using TestWinForms.Forms;
using TestWinForms.Models;

namespace TestWinForms
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            PopulateImageTypesDropdown();
            SetDefaultValuesInsert();
            StyleForm();
        }

        public frmMain(Project project)
        {
            InitializeComponent();
            PopulateImageTypesDropdown();
            txtProjectName.Text = project.ProjectName;
            cmbImageTypes.EditValue = project.SupportedImageType;
            chkAcceptingNewVisits.Checked = project.IsAcceptingNewVisits;

            var controls = new List<Control>() { txtProjectName, chkAcceptingNewVisits, chkProjectEnabled, cmbImageTypes };
            DisableFields(controls);
            StyleForm();
            SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            btnSave.Visible = false;
            chkProjectEnabled.Checked = true;
            cmbImageTypes.Enabled = false;
            txtProjectName.Properties.MaxLength = 40;
        }

        private void SetDefaultValuesInsert()
        {
            chkProjectEnabled.Checked = true;
            cmbImageTypes.Enabled = false;
            txtProjectName.Properties.MaxLength = 40;
        }

        private void DisableFields(List<Control> controls)
        {
            foreach (var control in controls)
            {
                control.Enabled = false;
            }
        }

        private void PopulateImageTypesDropdown()
        {
            List<string> list = new List<string>();
            list.Add("");
            list.Add("JPG");
            list.Add("DICOM");

            cmbImageTypes.Properties.DataSource = list;
        }

        private void chkAcceptingNewVisits_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAcceptingNewVisits.Checked == true)
            {
                cmbImageTypes.Enabled = true;
                cmbImageTypes.EditValue = "JPG";
            }
            else
            {
                cmbImageTypes.Enabled = false;
                cmbImageTypes.EditValue = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveProject();
            }
            catch (Exception ex)
            {
                MessageBox.Show($" An error happend while saving the project.\n Error details: {ex.Message}", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveProject()
        {
            var project = new Project();
            project.ProjectName = txtProjectName.Text;
            project.IsAcceptingNewVisits = chkAcceptingNewVisits.Checked;
            project.SupportedImageType = cmbImageTypes.EditValue.ToString();

            DataAccess.SaveProject(project);

            MessageBox.Show("Project has been successfully saved!",
                "Successful message",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            frmData frmData = new frmData();
            if (frmData.showForm)
            {
                frmData.FormBorderStyle = FormBorderStyle.FixedSingle;
                frmData.MaximizeBox = false;
                frmData.MinimizeBox = false;
                frmData.StartPosition = FormStartPosition.CenterScreen;
                frmData.Show();
            }

            Hide();
        }


        private void chkProjectEnabled_CheckedChanged(object sender, EventArgs e)
        {
            CheckMandatoryFields();
        }

        private void txtProjectName_EditValueChanged(object sender, EventArgs e)
        {
            CheckMandatoryFields();
        }

        private void CheckMandatoryFields()
        {
            if (txtProjectName.Text.Length > 0 && chkProjectEnabled.Checked)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void StyleForm()
        {
            MinimizeBox = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            cmbImageTypes.Properties.ShowClearButton = false;
        }
    }
}
