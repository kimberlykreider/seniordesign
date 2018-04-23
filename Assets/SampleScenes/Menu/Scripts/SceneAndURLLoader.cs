<<<<<<< HEAD
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAndURLLoader : MonoBehaviour
{
    private PauseMenu m_PauseMenu;


    private void Awake ()
    {
        m_PauseMenu = GetComponentInChildren <PauseMenu> ();
    }


    public void SceneLoad(string sceneName)
	{
		//PauseMenu pauseMenu = (PauseMenu)FindObjectOfType(typeof(PauseMenu));
		m_PauseMenu.MenuOff ();
		SceneManager.LoadScene(sceneName);
	}


	public void LoadURL(string url)
	{
		Application.OpenURL(url);
	}
}

=======
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAndURLLoader : MonoBehaviour
{
    private PauseMenu m_PauseMenu;


    private void Awake ()
    {
        m_PauseMenu = GetComponentInChildren <PauseMenu> ();
    }


    public void SceneLoad(string sceneName)
	{
		//PauseMenu pauseMenu = (PauseMenu)FindObjectOfType(typeof(PauseMenu));
		m_PauseMenu.MenuOff ();
		SceneManager.LoadScene(sceneName);
	}


	public void LoadURL(string url)
	{
		Application.OpenURL(url);
	}
}

>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
