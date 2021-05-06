using System;

namespace Polimorphism
{
    public class Initials
    {
        public Initials(string surname, string name, string patronymic)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Initials - {surname} {name} {patronymic}");
        }

        protected string surname;

        protected string name;

        protected string patronymic;
    }
}
