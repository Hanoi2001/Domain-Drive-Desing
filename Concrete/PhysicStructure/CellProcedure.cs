using Domain_Drive_Desing.Concrete.Batch;
using Domain_Drive_Desing.Concrete.ControlProcedure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Drive_Desing.Concrete.PhysicStructure
{
    /// <summary>
    /// Modela una celula de proceso.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="PhysicStructure"/>.
    /// </remarks>
    public abstract class ProcessCell : PhysicStructure
    {
        /// <summary>
        /// Identificador del area al que pertenece.
        /// </summary>
        public int IdArea { get; set; }

        /// <summary>
        /// Unidades que pertenecen a la celula de proceso.
        /// </summary>
        public List<Unit> Units { get; set; }

        /// <summary>
        /// Procedimientos de celula de proceso asociados.
        /// </summary>
        public List<ProcessCellProcedure> ProcessCellProcedures { get; set; }
    }

    /// <summary>
    /// Modela una celula de proceso continua.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="ProcessCell"/>.
    /// </remarks>

    public class ProcessCellContinues : ProcessCell
    {
        /// <summary>
        /// Procedimiento principal de la celula de procesos.
        /// </summary>
        public ProcessCellProcedureIndefiniteTime MainProcedure { get; set; }
    }

    /// <summary>
    /// Modela una celula de proceso discreta.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="ProcessCell"/>.
    /// </remarks>

    public class ProcessCellDistrete : ProcessCell
    {

    }

    /// <summary>
    /// Modela una celula de proceso por lotes.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="ProcessCell"/>.
    /// </remarks>

    public class ProcessCellBatch : ProcessCell
    {
        /// <summary>
        /// Lotes de celula de proceso asociados a esta celula de proceso.
        /// </summary>
        public List<CellProcedureBatch> CellProcedureBatchs { get; set; }
    }
}
