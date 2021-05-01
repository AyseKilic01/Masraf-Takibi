using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasrafTakibiBase.BaseClass;
using MasrafTakibiBase.BaseTools;

namespace MasrafTakibi.Forms
{
    public partial class FrmFirmaTanim : Form
    {
        FirmaBase firma = null;
        public FrmFirmaTanim()
        {
            InitializeComponent();
            firma = new FirmaBase();
        }

        private void gridControlBase1_Load(object sender, EventArgs e)
        {
            firma.LoadData();
            gridControlBase1.DataSource = firma.dsFirma.Firma;
        }
    }
}
