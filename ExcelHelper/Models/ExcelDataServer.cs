using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;

namespace ExcelHelper.Models
{
    public class ExcelDataServer
    {
        public static List<UserInfo> GetUserInfos()
        {
           
            string sql = "SELECT * FROM AA";

            DataSet ds = ExcelHelperDB.GetReader(sql);

            List<UserInfo> list = new List<UserInfo>();

            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                UserInfo info = new UserInfo();
                info.ID = Convert.ToInt32(dr[0]);
                info.Name = Convert.ToString(dr[1]);
                info.Age = Convert.ToInt32(dr[2]);
                list.Add(info);
            }

            return list;
        }
    }
}