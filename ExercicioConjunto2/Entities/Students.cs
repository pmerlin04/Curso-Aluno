using System;

namespace ExercicioConjunto2.Entities
{
    internal class Students
    {
        public int Number { get; set; }


        //verifica se o aluno é o mesmo pelo numero de matrícula
        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            //verifica se o obj é um tipo Students
            if (!(obj is Students))
            {
                return false;
            }
            Students other = obj as Students;
            return Number.Equals(other.Number);
        }
    }
}
