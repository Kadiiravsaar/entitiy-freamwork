using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitiy
{
    public class UrunContext : DbContext
    {
        public UrunContext() : base("urunConnection")
        {

        }
        public DbSet<Kategori> kategoriler { get; set; }
        public DbSet<Urun> urunler { get; set; }
    }
}
