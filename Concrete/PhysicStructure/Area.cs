using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Drive_Desing.Concrete.PhysicStructure
{
    /// <summary>
    /// Modela un Area.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="PhysicStructure"/>.
    /// </remarks>
    public class Area : PhysicStructure
    {
        /// <summary>
        /// Identificador del sitio al que pertenece esta area.
        /// </summary>
        public int IdSite { get; set; }

        /// <summary>
        /// Celulas de proceso que pertenecen a esta area.
        /// </summary>
        public List<ProcessCell> ProcessCells { get; set; }
    }
}
