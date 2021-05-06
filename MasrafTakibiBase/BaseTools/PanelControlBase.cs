using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasrafTakibiBase.BaseClass;

namespace MasrafTakibiBase.BaseTools
{
    public partial class PanelControlBase : PanelControl
    {
        public PanelControlBase()
        {
            InitializeComponent();
        }
        SimpleButton simple = new SimpleButton();
        ItemClass item = new ItemClass();
        public void Save()
        {
            item.gridView.UpdateCurrentRow();
        }
        public void SaveClose()
        {
            item.gridView.UpdateCurrentRow();
        }
        public void Close()
        {

        }
    }
}
