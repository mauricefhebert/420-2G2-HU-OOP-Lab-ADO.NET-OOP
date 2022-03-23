using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Maurice filiatreault hebert
 * 2195109
 */
namespace Laboratoire10
{
    internal class EtudiantGrid
    {
        public int EtudiantId { get; set; }
        public string ProgrammeName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime BirthDay { get; set; }
        public char Gender { get; set; }
        public EtudiantGrid(int etudiantId, string firstName, string lastName, string address, DateTime birthDay, char gender, string programmeName)
        {
            EtudiantId = etudiantId;
            ProgrammeName = programmeName;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            BirthDay = birthDay;
            Gender = gender;
        }
    }
}
