using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetCoreIlkProje.Models;

namespace AspNetCoreIlkProje.Models
{
    public class YapilacaklarIcerik : DbContext
    {
        public YapilacaklarIcerik(DbContextOptions<YapilacaklarIcerik> ayarlar):base(ayarlar)
        {

        }

        public DbSet<Yapilacaklar> YapilacaklarListe { get; set; }
    }
}
