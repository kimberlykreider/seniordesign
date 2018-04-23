<<<<<<< HEAD
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventSystemChecker : MonoBehaviour
{
    //public GameObject eventSystem;

	// Use this for initialization
	void Awake ()
	{
	    if(!FindObjectOfType<EventSystem>())
        {
           //Instantiate(eventSystem);
            GameObject obj = new GameObject("EventSystem");
            obj.AddComponent<EventSystem>();
            obj.AddComponent<StandaloneInputModule>().forceModuleActive = true;
        }
	}
}
=======
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventSystemChecker : MonoBehaviour
{
    //public GameObject eventSystem;

	// Use this for initialization
	void Awake ()
	{
	    if(!FindObjectOfType<EventSystem>())
        {
           //Instantiate(eventSystem);
            GameObject obj = new GameObject("EventSystem");
            obj.AddComponent<EventSystem>();
            obj.AddComponent<StandaloneInputModule>().forceModuleActive = true;
        }
	}
}
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
