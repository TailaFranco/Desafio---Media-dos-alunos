using System;

namespace Desafio___Media_dos_alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            float[]  notas = new float[4];
            float[] medias = new float[10];
            float mediag;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Escreva um nome: ");
            nomes[i] = Console.ReadLine();

            for (int x = 0; x < 4; x++)
            {
                Console.WriteLine("Digite a "+(x+1)+"º nota: ");
                notas[x] = float.Parse(Console.ReadLine());
            }
        medias[i]= (notas[0]+notas[1]+notas[2]+notas[3])/4;
        
        
        }
        

         for (int i = 0; i < 10; i++)
         {
             Console.WriteLine($"Nome: {nomes[i]} \n Média individual: {medias[i]}");
             
             
             if(medias[i]>=7)
        {
            Console.WriteLine("Aluno Aprovado"); 
        }
        
        else{
            Console.WriteLine("Aluno Reprovado");
            
        }
         }

         
         mediag = (medias[0] + medias[1] + medias[2]+ medias[3]+ medias[4] + medias[5]+ medias[6]+ medias[7]+ medias[8]+ medias[9])/10;
         Console.WriteLine("Media geral da turma: "+mediag);
                 
        }
    }
}
