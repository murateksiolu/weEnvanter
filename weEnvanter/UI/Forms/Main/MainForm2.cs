using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraCharts;
using DevExpress.Utils;
using DevExpress.DashboardWin;
using System;
using System.Drawing;
using System.Windows.Forms;
using weEnvanter.UI.Forms.Auth;
using weEnvanter.Business.Services;
using DevExpress.XtraTab;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraDashboardLayout;

namespace weEnvanter.UI.Forms.Main
{
    public partial class MainForm2 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IUserService _userService;
        private DashboardLayoutControl dashboardLayout;
        private FlowLayoutPanel quickActionsPanel;
        private Timer refreshTimer;

        public MainForm2(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
            InitializeUserInfo();
            InitializeEvents();
            InitializeDashboard();
            SetupRefreshTimer();
        }

        private void InitializeDashboard()
        {
            // Ana dashboard container
            dashboardLayout = new DashboardLayoutControl();
            dashboardLayout.Dock = DockStyle.Fill;
            this.Controls.Add(dashboardLayout);

            // Kartlar için panel
            var cardsPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 120,
                Padding = new Padding(10),
                AutoScroll = true
            };

            // Kartları oluştur
            CreateStatusCards(cardsPanel);

            // Kartları ekle
            var cardsItem = new DevExpress.XtraLayout.LayoutControlItem();
            cardsItem.Control = cardsPanel;

            var cardsGroup = dashboardLayout.Root.AddGroup();
            cardsGroup.Text = "Genel Durum";
            cardsGroup.Height = 150;
            cardsGroup.AddItem(cardsItem);

            // Grafikler için panel
            var chartsPanel = new PanelControl
            {
                Dock = DockStyle.Top,
                Height = 300
            };

            // Grafikleri oluştur
            CreateCharts(chartsPanel);

            // Grafikleri ekle
            var chartsItem = new DevExpress.XtraLayout.LayoutControlItem();
            chartsItem.Control = chartsPanel;

            var chartsGroup = dashboardLayout.Root.AddGroup();
            chartsGroup.Text = "Grafik Analizleri";
            chartsGroup.AddItem(chartsItem);

