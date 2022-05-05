namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Interfaz IPrinter para definir un tipo IPrinter, este puede ser implementado por distintas clases
    /// cuya responsabilidad sea imprimir una recipe en algun lado, sin importar su destino.
    /// </summary>
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    }
}