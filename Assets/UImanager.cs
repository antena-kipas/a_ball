using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("ABall");
    }

    public void Keluar()
    {
        Application.Quit();
    }
}
