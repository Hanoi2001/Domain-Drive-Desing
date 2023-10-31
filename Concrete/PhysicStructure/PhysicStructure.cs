using Domain_Drive_Desing.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Drive_Desing.Concrete.PhysicStructure
{
    /// <summary>
    /// Modela la descripcion basica generica de las estructuras fisicas.
    /// </summary>
    /// <remarks>
    /// Implementa las interfaces <see cref="IBasicDescription"/> y <see cref="IControlledEquipment."/>
    /// </remarks>
    public abstract class PhysicStructure : IBasicDescription, IControlledEquipment
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public DateTime StartupDate { get; set; }
        public bool IsOutOfService { get; set; }
        public bool CanEnterService { get; set; }
    }
}
