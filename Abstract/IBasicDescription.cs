using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Drive_Desing.Abstract
{
    /// <summary>
    /// Interface que modela la descripcion basica de los componentes
    /// </summary>
    public interface IBasicDescription
    {
        #region Properties
        /// <summary>
        /// Nombre.
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Description.
        /// </summary>
        string Description { get; set; }
        /// <summary>
        /// Identificador unico del componente
        /// </summary>
        int Id { get; set; }
        #endregion
    }
}
