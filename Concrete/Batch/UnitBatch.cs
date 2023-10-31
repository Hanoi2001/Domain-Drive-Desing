using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Drive_Desing.Concrete.Batch
{
    /// <summary>
    /// Modela un lote de unidad.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="Batch"/>
    /// </remarks>
    public class UnitBatch : Batch
    {
        /// <summary>
        /// Identificador unico de la unidad asociada.
        /// </summary>
        public int IdUnit { get; set; }

        /// <summary>
        /// Identificador unico del procedimiento de unidad asociada.
        /// </summary>
        public int IdUnitProcedure { get; set; }
    }
}
