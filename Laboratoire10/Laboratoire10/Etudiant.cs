using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire10
{
    internal class Etudiant
    {
        public int EtudiantId { get; set; }
        public int FK_ProgrammesId  { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime BirthDay { get; set; }
        public char Gender { get; set; }
        public Etudiant(int etudiantId, string firstName, string lastName, string address, DateTime birthDay, char gender, int fK_ProgrammesId)
        {
            EtudiantId = etudiantId;
            FK_ProgrammesId = fK_ProgrammesId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            BirthDay = birthDay;
            Gender = gender;
        }
    }
}
