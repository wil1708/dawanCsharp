using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_CodeFirstDetail
{
    public class MigrationHistoryTable
    {
        public string MigrationId { get; set; }
        public string ContextKey { get; set; }
        public byte[] Model { get; set; }
        public string ProductVersion { get; set; }

        public static void getMigrations()
        {
            string sql = "SELECT * FROM __MigrationHistory";
            MyContext context = new MyContext();
            DbRawSqlQuery<MigrationHistoryTable> migrations = context.Database.SqlQuery<MigrationHistoryTable>(sql);
            foreach (var item in migrations)
            {
                Console.WriteLine(item.MigrationId);
            }
           
        } 

    }
}
