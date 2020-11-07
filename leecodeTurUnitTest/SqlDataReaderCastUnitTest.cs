using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Xunit;

namespace leecodeTurUnitTest
{
    public class SqlDataReaderCastUnitTest
    {
        public class AssetDigitTypeDetail
        {
            public Guid Id { get; set; }
            public Guid ParentId { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
            public int Level { get; set; }
            public int ScrapTime { get; set; }
        }
        [Fact]
        public void test()
        {
            string connectionStr = string.Format($"Data Source=192.168.17.77;Initial Catalog=H3Cloud;Persist Security Info=True;User ID=sa;Password=sql2005!@#$;MultipleActiveResultSets=true;pooling=true;min pool size=5;max pool size=512;connect timeout = 20;");

            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            string sql = string.Format(@"SELECT
	                                    Id,
	                                    ParentId,
	                                    Code,
	                                    Name,
	                                    [Level],
	                                    ScrapTime 
                                    FROM
	                                    AssetDigitType 
                                    WHERE
	                                    Deleted =0");
            var command = connection.CreateCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            var reader = command.ExecuteReader();


            connection.Close();
        }
    }
}
