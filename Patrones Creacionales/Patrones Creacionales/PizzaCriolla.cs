using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Creacionales
{
    class PizzaCriolla : Pizza
    {
        public PizzaCriolla(string origen)
        {
            _descripcion = "Pizza criolla";
            _origen = origen;
        }
    }
}
