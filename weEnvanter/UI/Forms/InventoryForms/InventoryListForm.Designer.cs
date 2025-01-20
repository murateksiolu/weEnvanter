namespace weEnvanter.UI.Forms.InventoryForms
{
    partial class InventoryListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryListForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_Add = new DevExpress.XtraBars.BarButtonItem();
            this.btn_RefreshData = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ExportPDF = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ExportXLSX = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar_Edit = new DevExpress.XtraBars.BarButtonItem();
            this.bar_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.bar_EmbezzlementToEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.bar_RemoveFromEmbezzlement = new DevExpress.XtraBars.BarButtonItem();
            this.bar_EmbezzlementHistory = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.pLinqServerModeSource1 = new DevExpress.Data.PLinq.PLinqServerModeSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarcodeNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchasePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarrantyEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhotoPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssignments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaintenanceRecords = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraSaveFileDialog1 = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLinqServerModeSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Add,
            this.btn_RefreshData,
            this.btn_ExportPDF,
            this.btn_ExportXLSX,
            this.bar_Edit,
            this.bar_Delete,
            this.bar_EmbezzlementToEmployee,
            this.bar_RemoveFromEmbezzlement,
            this.bar_EmbezzlementHistory});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Add),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_RefreshData),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ExportPDF),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ExportXLSX)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_Add
            // 
            this.btn_Add.Caption = "Yeni Demirbaş Ekle";
            this.btn_Add.Id = 0;
            this.btn_Add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Add.ImageOptions.SvgImage")));
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Add_ItemClick);
            // 
            // btn_RefreshData
            // 
            this.btn_RefreshData.Caption = "Verileri Güncelle";
            this.btn_RefreshData.Id = 1;
            this.btn_RefreshData.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_RefreshData.ImageOptions.SvgImage")));
            this.btn_RefreshData.Name = "btn_RefreshData";
            this.btn_RefreshData.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_RefreshData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_RefreshData_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(973, 35);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 554);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(973, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 35);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 519);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(973, 35);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 519);
            // 
            // bar_Edit
            // 
            this.bar_Edit.Caption = "Düzenle";
            this.bar_Edit.Id = 4;
            this.bar_Edit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bar_Edit.ImageOptions.SvgImage")));
            this.bar_Edit.Name = "bar_Edit";
            this.bar_Edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_Edit_ItemClick);
            // 
            // bar_Delete
            // 
            this.bar_Delete.Caption = "Sil";
            this.bar_Delete.Id = 5;
            this.bar_Delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bar_Delete.ImageOptions.SvgImage")));
            this.bar_Delete.Name = "bar_Delete";
            this.bar_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_Delete_ItemClick);
            // 
            // bar_EmbezzlementToEmployee
            // 
            this.bar_EmbezzlementToEmployee.Caption = "Çalışana Zimmetle";
            this.bar_EmbezzlementToEmployee.Id = 6;
            this.bar_EmbezzlementToEmployee.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bar_EmbezzlementToEmployee.ImageOptions.SvgImage")));
            this.bar_EmbezzlementToEmployee.Name = "bar_EmbezzlementToEmployee";
            this.bar_EmbezzlementToEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_EmbezzlementToEmployee_ItemClick);
            // 
            // bar_RemoveFromEmbezzlement
            // 
            this.bar_RemoveFromEmbezzlement.Caption = "Zimmetten Düşür";
            this.bar_RemoveFromEmbezzlement.Id = 7;
            this.bar_RemoveFromEmbezzlement.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bar_RemoveFromEmbezzlement.ImageOptions.SvgImage")));
            this.bar_RemoveFromEmbezzlement.Name = "bar_RemoveFromEmbezzlement";
            this.bar_RemoveFromEmbezzlement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_RemoveFromEmbezzlement_ItemClick);
            // 
            // bar_EmbezzlementHistory
            // 
            this.bar_EmbezzlementHistory.Caption = "Zimmet Geçmişi";
            this.bar_EmbezzlementHistory.Id = 8;
            this.bar_EmbezzlementHistory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bar_EmbezzlementHistory.ImageOptions.SvgImage")));
            this.bar_EmbezzlementHistory.Name = "bar_EmbezzlementHistory";
            this.bar_EmbezzlementHistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_EmbezzlementHistory_ItemClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 35);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(973, 519);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Demirbaş Listesi";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.pLinqServerModeSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 22);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(969, 495);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // pLinqServerModeSource1
            // 
            this.pLinqServerModeSource1.DefaultSorting = "Name ASC";
            this.pLinqServerModeSource1.ElementType = typeof(weEnvanter.Domain.Entities.Inventory);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colSerialNumber,
            this.colBarcodeNumber,
            this.colCategoryId,
            this.colPurchaseDate,
            this.colPurchasePrice,
            this.colWarrantyEndDate,
            this.colStatus,
            this.colDescription,
            this.colPhotoPath,
            this.colCategory,
            this.colAssignments,
            this.colMaintenanceRecords,
            this.colId,
            this.colIsActive,
            this.colCreatedDate,
            this.colModifiedDate,
            this.colCreatedBy,
            this.colModifiedBy});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colSerialNumber
            // 
            this.colSerialNumber.FieldName = "SerialNumber";
            this.colSerialNumber.Name = "colSerialNumber";
            this.colSerialNumber.Visible = true;
            this.colSerialNumber.VisibleIndex = 1;
            // 
            // colBarcodeNumber
            // 
            this.colBarcodeNumber.FieldName = "BarcodeNumber";
            this.colBarcodeNumber.Name = "colBarcodeNumber";
            this.colBarcodeNumber.Visible = true;
            this.colBarcodeNumber.VisibleIndex = 2;
            // 
            // colCategoryId
            // 
            this.colCategoryId.FieldName = "CategoryId";
            this.colCategoryId.Name = "colCategoryId";
            this.colCategoryId.Visible = true;
            this.colCategoryId.VisibleIndex = 3;
            // 
            // colPurchaseDate
            // 
            this.colPurchaseDate.FieldName = "PurchaseDate";
            this.colPurchaseDate.Name = "colPurchaseDate";
            this.colPurchaseDate.Visible = true;
            this.colPurchaseDate.VisibleIndex = 4;
            // 
            // colPurchasePrice
            // 
            this.colPurchasePrice.FieldName = "PurchasePrice";
            this.colPurchasePrice.Name = "colPurchasePrice";
            this.colPurchasePrice.Visible = true;
            this.colPurchasePrice.VisibleIndex = 5;
            // 
            // colWarrantyEndDate
            // 
            this.colWarrantyEndDate.FieldName = "WarrantyEndDate";
            this.colWarrantyEndDate.Name = "colWarrantyEndDate";
            this.colWarrantyEndDate.Visible = true;
            this.colWarrantyEndDate.VisibleIndex = 6;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 7;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 8;
            // 
            // colPhotoPath
            // 
            this.colPhotoPath.FieldName = "PhotoPath";
            this.colPhotoPath.Name = "colPhotoPath";
            this.colPhotoPath.Visible = true;
            this.colPhotoPath.VisibleIndex = 9;
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 10;
            // 
            // colAssignments
            // 
            this.colAssignments.FieldName = "Assignments";
            this.colAssignments.Name = "colAssignments";
            this.colAssignments.Visible = true;
            this.colAssignments.VisibleIndex = 11;
            // 
            // colMaintenanceRecords
            // 
            this.colMaintenanceRecords.FieldName = "MaintenanceRecords";
            this.colMaintenanceRecords.Name = "colMaintenanceRecords";
            this.colMaintenanceRecords.Visible = true;
            this.colMaintenanceRecords.VisibleIndex = 12;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 13;
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 14;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.Visible = true;
            this.colCreatedDate.VisibleIndex = 15;
            // 
            // colModifiedDate
            // 
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
            this.colModifiedDate.Visible = true;
            this.colModifiedDate.VisibleIndex = 16;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.Visible = true;
            this.colCreatedBy.VisibleIndex = 17;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.Visible = true;
            this.colModifiedBy.VisibleIndex = 18;
            // 
            // xtraSaveFileDialog1
            // 
            this.xtraSaveFileDialog1.FileName = "xtraSaveFileDialog1";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_Edit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_Delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_EmbezzlementToEmployee),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_RemoveFromEmbezzlement),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_EmbezzlementHistory)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "f6724efb-e6a9-4033-a93d-737359eccec2";
            // 
            // InventoryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 554);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::weEnvanter.Properties.Resources.weEnvanter_icon;
            this.IsMdiContainer = true;
            this.Name = "InventoryListForm";
            this.Text = "Demirbaş Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLinqServerModeSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Data.PLinq.PLinqServerModeSource pLinqServerModeSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSerialNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcodeNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchasePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colWarrantyEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPhotoPath;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colAssignments;
        private DevExpress.XtraGrid.Columns.GridColumn colMaintenanceRecords;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraBars.BarButtonItem btn_Add;
        private DevExpress.XtraBars.BarButtonItem btn_RefreshData;
        private DevExpress.XtraBars.BarButtonItem btn_ExportPDF;
        private DevExpress.XtraBars.BarButtonItem btn_ExportXLSX;
        private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog1;
        private DevExpress.XtraBars.BarButtonItem bar_Edit;
        private DevExpress.XtraBars.BarButtonItem bar_Delete;
        private DevExpress.XtraBars.BarButtonItem bar_EmbezzlementToEmployee;
        private DevExpress.XtraBars.BarButtonItem bar_RemoveFromEmbezzlement;
        private DevExpress.XtraBars.BarButtonItem bar_EmbezzlementHistory;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
    }
}