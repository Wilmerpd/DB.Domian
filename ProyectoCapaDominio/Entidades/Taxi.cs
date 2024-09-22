using DB.Domian.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Domian.Entidades
{
    public class Taxi : BaseEntity
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
    }
}
