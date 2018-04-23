<<<<<<< HEAD
using System;
using UnityEngine;

public class MenuSceneLoader : MonoBehaviour
{
    public GameObject menuUI;

    private GameObject m_Go;

	void Awake ()
	{
	    if (m_Go == null)
	    {
	        m_Go = Instantiate(menuUI);
	    }
	}
}
=======
using System;
using UnityEngine;

public class MenuSceneLoader : MonoBehaviour
{
    public GameObject menuUI;

    private GameObject m_Go;

	void Awake ()
	{
	    if (m_Go == null)
	    {
	        m_Go = Instantiate(menuUI);
	    }
	}
}
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
