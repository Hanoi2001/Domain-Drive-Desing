using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Drive_Desing.Concrete.Batch
{
    /// <summary>
    /// Modela un lote de celula de proceso.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="Batch"/>
    /// </remarks>
    public class CellProcedureBatch: Batch
    {
        /// <summary>
        /// Lotes de unidad que pertencen a el.
        /// </summary>
        public List<UnitBatch> Batch { get; set; }
    }
}
