using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Drive_Desing.Concrete.ControlProcedure
{
    /// <summary>
    /// Modela un procedimiento de celula de proceso.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="ControlProcedure"/>
    /// </remarks>
    public abstract class ProcessCellProcedure : ControlProcedure
    {
        #region Properties
        /// <summary>
        /// Identificador unico de la celula de procedimiento que lo contiene.
        /// </summary>
        public int IdCellProcedure { get; set; }
        /// <summary>
        /// Lista de procedimiento de unidad que contiene.
        /// </summary>
        public List<UnitProcedure> Procedures { get; set; }
        #endregion
    }

    /// <summary>
    /// Modela un procedimiento de celula de proceso de tiempo indefinido.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="ProcessCellProcedure"/>
    /// </remarks>
    public class ProcessCellProcedureIndefiniteTime : ProcessCellProcedure
    {
        #region Properties
        /// <summary>
        /// Lista de procedimientos de unidad de tiempo indefinido que contiene.
        /// </summary>
        public List<UnitProcedureIndefiniteTime> ProceduresIndefinite { get => Procedures.OfType<UnitProcedureIndefiniteTime>().ToList();}
        /// <summary>
        /// Lista de procedimientos de unidad de tiempo definido que contiene.
        /// </summary>
        public List<UnitProcedureDefiniteTime> ProceduresDefinite { get => Procedures.OfType<UnitProcedureDefiniteTime>().ToList();}
        #endregion
    }

    /// <summary>
    /// Modela un procedimiento de celula de proceso de tiempo definido.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="ProcessCellProcedure"/>
    /// </remarks>
    public class ProcessCellProcedureDefiniteTime: ProcessCellProcedure
    {

    }
}
