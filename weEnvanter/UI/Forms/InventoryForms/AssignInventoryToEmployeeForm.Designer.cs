namespace weEnvanter.UI.Forms.InventoryForms
{
    partial class AssignInventoryToEmployeeForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_InventoryName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_InventoryCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_BarcodeNumber = new DevExpress.XtraEditors.TextEdit();
            this.txt_SerialNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_BrandModel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lookUp_Employee = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.date_AssignDate = new DevExpress.XtraEditors.DateEdit();
            this.txt_AssignNotes = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Assign = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_InventoryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_InventoryCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BarcodeNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SerialNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BrandModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUp_Employee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_AssignDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_AssignDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AssignNotes.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_BrandModel);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txt_BarcodeNumber);
            this.groupControl1.Controls.Add(this.txt_SerialNumber);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txt_InventoryCode);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txt_InventoryName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(532, 122);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Demirbaş Bilgileri";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Demirbaş Adı";
            // 
            // txt_InventoryName
            // 
            this.txt_InventoryName.Location = new System.Drawing.Point(122, 35);
            this.txt_InventoryName.Name = "txt_InventoryName";
            this.txt_InventoryName.Properties.ReadOnly = true;
            this.txt_InventoryName.Size = new System.Drawing.Size(405, 22);
            this.txt_InventoryName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Demirbaş Kodu";
            // 
            // txt_InventoryCode
            // 
            this.txt_InventoryCode.Location = new System.Drawing.Point(122, 63);
            this.txt_InventoryCode.Name = "txt_InventoryCode";
            this.txt_InventoryCode.Properties.ReadOnly = true;
            this.txt_InventoryCode.Size = new System.Drawing.Size(131, 22);
            this.txt_InventoryCode.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 95);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Seri Numarası";
            // 
            // txt_BarcodeNumber
            // 
            this.txt_BarcodeNumber.Location = new System.Drawing.Point(396, 63);
            this.txt_BarcodeNumber.Name = "txt_BarcodeNumber";
            this.txt_BarcodeNumber.Properties.ReadOnly = true;
            this.txt_BarcodeNumber.Size = new System.Drawing.Size(131, 22);
            this.txt_BarcodeNumber.TabIndex = 6;
            // 
            // txt_SerialNumber
            // 
            this.txt_SerialNumber.Location = new System.Drawing.Point(122, 91);
            this.txt_SerialNumber.Name = "txt_SerialNumber";
            this.txt_SerialNumber.Properties.ReadOnly = true;
            this.txt_SerialNumber.Size = new System.Drawing.Size(131, 22);
            this.txt_SerialNumber.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(275, 67);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Barkod Numarası";
            // 
            // txt_BrandModel
            // 
            this.txt_BrandModel.Location = new System.Drawing.Point(396, 91);
            this.txt_BrandModel.Name = "txt_BrandModel";
            this.txt_BrandModel.Properties.ReadOnly = true;
            this.txt_BrandModel.Size = new System.Drawing.Size(131, 22);
            this.txt_BrandModel.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(275, 95);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Marka/Model";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lookUp_Employee);
            this.groupControl2.Location = new System.Drawing.Point(12, 140);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(532, 57);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Çalışan Seçimi";
            // 
            // lookUp_Employee
            // 
            this.lookUp_Employee.Location = new System.Drawing.Point(5, 25);
            this.lookUp_Employee.Name = "lookUp_Employee";
            this.lookUp_Employee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUp_Employee.Properties.NullText = "Çalışan Seçiniz..";
            this.lookUp_Employee.Size = new System.Drawing.Size(522, 22);
            this.lookUp_Employee.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.txt_AssignNotes);
            this.groupControl3.Controls.Add(this.date_AssignDate);
            this.groupControl3.Location = new System.Drawing.Point(12, 203);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(532, 140);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Zimmet Detayları";
            // 
            // date_AssignDate
            // 
            this.date_AssignDate.EditValue = null;
            this.date_AssignDate.Location = new System.Drawing.Point(122, 25);
            this.date_AssignDate.Name = "date_AssignDate";
            this.date_AssignDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_AssignDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_AssignDate.Size = new System.Drawing.Size(100, 22);
            this.date_AssignDate.TabIndex = 0;
            // 
            // txt_AssignNotes
            // 
            this.txt_AssignNotes.Location = new System.Drawing.Point(122, 58);
            this.txt_AssignNotes.Name = "txt_AssignNotes";
            this.txt_AssignNotes.Size = new System.Drawing.Size(405, 72);
            this.txt_AssignNotes.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(15, 29);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Zimmet Tarihi";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(15, 63);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(67, 13);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Zimmet Notları";
            // 
            // btn_Assign
            // 
            this.btn_Assign.Location = new System.Drawing.Point(469, 349);
            this.btn_Assign.Name = "btn_Assign";
            this.btn_Assign.Size = new System.Drawing.Size(75, 23);
            this.btn_Assign.TabIndex = 3;
            this.btn_Assign.Text = "Zimmetle";
            this.btn_Assign.Click += new System.EventHandler(this.btn_Assign_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(388, 349);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "İptal";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // AssignInventoryToEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 379);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Assign);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::weEnvanter.Properties.Resources.weEnvanter_icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssignInventoryToEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demirbaş Zimmetleme Formu";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_InventoryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_InventoryCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BarcodeNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SerialNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BrandModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUp_Employee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_AssignDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_AssignDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AssignNotes.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_InventoryName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_InventoryCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_BarcodeNumber;
        private DevExpress.XtraEditors.TextEdit txt_SerialNumber;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_BrandModel;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LookUpEdit lookUp_Employee;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit txt_AssignNotes;
        private DevExpress.XtraEditors.DateEdit date_AssignDate;
        private DevExpress.XtraEditors.SimpleButton btn_Assign;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
    }
}