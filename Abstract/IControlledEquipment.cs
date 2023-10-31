using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Drive_Desing.Abstract
{
    /// <summary>
    /// Interface que modela la descripcion operativa de los componentes
    /// </summary>
    public interface IControlledEquipment
    {
        #region Properties
        /// <summary>
        /// Fecha de puesta en marcha
        /// </summary>
        DateTime StartupDate { get; set; }
        /// <summary>
        /// Controla si esta fuera de servicio
        /// </summary>
        bool IsOutOfService { get; set; }
        /// <summary>
        /// Controla si puede entrar en servicio
        /// </summary>
        bool CanEnterService { get; set; }
        #endregion
    }
}
