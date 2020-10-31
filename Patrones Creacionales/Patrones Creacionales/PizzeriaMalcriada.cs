using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Creacionales
{
    class PizzeriaMalcriada : Pizzeria
    {
        public override Pizza CrearPizza(string tipo)
        {
            if (tipo == "jamon")
            {
                return new PizzaCriolla("Malcriada");
            }
            else if (tipo == "criolla")
            {
                return new PizzaJamon("Malcriada");
            }
            else
            {
                return null;
            }
        }
    }
}
