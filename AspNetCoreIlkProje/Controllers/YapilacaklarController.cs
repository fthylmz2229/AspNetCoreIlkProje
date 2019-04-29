using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreIlkProje.Models;

namespace AspNetCoreIlkProje.Controllers
{
    [Route("api/[controller]")]
    public class YapilacaklarController : ControllerBase
    {
        private readonly YapilacaklarIcerik _icerik;

        public YapilacaklarController(YapilacaklarIcerik icerik)
        {
            _icerik = icerik;

            if (_icerik.YapilacaklarListe.Count()>0)
            {
                _icerik.YapilacaklarListe.Add(new Yapilacaklar { YapilacakIs = "1. iş" });
                _icerik.SaveChanges();
            }
        }
    }
}
