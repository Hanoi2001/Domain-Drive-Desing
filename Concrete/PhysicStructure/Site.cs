using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Drive_Desing.Concrete.PhysicStructure
{
    /// <summary>
    /// Modela un sitio.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="PhysicStructure"/>.
    /// </remarks>
    public class Site : PhysicStructure
    {
        /// <summary>
        /// Direccion del sitio.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Numero del edificio del sitio.
        /// </summary>
        public int BuildingNumber { get; set; }
        /// <summary>
        /// Ciudad donde esta el sitio.
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Numero de telefono del sitio.
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Correo del sitio.
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// Areas que pertenecen a este sitio.
        /// </summary>
        public List<Area> Areas { get; set; }
    }
}
