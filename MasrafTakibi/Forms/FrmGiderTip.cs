using MasrafTakibiBase.BaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasrafTakibi.Forms
{
    public partial class FrmGiderTip : Form
    {
        GiderTipBase gidertip = null;
        public FrmGiderTip()
        {
            InitializeComponent();
            gidertip = new GiderTipBase();
        }

        private void gridControlBase1_Load(object sender, EventArgs e)
        {
            gidertip.LoadData();
            gridControlBase1.DataSource = gidertip.baseGiderTip.GiderTip;
        }
    }
}
