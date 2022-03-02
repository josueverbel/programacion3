using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion3.Data
{
    public abstract class Person
    {
        public  Person(int armNumber, int legNumber, int noseNumber, int eyesNumber, int mouthNumber, bool isTeacher)
        {
            ArmNumber = armNumber;
            LegNumber = legNumber;
            MouthNumber = mouthNumber;
            EyesNumber = eyesNumber;
            NoseNumber = noseNumber;
            IsTeacher = isTeacher;
        }
        public int Id { get; set; }
        public  DateTime DateOfBird { get; set; }

        public string FirstName { get; set; }
        public bool IsTeacher { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }

        public int LegNumber { get; set; }
        public int ArmNumber { get; set; }
        public int NoseNumber { get; set; }
        public int MouthNumber { get; set; }
        public int EyesNumber { get; set; }
        public void Run()
        {
            //Acciones
        }

        public void ToEat()
        {
            ///
        }

    }
}
