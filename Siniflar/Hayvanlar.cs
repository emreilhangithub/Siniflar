using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    class Hayvanlar : ICanlilar
    {
        public string Test { get; set; }
        public int Id { get; set; }
        public string Tur { get; set; }
        public string Cinsi { get; set; }
    }
}
