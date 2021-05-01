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
   public class FirmaBase
    {
        SqlDataAdapter daMain = null;
        dsFirma dsFirm1 = new dsFirma();
        SqlConnection consql = new SqlConnection(ConnectClass.getConnectionString());
        public FirmaBase()
        {
            Init();
        }
        public dsFirma dsFirma { get { return dsFirm1; } }
        private void Init()
        {
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = consql;
            cmm.CommandText = "select a.id, a.kod, a.aciklama, a.pasif  from parFirma a ";

            daMain = new SqlDataAdapter(cmm);
            CommandBuilderBase cb = new CommandBuilderBase();
            cb.AddField("id", SqlDbType.Int, 4, true);
            cb.AddField("kod", SqlDbType.VarChar, 50);
            cb.AddField("aciklama", SqlDbType.VarChar, 130);
            cb.AddField("pasif", SqlDbType.Bit, 0);
            cb.SqlTableName = "parFirma";
            cb.Con = consql;
            cb.CreateCommands(daMain);
        }

        public void LoadData()
        {
            daMain.Fill(dsFirm1.Firma);
        }
        public void SaveData()
        {
            daMain.Update(dsFirm1.Firma);
        }
        public Result Validate()
        {
            return new Result { BoolVal = true, StringVal = "" };
        }
    }
}
