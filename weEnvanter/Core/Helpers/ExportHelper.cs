using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.Windows.Forms;

namespace weEnvanter.Core.Helpers
{
    public static class ExportHelper
    {
        public static void ExportToExcel(GridControl grid, string defaultFileName = "Export")
        {
            try
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
                    saveDialog.FileName = $"{defaultFileName}_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        grid.ExportToXlsx(saveDialog.FileName);
                        if (MessageBox.Show("Dosya başarıyla kaydedildi. Açmak ister misiniz?", "Export", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(saveDialog.FileName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Export işlemi sırasında hata oluştu: {ex.Message}", "Hata", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ExportToPdf(GridControl grid, string defaultFileName = "Export")
        {
            try
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "PDF Dosyası (*.pdf)|*.pdf";
                    saveDialog.FileName = $"{defaultFileName}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        grid.ExportToPdf(saveDialog.FileName);
                        if (MessageBox.Show("Dosya başarıyla kaydedildi. Açmak ister misiniz?", "Export", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(saveDialog.FileName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Export işlemi sırasında hata oluştu: {ex.Message}", "Hata", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 