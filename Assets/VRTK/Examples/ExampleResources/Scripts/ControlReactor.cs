<<<<<<< HEAD
﻿namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEventHelper;

    public class ControlReactor : MonoBehaviour
    {
        public TextMesh go;

        private VRTK_Control_UnityEvents controlEvents;

        private void Start()
        {
            controlEvents = GetComponent<VRTK_Control_UnityEvents>();
            if (controlEvents == null)
            {
                controlEvents = gameObject.AddComponent<VRTK_Control_UnityEvents>();
            }

            controlEvents.OnValueChanged.AddListener(HandleChange);
        }

        private void HandleChange(object sender, Control3DEventArgs e)
        {
            go.text = e.value.ToString() + "(" + e.normalizedValue.ToString() + "%)";
        }
    }
=======
﻿namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEventHelper;

    public class ControlReactor : MonoBehaviour
    {
        public TextMesh go;

        private VRTK_Control_UnityEvents controlEvents;

        private void Start()
        {
            controlEvents = GetComponent<VRTK_Control_UnityEvents>();
            if (controlEvents == null)
            {
                controlEvents = gameObject.AddComponent<VRTK_Control_UnityEvents>();
            }

            controlEvents.OnValueChanged.AddListener(HandleChange);
        }

        private void HandleChange(object sender, Control3DEventArgs e)
        {
            go.text = e.value.ToString() + "(" + e.normalizedValue.ToString() + "%)";
        }
    }
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
}