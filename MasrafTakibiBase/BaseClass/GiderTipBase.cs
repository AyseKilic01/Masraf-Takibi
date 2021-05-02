using MasrafTakibiBase.DataSets;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasrafTakibiBase.BaseClass
{
   public class GiderTipBase
    {
        SqlDataAdapter daMain = null;
        //connectstring 
        SqlConnection con = new SqlConnection(ConnectClass.getConnectionString());
        dsGiderTip dsGiderTip1 = new dsGiderTip();
        public GiderTipBase()
        {
            Init();
        }
        public dsGiderTip baseGiderTip { get { return dsGiderTip1; } }
        private void Init()
        {
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;
            cmm.CommandText = "select a.id, a.code, a.explanation, a.pasif  from parGiderTip a ";

            daMain = new SqlDataAdapter(cmm);
            CommandBuilderBase cb = new CommandBuilderBase();
            cb.AddField("id", SqlDbType.Int, 4, true);
            cb.AddField("code", SqlDbType.VarChar, 50);
            cb.AddField("explanation", SqlDbType.VarChar, 130);
            cb.AddField("pasif", SqlDbType.Bit, 0);
            cb.SqlTableName = "parGiderTip";
            cb.Con = con;
            cb.CreateCommands(daMain);
        }
        public void LoadData()
        {
            daMain.Fill(dsGiderTip1.GiderTip);
        }
        public void SaveData()
        {
            daMain.Update(dsGiderTip1.GiderTip);
        }
        public Result Validate()
        {
            return new Result { BoolVal = true, StringVal = "" };
        }
    }
}
