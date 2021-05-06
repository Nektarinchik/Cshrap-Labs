using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphism
{
    sealed class Contact : Initials
    {
        public Contact(string surname, string name, string patronymic, int phone) : base(surname, name, patronymic)
        {
            this.phone = phone;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Phone number - {phone}");
        }

        private int phone;

    }
}
