using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Drive_Desing.Concrete.ControlProcedure
{
    /// <summary>
    /// Modela un procedimiento de unidad.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="ControlProcedure"/>.
    /// </remarks>
    public abstract class UnitProcedure : ControlProcedure
    {
        #region Properties
        /// <summary>
        /// Define si el procedimiento esta habilitado o no.
        /// </summary>
        public bool IsProcedureEnable { get; set; }
        /// <summary>
        /// Identificador unico de la unidad que la contine.
        /// </summary>
        public int IdUnit { get; set; }
        /// <summary>
        /// Lista de Operaciones que contiene.
        /// </summary>
        public List<Operation> Operations { get; set; }
        #endregion
    }

    /// <summary>
    /// Modela un procedimiento de unidad de tiempo indefinido.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="UnitProcedure"/>.
    /// </remarks>
    public class UnitProcedureIndefiniteTime : UnitProcedure
    {
        #region Properties
        /// <summary>
        /// Listas que contiene todas las operaciones de tiempo indefinido.
        /// </summary>
        public List<OperationIndefiniteTime> OperationsIndefinite { get => Operations.OfType<OperationIndefiniteTime>().ToList();}
        /// <summary>
        /// Listas que contiene todas las operaciones de tiempo definido.
        /// </summary>
        public List<OperationDefiniteTime> OperationsDefinite { get => Operations.OfType<OperationDefiniteTime>().ToList();}
        #endregion
    }

    /// <summary>
    /// Modela un procedimiento de unidad de tiempo definido.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="UnitProcedure"/>.
    /// </remarks>
    public class UnitProcedureDefiniteTime : UnitProcedure
    {

    }

}
