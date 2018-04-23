<<<<<<< HEAD
﻿namespace VRTK.UnityEventHelper
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    [AddComponentMenu("VRTK/Scripts/Utilities/Unity Events/VRTK_ControllerRigidbodyActivator_UnityEvents")]
    public sealed class VRTK_ControllerRigidbodyActivator_UnityEvents : VRTK_UnityEvents<VRTK_ControllerRigidbodyActivator>
    {
        [Serializable]
        public sealed class ControllerRigidbodyActivatorEvent : UnityEvent<object, ControllerRigidbodyActivatorEventArgs> { }

        public ControllerRigidbodyActivatorEvent OnControllerRigidbodyOn = new ControllerRigidbodyActivatorEvent();
        public ControllerRigidbodyActivatorEvent OnControllerRigidbodyOff = new ControllerRigidbodyActivatorEvent();

        protected override void AddListeners(VRTK_ControllerRigidbodyActivator component)
        {
            component.ControllerRigidbodyOn += ControllerRigidbodyOn;
            component.ControllerRigidbodyOff += ControllerRigidbodyOff;
        }

        protected override void RemoveListeners(VRTK_ControllerRigidbodyActivator component)
        {
            component.ControllerRigidbodyOn -= ControllerRigidbodyOn;
            component.ControllerRigidbodyOff -= ControllerRigidbodyOff;
        }

        private void ControllerRigidbodyOn(object o, ControllerRigidbodyActivatorEventArgs e)
        {
            OnControllerRigidbodyOn.Invoke(o, e);
        }

        private void ControllerRigidbodyOff(object o, ControllerRigidbodyActivatorEventArgs e)
        {
            OnControllerRigidbodyOff.Invoke(o, e);
        }
    }
=======
﻿namespace VRTK.UnityEventHelper
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    [AddComponentMenu("VRTK/Scripts/Utilities/Unity Events/VRTK_ControllerRigidbodyActivator_UnityEvents")]
    public sealed class VRTK_ControllerRigidbodyActivator_UnityEvents : VRTK_UnityEvents<VRTK_ControllerRigidbodyActivator>
    {
        [Serializable]
        public sealed class ControllerRigidbodyActivatorEvent : UnityEvent<object, ControllerRigidbodyActivatorEventArgs> { }

        public ControllerRigidbodyActivatorEvent OnControllerRigidbodyOn = new ControllerRigidbodyActivatorEvent();
        public ControllerRigidbodyActivatorEvent OnControllerRigidbodyOff = new ControllerRigidbodyActivatorEvent();

        protected override void AddListeners(VRTK_ControllerRigidbodyActivator component)
        {
            component.ControllerRigidbodyOn += ControllerRigidbodyOn;
            component.ControllerRigidbodyOff += ControllerRigidbodyOff;
        }

        protected override void RemoveListeners(VRTK_ControllerRigidbodyActivator component)
        {
            component.ControllerRigidbodyOn -= ControllerRigidbodyOn;
            component.ControllerRigidbodyOff -= ControllerRigidbodyOff;
        }

        private void ControllerRigidbodyOn(object o, ControllerRigidbodyActivatorEventArgs e)
        {
            OnControllerRigidbodyOn.Invoke(o, e);
        }

        private void ControllerRigidbodyOff(object o, ControllerRigidbodyActivatorEventArgs e)
        {
            OnControllerRigidbodyOff.Invoke(o, e);
        }
    }
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
}