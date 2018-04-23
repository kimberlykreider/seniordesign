<<<<<<< HEAD
﻿namespace VRTK.Examples
{
    using UnityEngine;

    public class Remote_Beam : MonoBehaviour
    {
        private Vector2 touchAxis;
        private float rotationSpeed = 180f;
        private float currentYaw;
        private float currentPitch;

        public void SetTouchAxis(Vector2 data)
        {
            touchAxis = data;
        }

        private void FixedUpdate()
        {
            currentYaw += touchAxis.y * rotationSpeed * Time.deltaTime;
            currentPitch += touchAxis.x * rotationSpeed * Time.deltaTime;
            transform.localRotation = Quaternion.AngleAxis(currentPitch, Vector3.up) * Quaternion.AngleAxis(currentYaw, Vector3.left);
        }
    }
=======
﻿namespace VRTK.Examples
{
    using UnityEngine;

    public class Remote_Beam : MonoBehaviour
    {
        private Vector2 touchAxis;
        private float rotationSpeed = 180f;
        private float currentYaw;
        private float currentPitch;

        public void SetTouchAxis(Vector2 data)
        {
            touchAxis = data;
        }

        private void FixedUpdate()
        {
            currentYaw += touchAxis.y * rotationSpeed * Time.deltaTime;
            currentPitch += touchAxis.x * rotationSpeed * Time.deltaTime;
            transform.localRotation = Quaternion.AngleAxis(currentPitch, Vector3.up) * Quaternion.AngleAxis(currentYaw, Vector3.left);
        }
    }
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
}