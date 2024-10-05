using Daily_Project.Models;
using Microsoft.EntityFrameworkCore;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace Daily_Project.Data
{
    public class DBConnection: DbContext
    {



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=127.0.0.1;initial catalog=db_dailies_project;uid=root;pwd=123456", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.31-MariaDB"));

        }

    }
}
