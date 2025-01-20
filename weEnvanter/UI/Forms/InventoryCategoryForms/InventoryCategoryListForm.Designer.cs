namespace weEnvanter.UI.Forms.InventoryCategoryForms
{
    partial class InventoryCategoryListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryCategoryListForm));
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_AddInventoryCategory = new DevExpress.XtraBars.BarButtonItem();
            this.btn_RefreshDataSource = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ExportPDF = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ExportXLSX = new DevExpress.XtraBars.BarButtonItem();
            this.gridControl_InventoryCategories = new DevExpress.XtraGrid.GridControl();
            this.gridView_InventoryCategories = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pLinqServerModeSource1 = new DevExpress.Data.PLinq.PLinqServerModeSource();
            this.colCategoryCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCategories = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bar_EditInventoryCategory = new DevExpress.XtraBars.BarButtonItem();
            this.bar_DeleteInventoryCategory = new DevExpress.XtraBars.BarButtonItem();
            this.bar_ShowRelationalInventoryList = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_InventoryCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_InventoryCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLinqServerModeSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_EditInventoryCategory),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_DeleteInventoryCategory),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_ShowRelationalInventoryList)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "f6724efb-e6a9-4033-a93d-737359eccec2";
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
            this.btn_AddInventoryCategory,
            this.btn_RefreshDataSource,
            this.btn_ExportPDF,
            this.btn_ExportXLSX,
            this.bar_EditInventoryCategory,
            this.bar_DeleteInventoryCategory,
            this.bar_ShowRelationalInventoryList});
            this.barManager1.MaxItemId = 7;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(535, 33);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 325);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(535, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 33);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 292);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(535, 33);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 292);
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_AddInventoryCategory),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_RefreshDataSource),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ExportPDF),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ExportXLSX)});
            this.bar1.Text = "Custom 2";
            // 
            // btn_AddInventoryCategory
            // 
            this.btn_AddInventoryCategory.Caption = "Demirbaş Kategorisi Ekle";
            this.btn_AddInventoryCategory.Id = 0;
            this.btn_AddInventoryCategory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_AddInventoryCategory.ImageOptions.SvgImage")));
            this.btn_AddInventoryCategory.Name = "btn_AddInventoryCategory";
            this.btn_AddInventoryCategory.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_AddInventoryCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_AddInventoryCategory_ItemClick);
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
            // gridControl_InventoryCategories
            // 
            this.gridControl_InventoryCategories.DataSource = this.pLinqServerModeSource1;
            this.gridControl_InventoryCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_InventoryCategories.Location = new System.Drawing.Point(0, 33);
            this.gridControl_InventoryCategories.MainView = this.gridView_InventoryCategories;
            this.gridControl_InventoryCategories.MenuManager = this.barManager1;
            this.gridControl_InventoryCategories.Name = "gridControl_InventoryCategories";
            this.gridControl_InventoryCategories.Size = new System.Drawing.Size(535, 292);
            this.gridControl_InventoryCategories.TabIndex = 4;
            this.gridControl_InventoryCategories.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_InventoryCategories});
            // 
            // gridView_InventoryCategories
            // 
            this.gridView_InventoryCategories.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoryCode,
            this.colName,
            this.colIsActive,
            this.colParentCategoryId,
            this.colParentCategory,
            this.colSubCategories,
            this.colId,
            this.colCreatedDate,
            this.colModifiedDate});
            this.gridView_InventoryCategories.GridControl = this.gridControl_InventoryCategories;
            this.gridView_InventoryCategories.Name = "gridView_InventoryCategories";
            this.gridView_InventoryCategories.OptionsView.ShowGroupPanel = false;
            this.gridView_InventoryCategories.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_InventoryCategories_RowClick);
            // 
            // pLinqServerModeSource1
            // 
            this.pLinqServerModeSource1.DefaultSorting = "CategoryCode ASC";
            this.pLinqServerModeSource1.ElementType = typeof(weEnvanter.Domain.Entities.InventoryCategory);
            // 
            // colCategoryCode
            // 
            this.colCategoryCode.FieldName = "CategoryCode";
            this.colCategoryCode.Name = "colCategoryCode";
            this.colCategoryCode.Visible = true;
            this.colCategoryCode.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 2;
            // 
            // colParentCategoryId
            // 
            this.colParentCategoryId.FieldName = "ParentCategoryId";
            this.colParentCategoryId.Name = "colParentCategoryId";
            // 
            // colParentCategory
            // 
            this.colParentCategory.FieldName = "ParentCategory";
            this.colParentCategory.Name = "colParentCategory";
            this.colParentCategory.Visible = true;
            this.colParentCategory.VisibleIndex = 3;
            // 
            // colSubCategories
            // 
            this.colSubCategories.FieldName = "SubCategories";
            this.colSubCategories.Name = "colSubCategories";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.Visible = true;
            this.colCreatedDate.VisibleIndex = 4;
            // 
            // colModifiedDate
            // 
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
            this.colModifiedDate.Visible = true;
            this.colModifiedDate.VisibleIndex = 5;
            // 
            // bar_EditInventoryCategory
            // 
            this.bar_EditInventoryCategory.Caption = "Düzenle";
            this.bar_EditInventoryCategory.Id = 4;
            this.bar_EditInventoryCategory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bar_EditInventoryCategory.ImageOptions.SvgImage")));
            this.bar_EditInventoryCategory.Name = "bar_EditInventoryCategory";
            this.bar_EditInventoryCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_EditInventoryCategory_ItemClick);
            // 
            // bar_DeleteInventoryCategory
            // 
            this.bar_DeleteInventoryCategory.Caption = "Sil";
            this.bar_DeleteInventoryCategory.Id = 5;
            this.bar_DeleteInventoryCategory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bar_DeleteInventoryCategory.ImageOptions.SvgImage")));
            this.bar_DeleteInventoryCategory.Name = "bar_DeleteInventoryCategory";
            this.bar_DeleteInventoryCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_DeleteInventoryCategory_ItemClick);
            // 
            // bar_ShowRelationalInventoryList
            // 
            this.bar_ShowRelationalInventoryList.Caption = "Bağlı Demirbaşları Görüntüle";
            this.bar_ShowRelationalInventoryList.Id = 6;
            this.bar_ShowRelationalInventoryList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bar_ShowRelationalInventoryList.ImageOptions.SvgImage")));
            this.bar_ShowRelationalInventoryList.Name = "bar_ShowRelationalInventoryList";
            this.bar_ShowRelationalInventoryList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ShowRelationalInventoryList_ItemClick);
            // 
            // InventoryCategoryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 325);
            this.Controls.Add(this.gridControl_InventoryCategories);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::weEnvanter.Properties.Resources.weEnvanter_icon;
            this.Name = "InventoryCategoryListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demirbaş Kategori Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_InventoryCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_InventoryCategories)).EndInit();
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
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraBars.BarButtonItem btn_AddInventoryCategory;
        private DevExpress.XtraBars.BarButtonItem btn_RefreshDataSource;
        private DevExpress.XtraBars.BarButtonItem btn_ExportPDF;
        private DevExpress.XtraBars.BarButtonItem btn_ExportXLSX;
        private DevExpress.XtraGrid.GridControl gridControl_InventoryCategories;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_InventoryCategories;
        private DevExpress.Data.PLinq.PLinqServerModeSource pLinqServerModeSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colParentCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colParentCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCategories;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraBars.BarButtonItem bar_EditInventoryCategory;
        private DevExpress.XtraBars.BarButtonItem bar_DeleteInventoryCategory;
        private DevExpress.XtraBars.BarButtonItem bar_ShowRelationalInventoryList;
    }
}