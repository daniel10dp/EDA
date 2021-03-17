using System;
using System.Diagnostics;

namespace ATV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Stopwatch stopwatch = new Stopwatch();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            stopwatch.Start();
            if (contador==0){

            while( contador<1000 )//O(n)
            {

                Console.WriteLine("Rodando o while com 1000 iterações");
                contador=contador+1;
            }
            }else{contador=0;}
            
            int cont = 0;
            if (cont==0){
            while(cont<5000)//O(n)
            {
                Console.WriteLine("Rodando o while com 5000 iterações");
                cont=cont+1;
            }
            }else {cont=0;}
            int cont1=0;
            if (cont1==0){
            do{
                Console.WriteLine("Rodando o do while com 1000 iterações");
                cont1 = cont1 + 1;
            }while(cont1<1000);//O(n)
            }else{cont1=0;}
            int cont2=0;
            if(cont2==0){
            do{
                Console.WriteLine("Rodando o do while com 5000 iterações");
                cont2 = cont2 + 1;
            }while(cont2<5000);//O(n)
            }else{cont2=0;}
            int[] v1 = new int[1000] ; int[] v2 = new int[5000];
            
            for(int cont3=0; cont3<1000; cont3++)//O(n)
            {
                Console.WriteLine("Rodando o for com 1000 iterações");
                v1[cont3]=cont3; 
            }
            for(int cont4=0; cont4<5000; cont4++)//O(n)
            {
                Console.WriteLine("Rodando o for com 5000 iterações");
                v2[cont4]=cont4;
            }
            
            foreach(int numero in v1){
               Console.WriteLine("Rodando o foreach com 1000 iterações"); //O(n)
            }
            foreach(int numero in v2){
               Console.WriteLine("Rodando o foreach com 5000 iterações"); //O(n)
            }

             int[] OrdenacaoquickSort(int[] vetor){
            int inicio = 0;
            int fim = vetor.Length - 1;
            quickSort(vetor, inicio, fim);
            if(vetor.Length.Equals(1000)) Console.WriteLine("\nVetor1 Ordenado ");
            else                          Console.WriteLine("\nVetor2 Ordenado ");
            return vetor;
        }
        static void quickSort(int[] vetor, int inicio, int fim){//O(nlogn)
            if (inicio < fim){
                int p = vetor[inicio];
                int i = inicio + 1;
                int f = fim;
                while (i <= f){
                    if (vetor[i] <= p){
                        i++;
                    }
                    else if (p < vetor[f]){
                        f--;
                    }
                    else{
                        int troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                    }
                }
                vetor[inicio] = vetor[f];
                vetor[f] = p;
                quickSort(vetor, inicio, f - 1);
                quickSort(vetor, f + 1, fim);
                
            }
        }
        OrdenacaoquickSort(v1);

         int[] buscabin (int[] vetor){//O(log n)
            int x = 10;
            int sup = vetor.Length - 1;
            busca_binaria(vetor, x, sup);
            if(vetor.Length.Equals(1000)) Console.WriteLine("\nbusca feita no vetor 1 ");
            else                          Console.WriteLine("\nbusca feita no vetor 2 ");
            return vetor;
        }
        static void busca_binaria(int[] vetor, int x, int sup){
            int inf, m, achou=0;
	        inf = 0;

while (inf <= sup) {
    m = (inf + sup )/2;

    	if (vetor[m] == x){
        Console.WriteLine("o numero foi encontrado no indice {0}\n",m);
        achou=1;
        }
       	if (x > vetor[m]){
            inf = m+1;
    	}
    	else {
        sup = m-1;
   	 	}
    }
    if (achou!=1){
           Console.WriteLine ("O Valor nao foi encontrado\n");
       }


        }
        buscabin(v2);
        watch.Stop();
            Console.WriteLine("\nTempo de execução: {0}\n", watch.Elapsed);
        }
    }
}
