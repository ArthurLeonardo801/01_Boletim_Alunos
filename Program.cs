using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BoletimAlunos
{
    class Program{
        static void Main(string[] args){
            const int TOTAL = 4;
            Boletim[] boletim = new Boletim[TOTAL];
            int i;
            for (i = 0; i<TOTAL; i++){             
                Console.WriteLine("Digite o nome do Aluno nº " + (i+1) + ": ");
                string name = Console.ReadLine();
                Console.WriteLine("Digite a primeira nota do Aluno: ");
                double nota1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a segundaa nota do Aluno: ");
                double nota2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a terceira nota do Aluno: ");
                double nota3 = double.Parse(Console.ReadLine());
                double media = (nota1 + nota2 + nota3) / 3;
                boletim[i] = new Boletim { Nome = name, Nota1 = nota1, Nota2 = nota2, Nota3 = nota3, Media = media };
                Console.Clear();
            }
            Console.WriteLine("NOTA FINAL \n" );
            for (i = 0; i < TOTAL; i++){
                Console.WriteLine("Aluno: " + boletim[i].Nome + "  Media: " + boletim[i].Media);                
            }
        }
    }
}
