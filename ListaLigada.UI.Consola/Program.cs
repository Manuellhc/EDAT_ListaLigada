using System.ComponentModel.Design;
using System.Runtime.CompilerServices;


using ListaLigada.Logica;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista Ligada Simple");
        

        var singleList= new SingleList<String>();
        int opc = 0;
        do
        {
            opc = Menu();
            switch (opc)
            {
                case 1:
                    AgregarElemento();
                  break;

                case 2:
                    MostrarLista();
                 break;
                
                default: Console.WriteLine("Opc invalida");
                    break;
            }

        } while (opc !=0);

        Console.WriteLine(singleList);
        Console.ReadKey();//Termina el main


        void AgregarElemento()
        {
            Console.WriteLine("Escribe el nombre del nodo: ");
            var data = Console.ReadLine();
            singleList.Add(data);
            
        }
        void MostrarLista()
        {
            Console.WriteLine("La lista es: \n");
            Console.WriteLine(singleList);
        }
    }

   

    private static int Menu()
    {
        Console.WriteLine("Menu \n");
        Console.WriteLine("1.- Agregar elemento ");
        Console.WriteLine("2.- Mostrar la lista ");
        Console.WriteLine("0.- Salir\n");
        bool Esvalido = false;
        
        int opc=0;
        do
        {
            Console.Write("Elige la opcion deseada:     \n");
            var opcCapturada=Console.ReadLine();
            if (!int.TryParse(opcCapturada, out opc)|| opc<0 || opc>2)
            {
                Console.WriteLine("Ingrese una opcion valida");
                Esvalido=false;
            }
            else
            {
                Esvalido=true;
            }
            
           
        } while (Esvalido==false);
        return opc;
    }
}