<<<<<<< HEAD
using System;
using UnityEngine;
using UnityEngine.UI;

public class CameraSwitch : MonoBehaviour
{
    public GameObject[] objects;
    public Text text;

    private int m_CurrentActiveObject;


    private void OnEnable()
    {
        text.text = objects[m_CurrentActiveObject].name;
    }


    public void NextCamera()
    {
        int nextactiveobject = m_CurrentActiveObject + 1 >= objects.Length ? 0 : m_CurrentActiveObject + 1;

        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].SetActive(i == nextactiveobject);
        }

        m_CurrentActiveObject = nextactiveobject;
        text.text = objects[m_CurrentActiveObject].name;
    }
}
=======
using System;
using UnityEngine;
using UnityEngine.UI;

public class CameraSwitch : MonoBehaviour
{
    public GameObject[] objects;
    public Text text;

    private int m_CurrentActiveObject;


    private void OnEnable()
    {
        text.text = objects[m_CurrentActiveObject].name;
    }


    public void NextCamera()
    {
        int nextactiveobject = m_CurrentActiveObject + 1 >= objects.Length ? 0 : m_CurrentActiveObject + 1;

        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].SetActive(i == nextactiveobject);
        }

        m_CurrentActiveObject = nextactiveobject;
        text.text = objects[m_CurrentActiveObject].name;
    }
}
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
