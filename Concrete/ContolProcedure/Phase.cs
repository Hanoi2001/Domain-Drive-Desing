using Domain_Drive_Desing.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Drive_Desing.Concrete.ControlProcedure
{
    /// <summary>
    /// Mdela una fase.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="ControlProcedure"/>.
    /// </remarks>
    public abstract class Phase : ControlProcedure
    {
        
    }

    /// <summary>
    /// Modela una fase de tiempo indefinido.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="Phase"/>.
    /// </remarks>
    public class PhaseIndefiniteTime : Phase
    {

    }

    /// <summary>
    /// Modela una fase de tiempo definido.
    /// </summary>
    /// <remarks>
    /// Hereda de <see cref="Phase"/>.
    /// </remarks>
    public class PhaseDefiniteTime: Phase
    {

    }
}