            // Hızlı işlemler için panel
            var quickActionsPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 100,
                Padding = new Padding(10),
                AutoScroll = true
            };

            // Hızlı işlemleri oluştur
            CreateQuickActions(quickActionsPanel);

            // Hızlı işlemleri ekle
            var actionsItem = new DevExpress.XtraLayout.LayoutControlItem();
            actionsItem.Control = quickActionsPanel;

            var actionsGroup = dashboardLayout.Root.AddGroup();
            actionsGroup.Text = "Hızlı İşlemler";
            actionsGroup.Height = 130;
            actionsGroup.AddItem(actionsItem);

            // Widget'lar için panel
            var widgetsPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 2,
                Padding = new Padding(10),
                ColumnStyles = {
                    new ColumnStyle(SizeType.Percent, 33.33F),
                    new ColumnStyle(SizeType.Percent, 33.33F),
                    new ColumnStyle(SizeType.Percent, 33.33F)
                },
                RowStyles = {
                    new RowStyle(SizeType.Percent, 50F),
                    new RowStyle(SizeType.Percent, 50F)
                }
            };

            // Widget'ları oluştur
            CreateInfoWidgets(widgetsPanel);

            // Widget'ları ekle
            var widgetsItem = new DevExpress.XtraLayout.LayoutControlItem();
            widgetsItem.Control = widgetsPanel;

            var widgetsGroup = dashboardLayout.Root.AddGroup();
            widgetsGroup.Text = "Bilgi Panelleri";
            widgetsGroup.Height = 400;
            widgetsGroup.AddItem(widgetsItem);

            // Son hareketler için panel
            var activitiesPanel = new PanelControl
            {
                Dock = DockStyle.Fill
            };

            // Son hareketleri oluştur
            CreateRecentActivities(activitiesPanel);

            // Son hareketleri ekle
            var activitiesItem = new DevExpress.XtraLayout.LayoutControlItem();
            activitiesItem.Control = activitiesPanel;

            var activitiesGroup = dashboardLayout.Root.AddGroup();
            activitiesGroup.Text = "Son Hareketler";
            activitiesGroup.Height = 250;
            activitiesGroup.AddItem(activitiesItem);

            // Layout'u güncelle
            dashboardLayout.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(10);
            dashboardLayout.BestFit();
        }

        private void CreateStatusCards(FlowLayoutPanel cardsPanel)
        {
            // Toplam Demirbaş Kartı
            var totalInventoryCard = CreateStatusCard("Toplam Demirbaş", "0", "ItemsIcon", Color.FromArgb(41, 128, 185));
            
            // Aktif Demirbaş Kartı
            var activeInventoryCard = CreateStatusCard("Aktif Demirbaş", "0", "CheckIcon", Color.FromArgb(46, 204, 113));
            
            // Bakımda Olan Kartı
            var maintenanceCard = CreateStatusCard("Bakımda Olan", "0", "ToolsIcon", Color.FromArgb(230, 126, 34));
            
            // SKT Yaklaşan Kartı
            var expiryCard = CreateStatusCard("SKT Yaklaşan", "0", "AlertIcon", Color.FromArgb(231, 76, 60));
            
            // Kalibrasyon Bekleyen Kartı
            var calibrationCard = CreateStatusCard("Kalibrasyon Bekleyen", "0", "CalendarIcon", Color.FromArgb(155, 89, 182));
            
            // Toplam Çalışan Kartı
            var employeeCard = CreateStatusCard("Toplam Çalışan", "0", "UsersIcon", Color.FromArgb(52, 152, 219));

            cardsPanel.Controls.AddRange(new Control[] 
            { 
                totalInventoryCard, 
                activeInventoryCard, 
                maintenanceCard,
                expiryCard,
                calibrationCard,
                employeeCard 
            });
        }

        private Control CreateStatusCard(string title, string value, string iconName, Color color)
        {
            var card = new PanelControl
            {
                Width = 200,
                Height = 100,
                BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder,
                LookAndFeel = { UseDefaultLookAndFeel = false, Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat }
            };

            var titleLabel = new LabelControl
            {
                Text = title,
                Appearance = { Font = new Font("Segoe UI", 10, FontStyle.Regular), ForeColor = Color.Gray },
                AutoSizeMode = LabelAutoSizeMode.None,
                Dock = DockStyle.Top,
                Height = 25,
                Padding = new Padding(10, 5, 0, 0)
            };

            var valueLabel = new LabelControl
            {
                Text = value,
                Appearance = { 
                    Font = new Font("Segoe UI", 20, FontStyle.Bold), 
                    ForeColor = color,
                    TextOptions = { HAlignment = HorzAlignment.Center }
                },
                AutoSizeMode = LabelAutoSizeMode.None,
                Dock = DockStyle.Fill
            };

            card.Controls.AddRange(new Control[] { titleLabel, valueLabel });
            
            // Hover efekti
            card.MouseEnter += (s, e) => 
            {
                card.Appearance.BackColor = Color.FromArgb(245, 245, 245);
            };
            
            card.MouseLeave += (s, e) => 
            {
                card.Appearance.BackColor = Color.White;
            };

            return card;
        }

        private void CreateCharts(PanelControl chartsPanel)
        {
            // Kategori Dağılım Pasta Grafiği
            var categoryChart = new ChartControl();
            var categorySeries = new Series("Kategori Dağılımı", ViewType.Pie);
            
            // Örnek veri
            categorySeries.Points.Add(new SeriesPoint("Bilgisayar", 30));
            categorySeries.Points.Add(new SeriesPoint("Mobilya", 25));
            categorySeries.Points.Add(new SeriesPoint("Elektronik", 20));
            categorySeries.Points.Add(new SeriesPoint("Diğer", 25));
            
            categoryChart.Series.Add(categorySeries);
            categoryChart.Dock = DockStyle.Left;
            categoryChart.Width = chartsPanel.Width / 2;
            
            // Pasta grafik ayarları
            ((PieSeriesView)categorySeries.View).ExplodedDistancePercentage = 5;
            ((PieSeriesView)categorySeries.View).ExplodeMode = PieExplodeMode.All;
            
            // Departman Bazlı Demirbaş Dağılımı (Bar Chart)
            var departmentChart = new ChartControl();
            var departmentSeries = new Series("Departman Dağılımı", ViewType.Bar);
            
            // Örnek veri
            departmentSeries.Points.Add(new SeriesPoint("IT", 45));
            departmentSeries.Points.Add(new SeriesPoint("İK", 30));
            departmentSeries.Points.Add(new SeriesPoint("Muhasebe", 25));
            departmentSeries.Points.Add(new SeriesPoint("Satış", 35));
            
            departmentChart.Series.Add(departmentSeries);
            departmentChart.Dock = DockStyle.Fill;
            
            // Bar grafik ayarları
            ((BarSeriesView)departmentSeries.View).ColorEach = true;

            chartsPanel.Controls.AddRange(new Control[] { categoryChart, departmentChart });
        }

        private void CreateQuickActions(FlowLayoutPanel quickActionsPanel)
        {
            var actions = new[]
            {
                new { Text = "Demirbaş Ekle", Icon = "Add", Color = Color.FromArgb(52, 152, 219) },
                new { Text = "Çalışan Ekle", Icon = "UserAdd", Color = Color.FromArgb(46, 204, 113) },
                new { Text = "Demirbaş Atama", Icon = "Link", Color = Color.FromArgb(155, 89, 182) },
                new { Text = "Lokasyon Ekle", Icon = "MapPin", Color = Color.FromArgb(230, 126, 34) },
                new { Text = "Hızlı Sayım Başlat", Icon = "Calculator", Color = Color.FromArgb(231, 76, 60) }
            };

            foreach (var action in actions)
            {
                var button = CreateQuickActionButton(action.Text, action.Icon, action.Color);
                quickActionsPanel.Controls.Add(button);
            }
        }

        private void CreateInfoWidgets(TableLayoutPanel widgetsPanel)
        {
            // Widget'ları oluştur
            var maintenanceWidget = CreateInfoWidget("Bakım Süresi Gelen Demirbaşlar", Color.FromArgb(52, 152, 219));
            var expiryWidget = CreateInfoWidget("SKT'si Geçmiş Ürünler", Color.FromArgb(231, 76, 60));
            var logsWidget = CreateInfoWidget("Son Yapılan İşlemler (Log)", Color.FromArgb(46, 204, 113));
            var loginHistoryWidget = CreateInfoWidget("Son Kullanıcı Girişleri", Color.FromArgb(155, 89, 182));
            var calibrationWidget = CreateInfoWidget("Yaklaşan Kalibrasyon Tarihleri", Color.FromArgb(230, 126, 34));
            var maintenanceScheduleWidget = CreateInfoWidget("Periyodik Bakım Tarihleri", Color.FromArgb(41, 128, 185));

            // Widget'ları panele ekle
            widgetsPanel.Controls.Add(maintenanceWidget, 0, 0);
            widgetsPanel.Controls.Add(expiryWidget, 1, 0);
            widgetsPanel.Controls.Add(logsWidget, 2, 0);
            widgetsPanel.Controls.Add(loginHistoryWidget, 0, 1);
            widgetsPanel.Controls.Add(calibrationWidget, 1, 1);
            widgetsPanel.Controls.Add(maintenanceScheduleWidget, 2, 1);
        }

        private void CreateRecentActivities(PanelControl activitiesPanel)
        {
            var tabControl = new XtraTabControl
            {
                Dock = DockStyle.Fill,
                HeaderLocation = TabHeaderLocation.Left,
                HeaderOrientation = TabOrientation.Horizontal,
                AppearancePage = {
                    Header = {
                        Font = new Font("Segoe UI", 10),
                        Options = { UseFont = true }
                    }
                }
            };

            // Son Eklenen Demirbaşlar Tab
            var recentInventoryTab = CreateActivityTab("Son Eklenen Demirbaşlar", new[] 
            { 
                "DemirbasKodu",
                "DemirbasAdi",
                "Kategori",
                "EklemeTarihi" 
            });

            // Son Atanan Demirbaşlar Tab
            var recentAssignmentsTab = CreateActivityTab("Son Atanan Demirbaşlar", new[] 
            { 
                "DemirbasKodu",
                "DemirbasAdi",
                "AtananPersonel",
                "AtamaTarihi" 
            });

            // Son Güncellenen Kayıtlar Tab
            var recentUpdatesTab = CreateActivityTab("Son Güncellenen Kayıtlar", new[] 
            { 
                "KayitTipi",
                "KayitAdi",
                "Islem",
                "IslemTarihi",
                "Kullanici"
            });

            tabControl.TabPages.AddRange(new[] 
            { 
                recentInventoryTab,
                recentAssignmentsTab,
                recentUpdatesTab
            });

            activitiesPanel.Controls.Add(tabControl);
        }

        private XtraTabPage CreateActivityTab(string title, string[] columns)
        {
            var tabPage = new XtraTabPage
            {
                Text = title
            };

            var grid = new GridControl
            {
                Dock = DockStyle.Fill
            };

            var gridView = new GridView(grid);
            grid.MainView = gridView;

            // Sütunları ekle
            foreach (var column in columns)
            {
                gridView.Columns.AddVisible(column);
            }

            // Grid görünümünü özelleştir
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsView.ShowIndicator = false;
            gridView.Appearance.Row.Font = new Font("Segoe UI", 9);
            gridView.RowHeight = 25;

            // Alternatif satır renklendirmesi
            gridView.OptionsView.EnableAppearanceEvenRow = true;
            gridView.Appearance.EvenRow.BackColor = Color.FromArgb(252, 252, 252);

            tabPage.Controls.Add(grid);

            return tabPage;
        }

        private void UpdateRecentActivities()
        {
            // TODO: Veritabanından güncel aktivite verilerini al
            foreach (Control control in dashboardLayout.Controls)
            {
                if (control is PanelControl panel)
                {
                    foreach (Control child in panel.Controls)
                    {
                        if (child is XtraTabControl tabControl)
                        {
                            foreach (XtraTabPage tabPage in tabControl.TabPages)
                            {
                                if (tabPage.Controls.Count > 0 && tabPage.Controls[0] is GridControl grid)
                                {
                                    // Gerçek veri ile güncelle
                                    // var data = GetActivityData(tabPage.Text);
                                    // grid.DataSource = data;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void SetupRefreshTimer()
        {
            refreshTimer = new Timer();
            refreshTimer.Interval = 30000; // 30 saniye
            refreshTimer.Tick += RefreshDashboard;
            refreshTimer.Start();
        }

        private void RefreshDashboard(object sender, EventArgs e)
        {
            // Dashboard verilerini güncelle
            UpdateStatusCards();
            UpdateCharts();
            UpdateInfoWidgets();
            UpdateRecentActivities();
        }

        private void InitializeUserInfo()
        {
            if (Program.CurrentUser != null)
            {
                bar_UserInfo.Caption = $"Kullanıcı: {Program.CurrentUser.Username}";
                bar_ConnectionStatus.Caption = "Bağlantı: Aktif";
            }
        }

        private void InitializeEvents()
        {
            // Envanter İşlemleri
            btn_NewInventory.ItemClick += Btn_NewInventory_ItemClick;
            btn_InventoryList.ItemClick += Btn_InventoryList_ItemClick;

            // Personel İşlemleri
            btn_NewEmployee.ItemClick += Btn_NewEmployee_ItemClick;
            btn_EmployeeList.ItemClick += Btn_EmployeeList_ItemClick;

            // Bakım İşlemleri
            btn_NewMaintenance.ItemClick += Btn_NewMaintenance_ItemClick;
            btn_MaintenanceList.ItemClick += Btn_MaintenanceList_ItemClick;

            // Tanımlamalar
            btn_Categories.ItemClick += Btn_Categories_ItemClick;
            btn_Departments.ItemClick += Btn_Departments_ItemClick;

            // Ayarlar
            btn_Settings.ItemClick += Btn_Settings_ItemClick;
            btn_ChangePassword.ItemClick += Btn_ChangePassword_ItemClick;
            btn_Exit.ItemClick += Btn_Exit_ItemClick;
        }

        private void timer_Clock_Tick(object sender, EventArgs e)
        {
            bar_Clock.Caption = $"Saat: {DateTime.Now:HH:mm:ss}";
        }

        #region Button Click Events

        private void Btn_NewInventory_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Yeni Envanter formu açılacak");
        }

        private void Btn_InventoryList_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Envanter Listesi formu açılacak");
        }

        private void Btn_NewEmployee_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Yeni Personel formu açılacak");
        }

        private void Btn_EmployeeList_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Personel Listesi formu açılacak");
        }

        private void Btn_NewMaintenance_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Yeni Bakım Kaydı formu açılacak");
        }

        private void Btn_MaintenanceList_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Bakım Listesi formu açılacak");
        }

        private void Btn_Categories_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Kategoriler formu açılacak");
        }

        private void Btn_Departments_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Departmanlar formu açılacak");
        }

        private void Btn_Settings_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Ayarlar formu açılacak");
        }

        private void Btn_ChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            var changePassForm = new ChangePassForm(_userService, Program.CurrentUser.Id);
            changePassForm.ShowDialog();
        }

        private void Btn_Exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion

        private SimpleButton CreateQuickActionButton(string text, string icon, Color color)
        {
            var button = new SimpleButton
            {
                Text = text,
                Width = 150,
                Height = 70,
                Appearance = {
                    BackColor = color,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Regular)
                },
                LookAndFeel = {
                    UseDefaultLookAndFeel = false,
                    Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
                }
            };

            // Hover efekti
            button.MouseEnter += (s, e) => {
                button.Appearance.BackColor = Color.FromArgb(
                    (int)(color.R * 0.9),
                    (int)(color.G * 0.9),
                    (int)(color.B * 0.9)
                );
            };

            button.MouseLeave += (s, e) => {
                button.Appearance.BackColor = color;
            };

            // Click olayları
            button.Click += (s, e) => {
                switch (text)
                {
                    case "Demirbaş Ekle":
                        // TODO: Yeni demirbaş formu aç
                        break;
                    case "Çalışan Ekle":
                        // TODO: Yeni çalışan formu aç
                        break;
                    case "Demirbaş Atama":
                        // TODO: Demirbaş atama formu aç
                        break;
                    case "Lokasyon Ekle":
                        // TODO: Lokasyon ekleme formu aç
                        break;
                    case "Hızlı Sayım Başlat":
                        // TODO: Hızlı sayım işlemini başlat
                        break;
                }
            };

            return button;
        }

        private Control CreateInfoWidget(string title, Color color)
        {
            var widget = new PanelControl
            {
                Dock = DockStyle.Fill,
                BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple,
                LookAndFeel = { UseDefaultLookAndFeel = false, Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat }
            };

            var titlePanel = new PanelControl
            {
                Dock = DockStyle.Top,
                Height = 30,
                BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder,
                LookAndFeel = { UseDefaultLookAndFeel = false, Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat }
            };

            titlePanel.Appearance.BackColor = color;

            var titleLabel = new LabelControl
            {
                Text = title,
                Appearance = {
                    TextOptions = { HAlignment = HorzAlignment.Center },
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    ForeColor = Color.White
                },
                Dock = DockStyle.Fill,
                AutoSizeMode = LabelAutoSizeMode.None
            };

            var contentGrid = new GridControl
            {
                Dock = DockStyle.Fill
            };

            var gridView = new GridView(contentGrid);
            contentGrid.MainView = gridView;

            // Grid sütunlarını ayarla
            switch (title)
            {
                case "Bakım Süresi Gelen Demirbaşlar":
                    gridView.Columns.AddVisible("DemirbasAdi");
                    gridView.Columns.AddVisible("BakimTarihi");
                    break;
                case "SKT'si Geçmiş Ürünler":
                    gridView.Columns.AddVisible("UrunAdi");
                    gridView.Columns.AddVisible("SKT");
                    break;
                case "Son Yapılan İşlemler (Log)":
                    gridView.Columns.AddVisible("Islem");
                    gridView.Columns.AddVisible("Tarih");
                    break;
                case "Son Kullanıcı Girişleri":
                    gridView.Columns.AddVisible("Kullanici");
                    gridView.Columns.AddVisible("GirisTarihi");
                    break;
                case "Yaklaşan Kalibrasyon Tarihleri":
                    gridView.Columns.AddVisible("CihazAdi");
                    gridView.Columns.AddVisible("KalibrasyonTarihi");
                    break;
                case "Periyodik Bakım Tarihleri":
                    gridView.Columns.AddVisible("DemirbasAdi");
                    gridView.Columns.AddVisible("BakimTarihi");
                    break;
            }

            // Grid görünümünü özelleştir
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsView.ShowIndicator = false;
            gridView.OptionsView.ShowHorizontalLines = DefaultBoolean.False;
            gridView.OptionsView.ShowVerticalLines = DefaultBoolean.False;
            gridView.Appearance.Row.Font = new Font("Segoe UI", 9);
            gridView.RowHeight = 25;

            titlePanel.Controls.Add(titleLabel);
            widget.Controls.AddRange(new Control[] { contentGrid, titlePanel });

            return widget;
        }

        private void UpdateStatusCards()
        {
            // TODO: Veritabanından güncel değerleri al
            foreach (Control control in dashboardLayout.Controls)
            {
                if (control is FlowLayoutPanel panel)
                {
                    foreach (Control card in panel.Controls)
                    {
                        if (card is PanelControl && card.Controls.Count > 1)
                        {
                            var valueLabel = card.Controls[1] as LabelControl;
                            if (valueLabel != null)
                            {
                                // Gerçek veri ile güncelle
                                // valueLabel.Text = GetUpdatedValue(valueLabel.Parent.Controls[0].Text);
                            }
                        }
                    }
                }
            }
        }

        private void UpdateCharts()
        {
            // TODO: Veritabanından güncel değerleri al
            foreach (Control control in dashboardLayout.Controls)
            {
                if (control is PanelControl panel)
                {
                    foreach (Control chart in panel.Controls)
                    {
                        if (chart is ChartControl chartControl)
                        {
                            foreach (Series series in chartControl.Series)
                            {
                                // Gerçek veri ile güncelle
                                // series.Points.Clear();
                                // var updatedData = GetChartData(series.Name);
                                // foreach (var data in updatedData)
                                // {
                                //     series.Points.Add(new SeriesPoint(data.Key, data.Value));
                                // }
                            }
                        }
                    }
                }
            }
        }

        private void UpdateInfoWidgets()
        {
            // TODO: Veritabanından güncel widget verilerini al
            foreach (Control control in dashboardLayout.Controls)
            {
                if (control is TableLayoutPanel panel)
                {
                    foreach (Control widget in panel.Controls)
                    {
                        if (widget is PanelControl && widget.Controls.Count > 1)
                        {
                            var grid = widget.Controls[0] as GridControl;
                            if (grid != null)
                            {
                                // Gerçek veri ile güncelle
                                // var data = GetWidgetData(widget.Controls[1].Text);
                                // grid.DataSource = data;
                            }
                        }
                    }
                }
            }
        }
    }
}