using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno a1 = new Aluno();
            a1.setNome("Carlos");
            a1.setMatricula(123);
            a1.setEmail("carlos@gmail.com");

            Aluno a2 = new Aluno("Felipe");
            a2.setMatricula(567);
            a2.setEmail("Felipe@gmail.com");

            Aluno a3 = new Aluno("Fernando", 135, "fer2022@outlook.com");

            a1.imprimir();
            a2.imprimir();
            a3.imprimir();

            Console.ReadKey();
        }
    }
}
