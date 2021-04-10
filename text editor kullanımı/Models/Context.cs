using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace text_editor_kullanımı.Models
{
    public class Context :DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-VLDSRET;database=texteditor; integrated security=true");
        }

        public DbSet<Makale> makale { get; set; }

    }
}
