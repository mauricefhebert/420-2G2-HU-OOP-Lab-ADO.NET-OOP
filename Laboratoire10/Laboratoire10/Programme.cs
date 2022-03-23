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
    internal class Programme
    {
        public int ProgrammesId { get; set; }
        public string ProgrammeName { get; set; }

        internal Programme(int programmesId, string programmeName)
        {
            this.ProgrammesId = programmesId;
            this.ProgrammeName = programmeName;
        }
    }
}
