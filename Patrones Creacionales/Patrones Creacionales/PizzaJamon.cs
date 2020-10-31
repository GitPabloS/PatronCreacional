using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Creacionales
{
    class PizzaJamon : Pizza
    {
        public PizzaJamon(string origen)
        {
            _descripcion = "Pizza de jamon queso";
            _origen = origen;
        }
    }
}
