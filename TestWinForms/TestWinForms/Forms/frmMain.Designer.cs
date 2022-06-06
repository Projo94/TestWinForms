
namespace TestWinForms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProjectName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.chkProjectEnabled = new DevExpress.XtraEditors.CheckEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAcceptingNewVisits = new DevExpress.XtraEditors.CheckEdit();
            this.cmbImageTypes = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.entityServerModeSource1 = new DevExpress.Data.Linq.EntityServerModeSource();
            this.txtProjectName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chkProjectEnabled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcceptingNewVisits.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImageTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(72, 36);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(88, 16);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "Project name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supported image types:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(478, 194);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkProjectEnabled
            // 
            this.chkProjectEnabled.Location = new System.Drawing.Point(222, 62);
            this.chkProjectEnabled.Name = "chkProjectEnabled";
            this.chkProjectEnabled.Properties.Caption = "";
            this.chkProjectEnabled.Size = new System.Drawing.Size(28, 24);
            this.chkProjectEnabled.TabIndex = 2;
            this.chkProjectEnabled.CheckedChanged += new System.EventHandler(this.chkProjectEnabled_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Project enabled:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Accepting new visits:";
            // 
            // chkAcceptingNewVisits
            // 
            this.chkAcceptingNewVisits.Location = new System.Drawing.Point(222, 92);
            this.chkAcceptingNewVisits.Name = "chkAcceptingNewVisits";
            this.chkAcceptingNewVisits.Properties.Caption = "";
            this.chkAcceptingNewVisits.Size = new System.Drawing.Size(28, 24);
            this.chkAcceptingNewVisits.TabIndex = 3;
            this.chkAcceptingNewVisits.CheckedChanged += new System.EventHandler(this.chkAcceptingNewVisits_CheckedChanged);
            // 
            // cmbImageTypes
            // 
            this.cmbImageTypes.EditValue = "";
            this.cmbImageTypes.Location = new System.Drawing.Point(222, 134);
            this.cmbImageTypes.Name = "cmbImageTypes";
            this.cmbImageTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImageTypes.Properties.PopupView = this.searchLookUpEdit1View;
            this.cmbImageTypes.Size = new System.Drawing.Size(112, 22);
            this.cmbImageTypes.TabIndex = 4;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectName.Location = new System.Drawing.Point(222, 34);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(374, 22);
            this.txtProjectName.TabIndex = 1;
            this.txtProjectName.EditValueChanged += new System.EventHandler(this.txtProjectName_EditValueChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 253);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.cmbImageTypes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkAcceptingNewVisits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkProjectEnabled);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProjectName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Main form";
            ((System.ComponentModel.ISupportInitialize)(this.chkProjectEnabled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcceptingNewVisits.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImageTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.CheckEdit chkProjectEnabled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.CheckEdit chkAcceptingNewVisits;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbImageTypes;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource1;
        private DevExpress.XtraEditors.TextEdit txtProjectName;
    }
}

