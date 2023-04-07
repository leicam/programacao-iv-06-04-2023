using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Primeiro.Trimestre
{
    /// <summary>
    /// palavra reservada sealed limita o nivel de abstração
    /// que uma classe tem
    /// </summary>
    internal sealed class HyundaiI30 : AbstractCarro
    {
        public HyundaiI30() : base("Hyundai", "i30") { }
    }
}