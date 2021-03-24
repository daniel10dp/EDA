﻿using System;

namespace Daniel_Atv4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            ArvoreBinaria arvoreBIN = new ArvoreBinaria();
            ArvoreAVL arvoreAVL = new ArvoreAVL();

            Console.WriteLine();

            Console.WriteLine("Árvore Binária:");

            arvoreBIN.Inserir(10);   
            arvoreBIN.Inserir(2);  
            arvoreBIN.Inserir(54);  
            arvoreBIN.Inserir(46);  
            arvoreBIN.Inserir(58);   
            arvoreBIN.Inserir(489);   
            arvoreBIN.Inserir(20); 
            arvoreBIN.Exibir();     

            arvoreBIN.Remover(489);  
			arvoreBIN.Exibir();     

            // Exprexão de Complexidade Caso Médio: O(n)+ O(log n)
           // Exprexão de Complexidade Pior Caso: O(n)

            Console.WriteLine("Árvore AVL:");

            arvoreAVL.Inserir(16);      
            arvoreAVL.Inserir(78);      
            arvoreAVL.Inserir(123);      
            arvoreAVL.Exibir();         

            arvoreAVL.Inserir(52);    
            arvoreAVL.Inserir(25);      
            arvoreAVL.Inserir(86);      
            arvoreAVL.Exibir();        

            arvoreAVL.Remover(87);      
            arvoreAVL.Remover(12);      
            arvoreAVL.Exibir();         

            // Exprexão de Complexidade Caso Médio: O(n)+ O(log n)
             // Exprexão de Complexidade Pior Caso: O(n)+ O(log n)


        }
    }
}
