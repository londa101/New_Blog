using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;


namespace Blog.UI.Tests.Pages.Article
{
    public class AccessExcelData <T> //T -модела който ще ползвам
    {
        public static string TestDataFileConnection(string FileName)
        {
            var path = ConfigurationManager.AppSettings["TestDataSheetPath"];
            var filename = FileName+".xlsx";
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties ='Excel 12.0; HDR=YES; IMEX=1;';", path + filename);

            return con;
        }

        public static T GetTestData(string FileName, string TabName, string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection(FileName)))
            {
                connection.Open();
                var query = string.Format("select * from [{0}$] where key = '{1}'", TabName, keyName);
                var value = connection.Query<T>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }
    }
}
