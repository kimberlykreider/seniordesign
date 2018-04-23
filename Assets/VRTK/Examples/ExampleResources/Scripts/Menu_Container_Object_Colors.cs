<<<<<<< HEAD
﻿namespace VRTK.Examples
{
    using UnityEngine;

    public class Menu_Container_Object_Colors : VRTK_InteractableObject
    {
        public void SetSelectedColor(Color color)
        {
            foreach (Menu_Object_Spawner menuObjectSpawner in gameObject.GetComponentsInChildren<Menu_Object_Spawner>())
            {
                menuObjectSpawner.SetSelectedColor(color);
            }
        }

        protected void Start()
        {
            SetSelectedColor(Color.red);
            SaveCurrentState();
        }
    }
=======
﻿namespace VRTK.Examples
{
    using UnityEngine;

    public class Menu_Container_Object_Colors : VRTK_InteractableObject
    {
        public void SetSelectedColor(Color color)
        {
            foreach (Menu_Object_Spawner menuObjectSpawner in gameObject.GetComponentsInChildren<Menu_Object_Spawner>())
            {
                menuObjectSpawner.SetSelectedColor(color);
            }
        }

        protected void Start()
        {
            SetSelectedColor(Color.red);
            SaveCurrentState();
        }
    }
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
}