using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SindikatAnkete.Entity
{
    public class PopunjenaAnketaEntity
    {
        public int AnketaId { get; set; }
        public string KorisnikId { get; set; }
        public AnketaEntity Anketa { get; set; }
        //public ICollection<OdgovorEntity>Odgovori { get; set;}
    }
}
