using EfCoreTriggersConsole.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EfCoreTriggersConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SampleDbContext())
            {
                //db.Users.Add(new User { Name = "Hasan", Surname = "Akpürüm" });
                
                var detail = db.Users.FirstOrDefault(f => f.Id == 2);
                detail.Name = "Hasan";
                detail.Surname = "Akpürüm Update";

                db.EnsureAutoHistory();
                db.SaveChanges();
            }
        }
    }
}
