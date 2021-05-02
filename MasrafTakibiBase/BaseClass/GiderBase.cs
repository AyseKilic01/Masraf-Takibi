﻿using MasrafTakibiBase.DataSets;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasrafTakibiBase.BaseClass
{
    
    public class GiderBase
    {
        SqlDataAdapter daMain = null;
        SqlConnection con = new SqlConnection(ConnectClass.getConnectionString());
        dsGider dsGider1 = new dsGider();
        public GiderBase()
        {
            Init();
        }
        private void Init()
        {
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;
            cmm.CommandText = "select a.id, a.code, a.explanation, a.gidertipi, a.vadetarih, a.pasif  from parGider a " +
                " left outer join parGiderTip b on b.id = a.gidertipi ";

            daMain = new SqlDataAdapter(cmm);
            CommandBuilderBase cb = new CommandBuilderBase();
            cb.AddField("id", SqlDbType.Int, 4, true);
            cb.AddField("code", SqlDbType.VarChar, 50);
            cb.AddField("gidertipi", SqlDbType.Int, 4);
            cb.AddField("explanation", SqlDbType.VarChar, 130);
            cb.AddField("vadetarih", SqlDbType.DateTime, 4);
            cb.AddField("pasif", SqlDbType.Bit, 0);
            cb.SqlTableName = "parGider";
            cb.Con = con;
            cb.CreateCommands(daMain);
        }
        public void LoadData()
        {
            daMain.Fill(dsGider1.gider);
        }
        public void SaveData()
        {
            daMain.Update(dsGider1.gider);
        }
        public Result Validate()
        {
            return new Result { BoolVal = true, StringVal = "" };
        }
    }
}
