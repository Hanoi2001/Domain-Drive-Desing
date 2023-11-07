using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Drive_Desing.Concrete.ControlProcedure
{
    /// <summary>
    /// Modela una operacion.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="ControlProcedure"/>
    /// </remarks>
    public abstract class Operation: ControlProcedure
    {
        #region Properties
        /// <summary>
        /// Identificador unico de la unidad que la contiene.
        /// </summary>
        public int IdUnit { get; set; }
        /// <summary>
        /// Lista de fases que contiene.
        /// </summary>
        public List<Phase> Phase { get; set; }
        #endregion
    }
    /// <summary>
    /// Modela una operacion de tiempo indefinido.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="Operation"/>
    /// </remarks>
    public class OperationIndefiniteTime : Operation
    {
        #region Properties
        /// <summary>
        /// Lista de fases de tiempo indefinido que contiene.
        /// </summary>
        public List<PhaseIndefiniteTime> PhasesIndefinite { get => Phase.OfType<PhaseIndefiniteTime>().ToList();}
        /// <summary>
        /// Lista de fases de tiempo definido que contiene.
        /// </summary>
        public List<PhaseDefiniteTime> PhaseDefinite { get => Phase.OfType<PhaseDefiniteTime>().ToList();}
        #endregion
    }

    /// <summary>
    /// Modela una operacion de tiempo definido.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="Operation"/>
    /// </remarks>
    public class OperationDefiniteTime : Operation
    {

    }
}
