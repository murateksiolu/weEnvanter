namespace weEnvanter.UI.Forms.DepartmentForms
{
    partial class DepartmentListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentListForm));
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bar_EditDepartment = new DevExpress.XtraBars.BarButtonItem();
            this.bar_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.bar_ShowEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_AddNewDepartment = new DevExpress.XtraBars.BarButtonItem();
            this.btn_RefreshDataSource = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ExportPDF = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ExportXLSX = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl_Departments = new DevExpress.XtraGrid.GridControl();
            this.gridView_Departments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pLinqServerModeSource1 = new DevExpress.Data.PLinq.PLinqServerModeSource();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Departments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Departments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLinqServerModeSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_EditDepartment),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_Delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_ShowEmployee)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // bar_EditDepartment
            // 
            this.bar_EditDepartment.Caption = "Düzenle";
            this.bar_EditDepartment.Id = 4;
            this.bar_EditDepartment.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bar_EditDepartment.ImageOptions.SvgImage")));
            this.bar_EditDepartment.Name = "bar_EditDepartment";
            this.bar_EditDepartment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_EditDepartment_ItemClick);
            // 
            // bar_Delete
            // 
            this.bar_Delete.Caption = "Sil";
            this.bar_Delete.Id = 5;
            this.bar_Delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bar_Delete.ImageOptions.SvgImage")));
            this.bar_Delete.Name = "bar_Delete";
            this.bar_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_Delete_ItemClick);
            // 
            // bar_ShowEmployee
            // 
            this.bar_ShowEmployee.Caption = "Çalışanları Görüntüle";
            this.bar_ShowEmployee.Id = 6;
            this.bar_ShowEmployee.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bar_ShowEmployee.ImageOptions.SvgImage")));
            this.bar_ShowEmployee.Name = "bar_ShowEmployee";
            this.bar_ShowEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ShowEmployee_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.AllowMoveBarOnToolbar = false;
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_AddNewDepartment,
            this.btn_RefreshDataSource,
            this.btn_ExportPDF,
            this.btn_ExportXLSX,
            this.bar_EditDepartment,
            this.bar_Delete,
            this.bar_ShowEmployee});
            this.barManager1.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_AddNewDepartment),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_RefreshDataSource),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ExportPDF),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ExportXLSX)});
            this.bar1.Text = "Custom 2";
            // 
            // btn_AddNewDepartment
            // 
            this.btn_AddNewDepartment.Caption = "Yeni Departman Ekle";
            this.btn_AddNewDepartment.Id = 0;
            this.btn_AddNewDepartment.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_AddNewDepartment.ImageOptions.SvgImage")));
            this.btn_AddNewDepartment.Name = "btn_AddNewDepartment";
            this.btn_AddNewDepartment.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_AddNewDepartment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_AddNewDepartment_ItemClick);
            // 
            // btn_RefreshDataSource
            // 
            this.btn_RefreshDataSource.Caption = "Verileri Güncelle";
            this.btn_RefreshDataSource.Id = 1;
            this.btn_RefreshDataSource.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_RefreshDataSource.ImageOptions.SvgImage")));
            this.btn_RefreshDataSource.Name = "btn_RefreshDataSource";
            this.btn_RefreshDataSource.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_RefreshDataSource.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_RefreshDataSource_ItemClick);
            // 
            // btn_ExportPDF
            // 
            this.btn_ExportPDF.Caption = "PDF\'e Aktar";
            this.btn_ExportPDF.Id = 2;
            this.btn_ExportPDF.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_ExportPDF.ImageOptions.SvgImage")));
            this.btn_ExportPDF.Name = "btn_ExportPDF";
            this.btn_ExportPDF.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_ExportPDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ExportPDF_ItemClick);
            // 
            // btn_ExportXLSX
            // 
            this.btn_ExportXLSX.Caption = "Excel\'e Aktar";
            this.btn_ExportXLSX.Id = 3;
            this.btn_ExportXLSX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_ExportXLSX.ImageOptions.SvgImage")));
            this.btn_ExportXLSX.Name = "btn_ExportXLSX";
            this.btn_ExportXLSX.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_ExportXLSX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ExportXLSX_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1053, 33);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 331);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1053, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 33);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 298);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1053, 33);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 298);
            // 
            // gridControl_Departments
            // 
            this.gridControl_Departments.DataSource = this.pLinqServerModeSource1;
            this.gridControl_Departments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Departments.Location = new System.Drawing.Point(0, 33);
            this.gridControl_Departments.MainView = this.gridView_Departments;
            this.gridControl_Departments.MenuManager = this.barManager1;
            this.gridControl_Departments.Name = "gridControl_Departments";
            this.gridControl_Departments.Size = new System.Drawing.Size(1053, 298);
            this.gridControl_Departments.TabIndex = 4;
            this.gridControl_Departments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Departments});
            // 
            // gridView_Departments
            // 
            this.gridView_Departments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDepartmentCode,
            this.colId,
            this.colIsActive,
            this.colCreatedDate,
            this.colModifiedDate});
            this.gridView_Departments.GridControl = this.gridControl_Departments;
            this.gridView_Departments.Name = "gridView_Departments";
            this.gridView_Departments.OptionsFind.AlwaysVisible = true;
            this.gridView_Departments.OptionsFind.Condition = DevExpress.Data.Filtering.FilterCondition.Contains;
            this.gridView_Departments.OptionsFind.FindDelay = 100;
            this.gridView_Departments.OptionsFind.SearchInPreview = true;
            this.gridView_Departments.OptionsView.ShowGroupPanel = false;
            this.gridView_Departments.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Departments_RowClick);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colDepartmentCode
            // 
            this.colDepartmentCode.FieldName = "DepartmentCode";
            this.colDepartmentCode.Name = "colDepartmentCode";
            this.colDepartmentCode.Visible = true;
            this.colDepartmentCode.VisibleIndex = 0;
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
            this.colIsActive.VisibleIndex = 2;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.Visible = true;
            this.colCreatedDate.VisibleIndex = 3;
            // 
            // colModifiedDate
            // 
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
            this.colModifiedDate.Visible = true;
            this.colModifiedDate.VisibleIndex = 4;
            // 
            // pLinqServerModeSource1
            // 
            this.pLinqServerModeSource1.DefaultSorting = "DepartmentCode ASC";
            this.pLinqServerModeSource1.ElementType = typeof(weEnvanter.Domain.Entities.Department);
            // 
            // DepartmentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 331);
            this.Controls.Add(this.gridControl_Departments);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::weEnvanter.Properties.Resources.weEnvanter_icon;
            this.Name = "DepartmentListForm";
            this.Text = "Departman Listesi - weEnvanter";
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Departments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Departments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLinqServerModeSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_AddNewDepartment;
        private DevExpress.XtraBars.BarButtonItem btn_RefreshDataSource;
        private DevExpress.XtraBars.BarButtonItem btn_ExportPDF;
        private DevExpress.XtraBars.BarButtonItem btn_ExportXLSX;
        private DevExpress.XtraGrid.GridControl gridControl_Departments;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Departments;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentCode;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraBars.BarButtonItem bar_EditDepartment;
        private DevExpress.XtraBars.BarButtonItem bar_Delete;
        private DevExpress.XtraBars.BarButtonItem bar_ShowEmployee;
        private DevExpress.Data.PLinq.PLinqServerModeSource pLinqServerModeSource1;
    }
}