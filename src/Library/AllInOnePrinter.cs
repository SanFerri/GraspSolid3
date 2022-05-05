//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// AllInOnePrinter tiene dos bloques condicionales, uno para Destination.Console y 
    /// otro para Destination.File, esto no es correcto porque no cumple con el patron
    /// Polymorfism, ya que un codigo que varia segun cierto valor, en este caso el destino
    /// , deberia estar implementado en 2 clases por una abstraccion, en este caso dicha abstraccion
    /// sera IPrinter, implementada por ConsolePrinter y FilePrinter.
    /// </summary>
    /*
    public enum Destination
    {
        Console,
        File
    }
    */
    /*
    public class AllInOnePrinter
    {
        public void PrintRecipe(Recipe recipe, Destination destination)
        {
            if (destination == Destination.Console)
            {
                Console.WriteLine(recipe.GetTextToPrint());
            }
            else
            {
                File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
            }
        }
    }
    */
}