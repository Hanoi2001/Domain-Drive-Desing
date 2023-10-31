using Domain_Drive_Desing.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Drive_Desing.Concrete.ControlProcedure
{
    /// <summary>
    /// Modela la descripcion basica generica de los procedimientos de control.
    /// </summary>
    /// <remarks>
    /// Implementa las interfaces <see cref="IBasicDescription"/> y <see cref="IControlledEquipment."/>
    /// </remarks>
    public abstract class ControlProcedure : IBasicDescription , IControlledEquipment
    {
        #region Properties
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public DateTime StartupDate { get; set; }
        public bool IsOutOfService { get; set; }
        public bool CanEnterService { get; set; }
        #endregion

    }
}
