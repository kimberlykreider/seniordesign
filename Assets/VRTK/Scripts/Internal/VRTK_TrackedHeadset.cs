<<<<<<< HEAD
﻿namespace VRTK
{
    using UnityEngine;

    public class VRTK_TrackedHeadset : MonoBehaviour
    {
        protected virtual void FixedUpdate()
        {
            VRTK_SDK_Bridge.HeadsetProcessFixedUpdate();
        }

        protected virtual void Update()
        {
            VRTK_SDK_Bridge.HeadsetProcessUpdate();
        }
    }
=======
﻿namespace VRTK
{
    using UnityEngine;

    public class VRTK_TrackedHeadset : MonoBehaviour
    {
        protected virtual void FixedUpdate()
        {
            VRTK_SDK_Bridge.HeadsetProcessFixedUpdate();
        }

        protected virtual void Update()
        {
            VRTK_SDK_Bridge.HeadsetProcessUpdate();
        }
    }
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
}