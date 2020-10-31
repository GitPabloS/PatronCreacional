using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Creacionales
{
    class PizzeriaElPadrino : Pizzeria
    {
        public override Pizza CrearPizza(string tipo)
        {
            if (tipo == "jamon")
            {
                return new PizzaCriolla("El Padrino");
            }
            else if (tipo == "criolla")
            {
                return new PizzaJamon("El Padrino");
            }
            else
            {
                return null;
            }
        }
    }
}
