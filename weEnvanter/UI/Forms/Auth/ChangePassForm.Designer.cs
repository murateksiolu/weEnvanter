namespace weEnvanter.UI.Forms.Auth
{
    partial class ChangePassForm
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
            this.txt_CurrentPassword = new DevExpress.XtraEditors.TextEdit();
            this.txt_NewPassword = new DevExpress.XtraEditors.TextEdit();
            this.btn_Submit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_NewPasswordConfirm = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Warning = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CurrentPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NewPasswordConfirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_CurrentPassword
            // 
            this.txt_CurrentPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CurrentPassword.Location = new System.Drawing.Point(98, 26);
            this.txt_CurrentPassword.Name = "txt_CurrentPassword";
            this.txt_CurrentPassword.Size = new System.Drawing.Size(168, 22);
            this.txt_CurrentPassword.TabIndex = 0;
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_NewPassword.Location = new System.Drawing.Point(98, 52);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.Properties.PasswordChar = '*';
            this.txt_NewPassword.Size = new System.Drawing.Size(168, 22);
            this.txt_NewPassword.TabIndex = 1;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Submit.Location = new System.Drawing.Point(137, 137);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(132, 23);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Şifreyi Güncelle";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 99;
            this.labelControl1.Text = "Mevcut Şifre";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 99;
            this.labelControl2.Text = "Yeni Şifre";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txt_NewPasswordConfirm);
            this.groupControl1.Controls.Add(this.lbl_Warning);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txt_CurrentPassword);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txt_NewPassword);
            this.groupControl1.Controls.Add(this.btn_Submit);
            this.groupControl1.Location = new System.Drawing.Point(12, 115);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(274, 165);
            this.groupControl1.TabIndex = 99;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 13);
            this.labelControl3.TabIndex = 102;
            this.labelControl3.Text = "Yeni Şifre Onay";
            // 
            // txt_NewPasswordConfirm
            // 
            this.txt_NewPasswordConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_NewPasswordConfirm.Location = new System.Drawing.Point(98, 80);
            this.txt_NewPasswordConfirm.Name = "txt_NewPasswordConfirm";
            this.txt_NewPasswordConfirm.Properties.PasswordChar = '*';
            this.txt_NewPasswordConfirm.Size = new System.Drawing.Size(168, 22);
            this.txt_NewPasswordConfirm.TabIndex = 101;
            // 
            // lbl_Warning
            // 
            this.lbl_Warning.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_Warning.Appearance.Options.UseForeColor = true;
            this.lbl_Warning.Location = new System.Drawing.Point(10, 118);
            this.lbl_Warning.Name = "lbl_Warning";
            this.lbl_Warning.Size = new System.Drawing.Size(26, 13);
            this.lbl_Warning.TabIndex = 100;
            this.lbl_Warning.Text = "Warn";
            this.lbl_Warning.Visible = false;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(274, 96);
            this.pictureEdit1.TabIndex = 100;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(10, 137);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(121, 23);
            this.simpleButton1.TabIndex = 103;
            this.simpleButton1.Text = "İptal";
            // 
            // ChangePassForm
            // 
            this.AcceptButton = this.btn_Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 292);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "ChangePassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "weEnvanter - Şifre Değiştir";
            ((System.ComponentModel.ISupportInitialize)(this.txt_CurrentPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NewPasswordConfirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_CurrentPassword;
        private DevExpress.XtraEditors.TextEdit txt_NewPassword;
        private DevExpress.XtraEditors.SimpleButton btn_Submit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lbl_Warning;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_NewPasswordConfirm;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}