using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Primeiro.Trimestre
{
    /// <summary>
    /// o C# <= 6.0 não permite a criação de 
    /// um metodo contrutor vazio em uma struct 
    /// quando ela possui um construturor que recebe parametros
    /// </summary>
    internal struct GPS
    {
        public int Latitude;
        public int Longitude;

        public GPS()
        {

        }

        public GPS(int latitude, int longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}