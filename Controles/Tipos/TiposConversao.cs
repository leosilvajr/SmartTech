using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles.Tipos
{
    public class TiposConversao
    {
    }
    public class Converter
    {
        private static Converter instancia;

        private Converter()
        {

        }
        public static Converter GetInstancia
        {
            get { return instancia = instancia ?? new Converter(); }
        }

    }
}
