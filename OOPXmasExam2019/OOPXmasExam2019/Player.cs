using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPXmasExam2019
{
    public enum Position { Goalkeeper, Defender, Midfielder, Forward }
    public class Player
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public Position PreferedPosition { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }


        public Player(string firstName, string lastName, Position position, DateTime dateOfBirth, int age)
        {
            FirstName = firstName;
            Surname = lastName;
            PreferedPosition = position;
            DateOfBirth = dateOfBirth;
            Age = age;
        }
        

        public override string ToString()
        {
            return string.Format("{0 } {1 } {2 } {3}", FirstName, Surname, Age, PreferedPosition);
        }


    }
}
