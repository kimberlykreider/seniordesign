<<<<<<< HEAD
﻿// Swap Controller Grab Action|SecondaryControllerGrabActions|60020
namespace VRTK.SecondaryControllerGrabActions
{
    using UnityEngine;

    /// <summary>
    /// The Swap Controller Grab Action provides a mechanism to allow grabbed objects to be swapped between controllers.
    /// </summary>
    /// <example>
    /// `VRTK/Examples/005_Controller_BasicObjectGrabbing` demonstrates the ability to swap objects between controllers on grab.
    /// </example>
    [AddComponentMenu("VRTK/Scripts/Interactions/Secondary Controller Grab Actions/VRTK_SwapControllerGrabAction")]
    public class VRTK_SwapControllerGrabAction : VRTK_BaseGrabAction
    {
        protected virtual void Awake()
        {
            isActionable = false;
            isSwappable = true;
        }
    }
}
=======
﻿// Swap Controller Grab Action|SecondaryControllerGrabActions|60020
namespace VRTK.SecondaryControllerGrabActions
{
    using UnityEngine;

    /// <summary>
    /// The Swap Controller Grab Action provides a mechanism to allow grabbed objects to be swapped between controllers.
    /// </summary>
    /// <example>
    /// `VRTK/Examples/005_Controller_BasicObjectGrabbing` demonstrates the ability to swap objects between controllers on grab.
    /// </example>
    [AddComponentMenu("VRTK/Scripts/Interactions/Secondary Controller Grab Actions/VRTK_SwapControllerGrabAction")]
    public class VRTK_SwapControllerGrabAction : VRTK_BaseGrabAction
    {
        protected virtual void Awake()
        {
            isActionable = false;
            isSwappable = true;
        }
    }
}
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
