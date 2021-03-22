using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universum
{

    interface IUnivers
    {
        string Name { get; set; }
        string Massage { get; set; }
        void Massageservice();
    }
}
