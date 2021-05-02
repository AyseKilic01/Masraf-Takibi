using System;
using DevExpress.XtraBars;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;

namespace MasrafTakibiBase.BaseTools
{
    [ToolboxItem(true)]
    public partial class XtraBarBase : BarManager
    {
        public void AddBarItems(BarManager bm)
        {
            #region Main Menu Bar
            bm.BeginUpdate();
            BarSubItem bsiFile = new BarSubItem(bm, "&File");
            BarButtonItem bbiNew = new BarButtonItem(bm, "New");
            bbiNew.ImageUri.Uri = "New";
            BarButtonItem bbiOpen = new BarButtonItem(bm, "Open");
            bbiOpen.ImageUri.Uri = "Open";
            BarButtonItem bbiClose = new BarButtonItem(bm, "Close");
            bbiClose.ImageUri.Uri = "Close";
            bsiFile.AddItems(new BarItem[] { bbiNew, bbiOpen, bbiClose });
            bm.MainMenu.AddItem(bsiFile);
            bm.EndUpdate();
            #endregion
            #region Status Bar
            BarStaticItem bsiLinePos = new BarStaticItem()
            {
                Caption = "Line: 0 Position: 0",
                Alignment = BarItemLinkAlignment.Left,
                Width = 150,
                AutoSize = BarStaticItemSize.None,
                TextAlignment = System.Drawing.StringAlignment.Center
            };
            BarStaticItem bsiReady = new BarStaticItem()
            {
                Caption = "Ready",
                Alignment = BarItemLinkAlignment.Right,
                Width = 80,
                AutoSize = BarStaticItemSize.None,
                TextAlignment = System.Drawing.StringAlignment.Far,
                Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            };
            BarEditItem beiZoom = new BarEditItem(bm, new RepositoryItemZoomTrackBar())
            {
                EditWidth = 150,
                Alignment = BarItemLinkAlignment.Right
            };
            beiZoom.Edit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            bm.StatusBar.AddItems(new BarItem[] { bsiLinePos, beiZoom, bsiReady });
            #endregion
        }
    }
}
