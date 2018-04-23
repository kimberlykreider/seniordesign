<<<<<<< HEAD
﻿namespace VRTK.Examples
{
    using UnityEngine;

    public class Lamp : VRTK_InteractableObject
    {
        public override void Grabbed(VRTK_InteractGrab grabbingObject)
        {
            base.Grabbed(grabbingObject);
            ToggleKinematics(false);
        }

        public override void Ungrabbed(VRTK_InteractGrab previousGrabbingObject)
        {
            base.Ungrabbed(previousGrabbingObject);
            ToggleKinematics(true);
        }

        private void ToggleKinematics(bool state)
        {
            foreach (Rigidbody rigid in transform.parent.GetComponentsInChildren<Rigidbody>())
            {
                rigid.isKinematic = state;
            }
        }
    }
=======
﻿namespace VRTK.Examples
{
    using UnityEngine;

    public class Lamp : VRTK_InteractableObject
    {
        public override void Grabbed(VRTK_InteractGrab grabbingObject)
        {
            base.Grabbed(grabbingObject);
            ToggleKinematics(false);
        }

        public override void Ungrabbed(VRTK_InteractGrab previousGrabbingObject)
        {
            base.Ungrabbed(previousGrabbingObject);
            ToggleKinematics(true);
        }

        private void ToggleKinematics(bool state)
        {
            foreach (Rigidbody rigid in transform.parent.GetComponentsInChildren<Rigidbody>())
            {
                rigid.isKinematic = state;
            }
        }
    }
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
}