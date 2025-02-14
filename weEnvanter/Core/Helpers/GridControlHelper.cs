﻿using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;

namespace weEnvanter.Core.Helpers
{
    public static class GridControlHelper
    {
        public static void CustomDrawEmptyForeground(object sender, CustomDrawEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.RowCount == 0)
            {
                string message = "Veri Bulunamadı";
                Font font = new Font("Tahoma", 10, FontStyle.Bold);
                RectangleF rect = new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
                e.Graphics.DrawString(message, font, Brushes.Gray, rect, new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                });
            }
        }
        public static void SetGridViewSettings(GridView gridView) 
        {
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView.FocusRectStyle = DrawFocusRectStyle.RowFullFocus;
            gridView.OptionsFind.AlwaysVisible = true;
            gridView.OptionsFind.FindNullPrompt = "Arama yapmak için metin giriniz..";
            gridView.OptionsFind.Condition = DevExpress.Data.Filtering.FilterCondition.Contains;
            gridView.OptionsFind.FindDelay = 100;
            gridView.OptionsFind.SearchInPreview = true;
            gridView.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            gridView.OptionsFind.HighlightFindResults = true;
        }
    }
}
