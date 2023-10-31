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
    /// Modela una unidad.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="PhysicStructure"/>.
    /// </remarks>
    public abstract class Unit : PhysicStructure
    {
        /// <summary>
        /// Identificador de la célula de proceso a la que pertenece.
        /// </summary>
        public int IdCellProcedure { get; set; }

        /// <summary>
        /// Codigo de la unidad.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Fabricante de la unidad.
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Operaciones que pertenecen a esa unidad.
        /// </summary>
        public List<Operation> Operations { get; set; }

        /// <summary>
        /// Procedimientos de unidad asociados a esta unidad.
        /// </summary>
        public List<UnitProcedure> UnitProcedures { get; set; }


    }

    /// <summary>
    /// Unidad de uso permanente.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="Unit"/>.
    /// </remarks>
    public class UnitPermanentUse : Unit
    {
        /// <summary>
        /// Procedimiento principal de la unidad.
        /// </summary>
        public UnitProcedureIndefiniteTime MainProcedure { get; set; }

        /// <summary>
        /// Operacion principal de la unidad.
        /// </summary>
        public OperationIndefiniteTime MainOperation { get; set; }

    }

    /// <summary>
    /// Unidad de uso indeterminado.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="Unit"/>.
    /// </remarks>
    public class UnitUndeterminedUse : Unit
    {
        /// <summary>
        /// Lote de unidad asociado.
        /// </summary>
        public List<UnitBatch> UnitBatches { get; set; }
    }
}
