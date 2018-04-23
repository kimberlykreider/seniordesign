<<<<<<< HEAD
﻿namespace VRTK.Examples
{
    using UnityEngine;
    public class AutoRotation : MonoBehaviour
    {
        [Tooltip("Angular velocity in degrees per seconds")]
        public float degPerSec = 60.0f;

        [Tooltip("Rotation axis")]
        public Vector3 rotAxis = Vector3.up;

        // Use this for initialization
        private void Start()
        {
            rotAxis.Normalize();
        }

        // Update is called once per frame
        private void Update()
        {
            transform.Rotate(rotAxis, degPerSec * Time.deltaTime);
        }
    }
=======
﻿namespace VRTK.Examples
{
    using UnityEngine;
    public class AutoRotation : MonoBehaviour
    {
        [Tooltip("Angular velocity in degrees per seconds")]
        public float degPerSec = 60.0f;

        [Tooltip("Rotation axis")]
        public Vector3 rotAxis = Vector3.up;

        // Use this for initialization
        private void Start()
        {
            rotAxis.Normalize();
        }

        // Update is called once per frame
        private void Update()
        {
            transform.Rotate(rotAxis, degPerSec * Time.deltaTime);
        }
    }
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
}