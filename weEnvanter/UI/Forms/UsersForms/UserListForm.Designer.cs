namespace weEnvanter.UI.Forms.UsersForms
{
    partial class UserListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserListForm));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bar_EditUser = new DevExpress.XtraBars.BarButtonItem();
            this.bar_DeleteUser = new DevExpress.XtraBars.BarButtonItem();
            this.bar_ShowHistory = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_AddNewUser = new DevExpress.XtraBars.BarButtonItem();
            this.btn_RefreshDataSource = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ExportPDF = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ExportXLSX = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl_Users = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView_Users = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullanıcıAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colİsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyisim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSonGirişTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAktiflikDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_EditUser),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_DeleteUser),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_ShowHistory)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // bar_EditUser
            // 
            this.bar_EditUser.Caption = "Düzenle";
            this.bar_EditUser.Id = 4;
            this.bar_EditUser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bar_EditUser.ImageOptions.SvgImage")));
            this.bar_EditUser.Name = "bar_EditUser";
            this.bar_EditUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_EditUser_ItemClick);
            // 
            // bar_DeleteUser
            // 
            this.bar_DeleteUser.Caption = "Sil";
            this.bar_DeleteUser.Id = 5;
            this.bar_DeleteUser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bar_DeleteUser.ImageOptions.SvgImage")));
            this.bar_DeleteUser.Name = "bar_DeleteUser";
            this.bar_DeleteUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_DeleteUser_ItemClick);
            // 
            // bar_ShowHistory
            // 
            this.bar_ShowHistory.Caption = "Geçmiş İşlemlerini Görüntüle";
            this.bar_ShowHistory.Id = 6;
            this.bar_ShowHistory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bar_ShowHistory.ImageOptions.SvgImage")));
            this.bar_ShowHistory.Name = "bar_ShowHistory";
            this.bar_ShowHistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ShowHistory_ItemClick);
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
            this.btn_AddNewUser,
            this.btn_RefreshDataSource,
            this.btn_ExportPDF,
            this.btn_ExportXLSX,
            this.bar_EditUser,
            this.bar_DeleteUser,
            this.bar_ShowHistory});
            this.barManager1.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_AddNewUser),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_RefreshDataSource),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ExportPDF),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ExportXLSX)});
            this.bar1.Text = "Custom 2";
            // 
            // btn_AddNewUser
            // 
            this.btn_AddNewUser.Caption = "Yeni Kullanıcı Ekle";
            this.btn_AddNewUser.Id = 0;
            this.btn_AddNewUser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_AddNewUser.ImageOptions.SvgImage")));
            this.btn_AddNewUser.Name = "btn_AddNewUser";
            this.btn_AddNewUser.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_AddNewUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_AddNewUser_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(803, 33);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 467);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(803, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 33);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 434);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(803, 33);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 434);
            // 
            // gridControl_Users
            // 
            this.gridControl_Users.DataMember = "Users";
            this.gridControl_Users.DataSource = this.sqlDataSource1;
            this.gridControl_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Users.Location = new System.Drawing.Point(0, 33);
            this.gridControl_Users.MainView = this.gridView_Users;
            this.gridControl_Users.Name = "gridControl_Users";
            this.gridControl_Users.Size = new System.Drawing.Size(803, 434);
            this.gridControl_Users.TabIndex = 0;
            this.gridControl_Users.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Users});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "Username";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"363\" />";
            table1.Name = "Users";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "FirstName";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "LastName";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "LastLoginDate";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "IsActive";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.FilterString = "[Users.IsDeleted] = False";
            selectQuery1.GroupFilterString = "";
            selectQuery1.MetaSerializable = "<Meta X=\"20\" Y=\"20\" Width=\"105\" Height=\"141\" />";
            selectQuery1.Name = "Users";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView_Users
            // 
            this.gridView_Users.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKullanıcıAdı,
            this.colİsim,
            this.colSoyisim,
            this.colSonGirişTarihi,
            this.colAktiflikDurumu});
            this.gridView_Users.GridControl = this.gridControl_Users;
            this.gridView_Users.Name = "gridView_Users";
            this.gridView_Users.OptionsView.ShowGroupPanel = false;
            this.gridView_Users.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Users_RowClick);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colKullanıcıAdı
            // 
            this.colKullanıcıAdı.FieldName = "Kullanıcı Adı";
            this.colKullanıcıAdı.Name = "colKullanıcıAdı";
            this.colKullanıcıAdı.Visible = true;
            this.colKullanıcıAdı.VisibleIndex = 0;
            // 
            // colİsim
            // 
            this.colİsim.FieldName = "İsim";
            this.colİsim.Name = "colİsim";
            this.colİsim.Visible = true;
            this.colİsim.VisibleIndex = 1;
            // 
            // colSoyisim
            // 
            this.colSoyisim.FieldName = "Soyisim";
            this.colSoyisim.Name = "colSoyisim";
            this.colSoyisim.Visible = true;
            this.colSoyisim.VisibleIndex = 2;
            // 
            // colSonGirişTarihi
            // 
            this.colSonGirişTarihi.FieldName = "Son Giriş Tarihi";
            this.colSonGirişTarihi.Name = "colSonGirişTarihi";
            this.colSonGirişTarihi.Visible = true;
            this.colSonGirişTarihi.VisibleIndex = 3;
            // 
            // colAktiflikDurumu
            // 
            this.colAktiflikDurumu.FieldName = "Aktiflik Durumu";
            this.colAktiflikDurumu.Name = "colAktiflikDurumu";
            this.colAktiflikDurumu.Visible = true;
            this.colAktiflikDurumu.VisibleIndex = 4;
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 467);
            this.Controls.Add(this.gridControl_Users);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::weEnvanter.Properties.Resources.weEnvanter_icon;
            this.Name = "UserListForm";
            this.Text = "Kullanıcı Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Users)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControl_Users;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Users;
        private DevExpress.XtraBars.BarButtonItem btn_AddNewUser;
        private DevExpress.XtraBars.BarButtonItem btn_RefreshDataSource;
        private DevExpress.XtraBars.BarButtonItem btn_ExportPDF;
        private DevExpress.XtraBars.BarButtonItem btn_ExportXLSX;
        private DevExpress.XtraBars.BarButtonItem bar_EditUser;
        private DevExpress.XtraBars.BarButtonItem bar_DeleteUser;
        private DevExpress.XtraBars.BarButtonItem bar_ShowHistory;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colKullanıcıAdı;
        private DevExpress.XtraGrid.Columns.GridColumn colİsim;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyisim;
        private DevExpress.XtraGrid.Columns.GridColumn colSonGirişTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colAktiflikDurumu;
    }
}