using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    interface ICanlilar
    {
        int Id { get; set; }
        string Tur { get; set; }
        string Cinsi { get; set; }
    }
}
