  
using System;
using System.Collections.Generic;

namespace ATV3
{
    class Program
    {
        static void Main(string[] args)
        {
             Percurso New = new Percurso();

			List<int> pre = new List<int> {10, 20, 15, 5, 30, 35, 50}; // PreOrdem
			List<int> em  = new List<int> { 31, 23, 40, 48, 55, 60, 90,}; // EmOrdem

            bool vazio = New.Inserirpercurso(pre, em);

			if(vazio){
                New.Exibir();
                Console.WriteLine("\tAs listas esta vazia!\n");
            
            }

        }
    }
}
