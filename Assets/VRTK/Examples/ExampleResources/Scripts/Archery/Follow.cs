<<<<<<< HEAD
﻿namespace VRTK.Examples.Archery
{
    using UnityEngine;

    public class Follow : MonoBehaviour
    {
        public bool followPosition;
        public bool followRotation;
        public Transform target;

        private void Update()
        {
            if (target != null)
            {
                if (followRotation)
                {
                    transform.rotation = target.rotation;
                }

                if (followPosition)
                {
                    transform.position = target.position;
                }
            }
            else
            {
                VRTK_Logger.Error(VRTK_Logger.GetCommonMessage(VRTK_Logger.CommonMessageKeys.NOT_DEFINED, "target"));
            }
        }
    }
=======
﻿namespace VRTK.Examples.Archery
{
    using UnityEngine;

    public class Follow : MonoBehaviour
    {
        public bool followPosition;
        public bool followRotation;
        public Transform target;

        private void Update()
        {
            if (target != null)
            {
                if (followRotation)
                {
                    transform.rotation = target.rotation;
                }

                if (followPosition)
                {
                    transform.position = target.position;
                }
            }
            else
            {
                VRTK_Logger.Error(VRTK_Logger.GetCommonMessage(VRTK_Logger.CommonMessageKeys.NOT_DEFINED, "target"));
            }
        }
    }
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
}