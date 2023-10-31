using Domain_Drive_Desing.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Drive_Desing.Concrete.Batch
{
    /// <summary>
    /// Modela la instancia basica de un lote.
    /// </summary>
    /// <remarks>
    /// Implementa la interface <see cref="IBasicDescription"/>.
    /// </remarks>
    public abstract class Batch : IBasicDescription
    {
        public string Name { get; set ; }
        public string Description { get ; set; }
        public int Id { get; set; }

        /// <summary>
        /// Codigo de lote.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Fecha de creacion.
        /// </summary>
        public DateTime DateCreation { get; set; }

        /// <summary>
        /// Identificador unico de celula de proceso asociada.
        /// </summary>
        public int IdProcessCell { get; set; }

        /// <summary>
        /// Identificador unico de procedimiento de celula de proceso asociado.
        /// </summary>
        public int IdProcessCellProcedure { get; set; }

        /// <summary>
        /// Almacena si ya se imprimio.
        /// </summary>
        public bool IsPrinted { get; set; }

    }
}
