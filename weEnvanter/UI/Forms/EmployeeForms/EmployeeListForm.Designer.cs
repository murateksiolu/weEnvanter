namespace weEnvanter.UI.Forms.EmployeeForms
{
    partial class EmployeeListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeListForm));
            this.gridControl_Employees = new DevExpress.XtraGrid.GridControl();
            this.pLinqServerModeSource1 = new DevExpress.Data.PLinq.PLinqServerModeSource();
            this.gridView_Employees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btn_EditEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DeleteEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ShowEmbezzlement = new DevExpress.XtraBars.BarButtonItem();
            this.btn_CreateEmbezzlementReport = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar_AddNewEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.bar_RefreshDataSource = new DevExpress.XtraBars.BarButtonItem();
            this.bar_ExportPDF = new DevExpress.XtraBars.BarButtonItem();
            this.bar_ExportXLSX = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Employees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLinqServerModeSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Employees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_Employees
            // 
            this.gridControl_Employees.DataSource = this.pLinqServerModeSource1;
            this.gridControl_Employees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Employees.Location = new System.Drawing.Point(0, 33);
            this.gridControl_Employees.MainView = this.gridView_Employees;
            this.gridControl_Employees.Name = "gridControl_Employees";
            this.gridControl_Employees.Size = new System.Drawing.Size(835, 375);
            this.gridControl_Employees.TabIndex = 0;
            this.gridControl_Employees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Employees});
            // 
            // pLinqServerModeSource1
            // 
            this.pLinqServerModeSource1.DefaultSorting = "EmployeeNumber ASC";
            this.pLinqServerModeSource1.ElementType = typeof(weEnvanter.Domain.Entities.Employee);
            // 
            // gridView_Employees
            // 
            this.gridView_Employees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFirstName,
            this.colLastName,
            this.colEmployeeNumber,
            this.colDepartmentId,
            this.colDepartment,
            this.colId,
            this.colIsActive});
            this.gridView_Employees.GridControl = this.gridControl_Employees;
            this.gridView_Employees.Name = "gridView_Employees";
            this.gridView_Employees.OptionsView.ShowGroupPanel = false;
            this.gridView_Employees.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Employees_RowClick);
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            // 
            // colEmployeeNumber
            // 
            this.colEmployeeNumber.FieldName = "EmployeeNumber";
            this.colEmployeeNumber.Name = "colEmployeeNumber";
            this.colEmployeeNumber.Visible = true;
            this.colEmployeeNumber.VisibleIndex = 0;
            // 
            // colDepartmentId
            // 
            this.colDepartmentId.FieldName = "DepartmentId";
            this.colDepartmentId.Name = "colDepartmentId";
            // 
            // colDepartment
            // 
            this.colDepartment.FieldName = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.Visible = true;
            this.colDepartment.VisibleIndex = 3;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 4;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_EditEmployee),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_DeleteEmployee),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ShowEmbezzlement),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_CreateEmbezzlementReport)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // btn_EditEmployee
            // 
            this.btn_EditEmployee.Caption = "Düzenle";
            this.btn_EditEmployee.Id = 4;
            this.btn_EditEmployee.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_EditEmployee.ImageOptions.SvgImage")));
            this.btn_EditEmployee.Name = "btn_EditEmployee";
            this.btn_EditEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_EditEmployee_ItemClick);
            // 
            // btn_DeleteEmployee
            // 
            this.btn_DeleteEmployee.Caption = "Sil";
            this.btn_DeleteEmployee.Id = 5;
            this.btn_DeleteEmployee.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_DeleteEmployee.ImageOptions.SvgImage")));
            this.btn_DeleteEmployee.Name = "btn_DeleteEmployee";
            this.btn_DeleteEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DeleteEmployee_ItemClick);
            // 
            // btn_ShowEmbezzlement
            // 
            this.btn_ShowEmbezzlement.Caption = "Zimmetleri Görüntüle";
            this.btn_ShowEmbezzlement.Id = 6;
            this.btn_ShowEmbezzlement.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_ShowEmbezzlement.ImageOptions.SvgImage")));
            this.btn_ShowEmbezzlement.Name = "btn_ShowEmbezzlement";
            this.btn_ShowEmbezzlement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ShowEmbezzlement_ItemClick);
            // 
            // btn_CreateEmbezzlementReport
            // 
            this.btn_CreateEmbezzlementReport.Caption = "Zimmet Formu Oluştur";
            this.btn_CreateEmbezzlementReport.Id = 7;
            this.btn_CreateEmbezzlementReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_CreateEmbezzlementReport.ImageOptions.SvgImage")));
            this.btn_CreateEmbezzlementReport.Name = "btn_CreateEmbezzlementReport";
            this.btn_CreateEmbezzlementReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_CreateEmbezzlementReport_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bar_AddNewEmployee,
            this.bar_RefreshDataSource,
            this.bar_ExportPDF,
            this.bar_ExportXLSX,
            this.btn_EditEmployee,
            this.btn_DeleteEmployee,
            this.btn_ShowEmbezzlement,
            this.btn_CreateEmbezzlementReport});
            this.barManager1.MaxItemId = 8;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_AddNewEmployee),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_RefreshDataSource),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_ExportPDF),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_ExportXLSX)});
            this.bar1.Text = "Custom 2";
            // 
            // bar_AddNewEmployee
            // 
            this.bar_AddNewEmployee.Caption = "Yeni Çalışan Ekle";
            this.bar_AddNewEmployee.Id = 0;
            this.bar_AddNewEmployee.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bar_AddNewEmployee.ImageOptions.SvgImage")));
            this.bar_AddNewEmployee.Name = "bar_AddNewEmployee";
            this.bar_AddNewEmployee.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bar_AddNewEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_AddNewEmployee_ItemClick);
            // 
            // bar_RefreshDataSource
            // 
            this.bar_RefreshDataSource.Caption = "Verileri Güncelle";
            this.bar_RefreshDataSource.Id = 1;
            this.bar_RefreshDataSource.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bar_RefreshDataSource.ImageOptions.SvgImage")));
            this.bar_RefreshDataSource.Name = "bar_RefreshDataSource";
            this.bar_RefreshDataSource.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bar_RefreshDataSource.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_RefreshDataSource_ItemClick);
            // 
            // bar_ExportPDF
            // 
            this.bar_ExportPDF.Caption = "PDF\'e Aktar";
            this.bar_ExportPDF.Id = 2;
            this.bar_ExportPDF.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bar_ExportPDF.ImageOptions.SvgImage")));
            this.bar_ExportPDF.Name = "bar_ExportPDF";
            this.bar_ExportPDF.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bar_ExportPDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ExportPDF_ItemClick);
            // 
            // bar_ExportXLSX
            // 
            this.bar_ExportXLSX.Caption = "Excel\'e Aktar";
            this.bar_ExportXLSX.Id = 3;
            this.bar_ExportXLSX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bar_ExportXLSX.ImageOptions.SvgImage")));
            this.bar_ExportXLSX.Name = "bar_ExportXLSX";
            this.bar_ExportXLSX.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bar_ExportXLSX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ExportXLSX_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(835, 33);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 408);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(835, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 33);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 375);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(835, 33);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 375);
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "f6724efb-e6a9-4033-a93d-737359eccec2";
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 408);
            this.Controls.Add(this.gridControl_Employees);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::weEnvanter.Properties.Resources.weEnvanter_icon;
            this.Name = "EmployeeListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Employees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLinqServerModeSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Employees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_Employees;
        private DevExpress.Data.PLinq.PLinqServerModeSource pLinqServerModeSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Employees;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bar_AddNewEmployee;
        private DevExpress.XtraBars.BarButtonItem bar_RefreshDataSource;
        private DevExpress.XtraBars.BarButtonItem bar_ExportPDF;
        private DevExpress.XtraBars.BarButtonItem bar_ExportXLSX;
        private DevExpress.XtraBars.BarButtonItem btn_EditEmployee;
        private DevExpress.XtraBars.BarButtonItem btn_DeleteEmployee;
        private DevExpress.XtraBars.BarButtonItem btn_ShowEmbezzlement;
        private DevExpress.XtraBars.BarButtonItem btn_CreateEmbezzlementReport;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
    }
}