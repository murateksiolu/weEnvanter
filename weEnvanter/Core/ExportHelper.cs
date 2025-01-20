using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Windows.Forms;

namespace weEnvanter.Core
{
    public static class ExportHelper
    {
        public static void ExportToPdf(GridControl gridControl, string fileNamePrefix)
        {
            try
            {
                using (var saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "PDF Dosyası|*.pdf";
                    saveDialog.Title = "PDF Olarak Kaydet";
                    saveDialog.FileName = $"{fileNamePrefix}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        gridControl.ExportToPdf(saveDialog.FileName);
                        XtraMessageBox.Show("PDF dosyası başarıyla oluşturuldu.", "Bilgi", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"PDF dışa aktarılırken hata oluştu: {ex.Message}", 
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ExportToExcel(GridControl gridControl, string fileNamePrefix)
        {
            try
            {
                using (var saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "Excel Dosyası|*.xlsx";
                    saveDialog.Title = "Excel Olarak Kaydet";
                    saveDialog.FileName = $"{fileNamePrefix}_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        gridControl.ExportToXlsx(saveDialog.FileName);
                        XtraMessageBox.Show("Excel dosyası başarıyla oluşturuldu.", "Bilgi", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Excel dışa aktarılırken hata oluştu: {ex.Message}", 
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 