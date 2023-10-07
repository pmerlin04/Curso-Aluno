using ExercicioConjunto2.Entities;


namespace ExercicioConjunto2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Em um portal de cursos online, cada usuário possui um código único, representado porum número inteiro.
            Cada instrutor do portal pode ter vários cursos, sendo que um mesmo aluno pode sematricular em quantos cursos quiser. Assim, o número total de alunos de um instrutor nãoé simplesmente a soma dos alunos de todos os cursos que ele possui, pois pode haveralunos repetidos em mais de um curso.
            O instrutor Alex possui três cursos A, B e C, e deseja saber seu número total de alunos.
            Seu programa deve ler os alunos dos cursos A, B e C do instrutor Alex, depois mostrar aquantidade total e alunos dele, conforme exemplo.
            */

            //instanciando o obj Students com um  conjunto de HashSet
            HashSet<Students> student = new HashSet<Students>();

            Console.Write("How many students for course A: ");
            int nA = int.Parse(Console.ReadLine());
            for(int i =1;i<=nA;i++)
            {
                int aluno = int.Parse(Console.ReadLine());  
                student.Add(new Students { Number = aluno });
            }


            Console.Write("How many students for course B: ");
            int nB = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nB; i++)
            {

                int aluno = int.Parse(Console.ReadLine());
                student.Add(new Students { Number = aluno });
            }


            Console.Write("How many students for course C: ");
            int nC = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nC; i++)
            {
                int aluno = int.Parse(Console.ReadLine());
                student.Add(new Students { Number = aluno });
            }

            Console.WriteLine("total students: " + student.Count);

        }
    }
}
