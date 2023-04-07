using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Primeiro.Trimestre
{
    /// <summary>
    /// modificadores de acesso
    /// internal: visivel somente dentro do assembly
    /// protected: visivel apenas pela classe que herda
    /// public: visivel por todos
    /// private: visivel apenas na classe
    /// </summary>
    internal abstract class AbstractCarro
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }

        protected AbstractCarro(string marca, string modelo)
        {
            Marca = marca 
                ?? throw new ArgumentNullException(nameof(marca));

            Modelo = modelo
                ?? throw new ArgumentNullException(nameof(modelo));
        }

        public override string ToString()
        {
            return $"{Marca} {Modelo}";
        }
    }
}
