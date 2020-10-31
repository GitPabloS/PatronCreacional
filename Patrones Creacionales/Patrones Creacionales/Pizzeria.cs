using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Creacionales
{
    public abstract class Pizzeria
    {
        public abstract Pizza CrearPizza(string tipo);
    }
}
