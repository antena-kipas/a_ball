using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Retry()
    {
        SceneManager.LoadScene("ABall");
    }

    public void MainMENU()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
