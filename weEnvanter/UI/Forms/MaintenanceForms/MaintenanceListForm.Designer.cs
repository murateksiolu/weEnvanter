namespace weEnvanter.UI.Forms.MaintenanceForms
{
    partial class MaintenanceListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceListForm));
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bar_EditMaintenance = new DevExpress.XtraBars.BarButtonItem();
            this.bar_DeleteMaintenance = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_AddNewMaintenance = new DevExpress.XtraBars.BarButtonItem();
            this.btn_RefreshDataSource = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ExportPDF = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ExportXLSX = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl_Maintenances = new DevExpress.XtraGrid.GridControl();
            this.pLinqServerModeSource1 = new DevExpress.Data.PLinq.PLinqServerModeSource();
            this.gridView_Maintenances = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Maintenances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLinqServerModeSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Maintenances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_EditMaintenance),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_DeleteMaintenance)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // bar_EditMaintenance
            // 
            this.bar_EditMaintenance.Caption = "Düzenle";
            this.bar_EditMaintenance.Id = 4;
            this.bar_EditMaintenance.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bar_EditMaintenance.ImageOptions.SvgImage")));
            this.bar_EditMaintenance.Name = "bar_EditMaintenance";
            this.bar_EditMaintenance.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_EditMaintenance_ItemClick);
            // 
            // bar_DeleteMaintenance
            // 
            this.bar_DeleteMaintenance.Caption = "Sil";
            this.bar_DeleteMaintenance.Id = 5;
            this.bar_DeleteMaintenance.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bar_DeleteMaintenance.ImageOptions.SvgImage")));
            this.bar_DeleteMaintenance.Name = "bar_DeleteMaintenance";
            this.bar_DeleteMaintenance.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_DeleteMaintenance_ItemClick);
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
            this.btn_AddNewMaintenance,
            this.btn_RefreshDataSource,
            this.btn_ExportPDF,
            this.btn_ExportXLSX,
            this.bar_EditMaintenance,
            this.bar_DeleteMaintenance});
            this.barManager1.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_AddNewMaintenance),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_RefreshDataSource),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ExportPDF),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ExportXLSX)});
            this.bar1.Text = "Custom 2";
            // 
            // btn_AddNewMaintenance
            // 
            this.btn_AddNewMaintenance.Caption = "Yeni Bakım Ekle";
            this.btn_AddNewMaintenance.Id = 0;
            this.btn_AddNewMaintenance.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_AddNewMaintenance.ImageOptions.SvgImage")));
            this.btn_AddNewMaintenance.Name = "btn_AddNewMaintenance";
            this.btn_AddNewMaintenance.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_AddNewMaintenance.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_AddNewMaintenance_ItemClick);
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
            // gridControl_Maintenances
            // 
            this.gridControl_Maintenances.DataSource = this.pLinqServerModeSource1;
            this.gridControl_Maintenances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Maintenances.Location = new System.Drawing.Point(0, 33);
            this.gridControl_Maintenances.MainView = this.gridView_Maintenances;
            this.gridControl_Maintenances.MenuManager = this.barManager1;
            this.gridControl_Maintenances.Name = "gridControl_Maintenances";
            this.gridControl_Maintenances.Size = new System.Drawing.Size(1053, 298);
            this.gridControl_Maintenances.TabIndex = 4;
            this.gridControl_Maintenances.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Maintenances});
            // 
            // pLinqServerModeSource1
            // 
            this.pLinqServerModeSource1.DefaultSorting = "DepartmentCode ASC";
            this.pLinqServerModeSource1.ElementType = typeof(weEnvanter.Domain.Entities.Department);
            // 
            // gridView_Maintenances
            // 
            this.gridView_Maintenances.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDepartmentCode,
            this.colId,
            this.colIsActive,
            this.colCreatedDate,
            this.colModifiedDate});
            this.gridView_Maintenances.GridControl = this.gridControl_Maintenances;
            this.gridView_Maintenances.Name = "gridView_Maintenances";
            this.gridView_Maintenances.OptionsFind.AlwaysVisible = true;
            this.gridView_Maintenances.OptionsFind.Condition = DevExpress.Data.Filtering.FilterCondition.Contains;
            this.gridView_Maintenances.OptionsFind.FindDelay = 100;
            this.gridView_Maintenances.OptionsFind.SearchInPreview = true;
            this.gridView_Maintenances.OptionsView.ShowGroupPanel = false;
            this.gridView_Maintenances.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Maintenances_RowClick);
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
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "f6724efb-e6a9-4033-a93d-737359eccec2";
            // 
            // MaintenanceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 331);
            this.Controls.Add(this.gridControl_Maintenances);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::weEnvanter.Properties.Resources.weEnvanter_icon;
            this.Name = "MaintenanceListForm";
            this.Text = "Bakım Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Maintenances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLinqServerModeSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Maintenances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btn_AddNewMaintenance;
        private DevExpress.XtraBars.BarButtonItem btn_RefreshDataSource;
        private DevExpress.XtraBars.BarButtonItem btn_ExportPDF;
        private DevExpress.XtraBars.BarButtonItem btn_ExportXLSX;
        private DevExpress.XtraGrid.GridControl gridControl_Maintenances;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Maintenances;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentCode;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraBars.BarButtonItem bar_EditMaintenance;
        private DevExpress.XtraBars.BarButtonItem bar_DeleteMaintenance;
        private DevExpress.Data.PLinq.PLinqServerModeSource pLinqServerModeSource1;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
    }
}