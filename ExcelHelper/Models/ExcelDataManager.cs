using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExcelHelper.Models
{
    public class ExcelDataManager
    {
        public static List<UserInfo> GetUserInfos()
        {
            return  ExcelDataServer.GetUserInfos();
        }
    }
}