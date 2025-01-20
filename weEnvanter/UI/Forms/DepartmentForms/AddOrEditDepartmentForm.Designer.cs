namespace weEnvanter.UI.Forms.DepartmentForms
{
    partial class AddOrEditDepartmentForm
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
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lookUp_ParentDepartment = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_DepartmentName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.toggle_IsActive = new DevExpress.XtraEditors.ToggleSwitch();
            this.txt_Description = new DevExpress.XtraEditors.MemoEdit();
            this.txt_DepartmentCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUp_ParentDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DepartmentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggle_IsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DepartmentCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_Cancel);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.lookUp_ParentDepartment);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txt_DepartmentName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.btn_Save);
            this.groupControl1.Controls.Add(this.toggle_IsActive);
            this.groupControl1.Controls.Add(this.txt_Description);
            this.groupControl1.Controls.Add(this.txt_DepartmentCode);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(368, 298);
            this.groupControl1.TabIndex = 0;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(201, 265);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "İptal";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 227);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(71, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Aktiflik Durumu";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 96);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Üst Departman";
            // 
            // lookUp_ParentDepartment
            // 
            this.lookUp_ParentDepartment.Location = new System.Drawing.Point(118, 92);
            this.lookUp_ParentDepartment.Name = "lookUp_ParentDepartment";
            this.lookUp_ParentDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUp_ParentDepartment.Size = new System.Drawing.Size(239, 22);
            this.lookUp_ParentDepartment.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Açıklama";
            // 
            // txt_DepartmentName
            // 
            this.txt_DepartmentName.Location = new System.Drawing.Point(118, 63);
            this.txt_DepartmentName.Name = "txt_DepartmentName";
            this.txt_DepartmentName.Size = new System.Drawing.Size(239, 22);
            this.txt_DepartmentName.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Departman Adı";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(282, 265);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Kaydet";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // toggle_IsActive
            // 
            this.toggle_IsActive.EditValue = true;
            this.toggle_IsActive.Location = new System.Drawing.Point(118, 222);
            this.toggle_IsActive.Name = "toggle_IsActive";
            this.toggle_IsActive.Properties.OffText = "Pasif";
            this.toggle_IsActive.Properties.OnText = "Aktif";
            this.toggle_IsActive.Size = new System.Drawing.Size(95, 24);
            this.toggle_IsActive.TabIndex = 3;
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(118, 120);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(239, 96);
            this.txt_Description.TabIndex = 2;
            // 
            // txt_DepartmentCode
            // 
            this.txt_DepartmentCode.Location = new System.Drawing.Point(118, 35);
            this.txt_DepartmentCode.Name = "txt_DepartmentCode";
            this.txt_DepartmentCode.Size = new System.Drawing.Size(239, 22);
            this.txt_DepartmentCode.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Departman Kodu";
            // 
            // AddOrEditDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 298);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::weEnvanter.Properties.Resources.weEnvanter_icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrEditDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departman Formu ";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUp_ParentDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DepartmentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggle_IsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DepartmentCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_DepartmentName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.ToggleSwitch toggle_IsActive;
        private DevExpress.XtraEditors.MemoEdit txt_Description;
        private DevExpress.XtraEditors.TextEdit txt_DepartmentCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lookUp_ParentDepartment;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}