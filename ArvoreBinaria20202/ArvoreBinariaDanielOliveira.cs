using System;
using System.Collections.Generic;

namespace ArvoreBinaria
{
    public class ArvoreBinariaDanielOliveira : ArvoreBinaria
    {
        public bool Inserirpercurso(List<int> pre_ordem, List<int> em_ordem){

            while(pre_ordem.Count != 0) {
                Inserir(pre_ordem [0]);
                int aux = pre_ordem[0];
                pre_ordem.RemoveAt(0);

                int k = 0;
                foreach(int c in em_ordem){
                     if(c == aux){
                         em_ordem.RemoveAt(k);
                         break;
                     }
                     else k++;
                }
            }

            if(pre_ordem.Count == 0 && em_ordem.Count == 0){
                    Console.WriteLine("\n O percurso foi inserido!\n");
                    return true;
            }else   return false;
            

        }


    } 
}