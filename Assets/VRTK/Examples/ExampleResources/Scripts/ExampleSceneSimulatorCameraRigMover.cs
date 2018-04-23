<<<<<<< HEAD
﻿namespace VRTK.Examples
{
    using UnityEngine;

    public class ExampleSceneSimulatorCameraRigMover : MonoBehaviour
    {
        protected virtual void Awake()
        {
            Transform cameraRigTransform = transform.Find("VRSimulatorCameraRig");
            cameraRigTransform.position -= transform.position;
        }
    }
=======
﻿namespace VRTK.Examples
{
    using UnityEngine;

    public class ExampleSceneSimulatorCameraRigMover : MonoBehaviour
    {
        protected virtual void Awake()
        {
            Transform cameraRigTransform = transform.Find("VRSimulatorCameraRig");
            cameraRigTransform.position -= transform.position;
        }
    }
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
}