using System;
namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// ConsolePrinter fue agregado para dejar de depender del destino, en vez de que halla
    /// una variable destino que varie entre File y Console que sean 2 clases que implementen
    /// un tipo IPrinter, con un método PrintRecipe, para así hacer de ese un método polimórfico, que sirva
    /// con 2 clases de distinto tipo (ConsolePrinter y FilePrinter) que implementan IPrinter.
    /// </summary>
    public class ConsolePrinter : IPrinter
    {
        // Recibe como parametro recipe para que este nos devuelta su texto a imprimir.
        public void PrintRecipe(Recipe recipe)
        {
            // Imprimimos en consola.
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}