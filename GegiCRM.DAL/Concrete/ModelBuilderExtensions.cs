using GegiCRM.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.DAL.Concrete
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            ////User
            //modelBuilder.Entity<User>()
            //    .HasData(
            //       new User
            //       {
            //           Id = 1,
            //           Name = "Yigit",
            //           Surname = "Genc",
            //           AddedBy = 1,
            //           ModifiedBy = 1,
            //           Email = "yigit.genc@gegi.com.tr",
            //           PassHash = "hash1"
            //       }
            //);
        }
    }

}
