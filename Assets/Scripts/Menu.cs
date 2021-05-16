using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public bool cursor;
    void Start()
    {
        if (!cursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
            Cursor.visible = true;
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Shut()
    {
        Application.Quit();
    }
    public void URL(string url)
    {
        Application.OpenURL(url);
    }
    public void Cred()
    {
        SceneManager.LoadScene(2);
    }
}
