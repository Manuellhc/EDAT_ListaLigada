using System.Runtime.CompilerServices;


using ListaLigada.Logica;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista Ligada Simple");
        

        var singleList= new SingleList<String>();

        singleList.Add("Alondra");
        singleList.Add("Karla");
        singleList.Add("Jan");
        singleList.Add("Luis");
        singleList.Add("Jose");

        Console.WriteLine(singleList);
        Console.ReadKey();
    }
}