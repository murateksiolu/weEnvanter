using DevExpress.DataAccess.Sql;
using DevExpress.XtraBars.ToastNotifications;
using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Core.Helpers;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;
using static weEnvanter.Core.Helpers.ToastNotificationHelper;

namespace weEnvanter.UI.Forms.UsersForms
{
    public partial class UserListForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUserService _userService;
        private readonly ToastNotificationsManager _toastNotificationsManager;

        public UserListForm()
        {
            InitializeComponent();
            _userService = Program.ServiceProvider.GetRequiredService<IUserService>();

            // Toast Notification Manager'ı başlat
            _toastNotificationsManager = ToastNotificationHelper.CreateManager(components);

            GridControlHelper.SetGridViewSettings(gridView_Users);
            BarManagerHelper.SetBarManagerSettings(barManager1);

            LoadDataAsync();
        }
        private async void LoadDataAsync()
        {
            sqlDataSource1.ConnectionName = "WeEnvanterRemoteConnection";
            await sqlDataSource1.FillAsync(); // Asenkron doldurma
            gridControl_Users.DataSource = sqlDataSource1; // Doldurma tamamlandıktan sonra grid'e bağla
            gridView_Users.PopulateColumns();
        }
        private void gridView_Users_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Cursor.Position);
            }
        }

        private void btn_AddNewUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (var addUserForm = new AddOrEditUserForm(OperationType.Add))
                {
                    if (addUserForm.ShowDialog() == DialogResult.OK)
                    {
                        gridControl_Users.RefreshDataSource();
                        _toastNotificationsManager.ShowSuccess("Kullanıcı başarıyla eklendi.");
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Kullanıcı eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_RefreshDataSource_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                gridControl_Users.RefreshDataSource();
                _toastNotificationsManager.ShowSuccess("Veriler başarıyla yenilendi.");
            }
            catch (Exception ex)
            {
                _toastNotificationsManager.ShowError("Veriler yenilenirken bir hata oluştu.");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btn_ExportPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Core.Helpers.ExportHelper.ExportToPdf(gridControl_Users, "weEnvanter_Kullanıcılar");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("PDF oluşturulurken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ExportXLSX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Core.Helpers.ExportHelper.ExportToExcel(gridControl_Users, "weEnvanter_Kullanıcılar");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Excel dosyası oluşturulurken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bar_EditUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var selectedUserId = (int)gridView_Users.GetFocusedRowCellValue("Id");
                if (selectedUserId > 0)
                {
                    using (var editUserForm = new AddOrEditUserForm(OperationType.Update, selectedUserId))
                    {
                        if (editUserForm.ShowDialog() == DialogResult.OK)
                        {
                            gridControl_Users.RefreshDataSource();
                            _toastNotificationsManager.ShowSuccess("Kullanıcı başarıyla güncellendi.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Kullanıcı güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void bar_DeleteUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var selectedUserId = (int)gridView_Users.GetFocusedRowCellValue("Id");
                if (selectedUserId > 0)
                {
                    if (XtraMessageBox.Show("Seçili kullanıcıyı silmek istediğinize emin misiniz?", "Onay", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        await _userService.DeleteAsync(selectedUserId);
                        gridControl_Users.RefreshDataSource();
                        _toastNotificationsManager.ShowSuccess("Kullanıcı başarı ile silindi.");
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Kullanıcı silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bar_ShowHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}