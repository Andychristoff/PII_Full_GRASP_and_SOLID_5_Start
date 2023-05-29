using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IPrintcontent printcontent)
        {
            File.WriteAllText("Recipe.txt", printcontent.GetTextToPrint());
        }
    }
}