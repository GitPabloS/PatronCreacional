using System;


namespace Patrones_Creacionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzeria pizzeria;
            Pizza pizza;

            pizzeria = new PizzeriaElPadrino();

            pizza = pizzeria.CrearPizza("jamon");
            pizza.Render();
            pizza = pizzeria.CrearPizza("criolla");
            pizza.Render();

            pizzeria = new PizzeriaMalcriada();
            pizza = pizzeria.CrearPizza("jamon");
            pizza.Render();
            pizza = pizzeria.CrearPizza("criolla");
            pizza.Render();
            Console.ReadKey();
        }
    }
}
