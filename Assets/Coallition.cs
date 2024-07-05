using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Coallition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Kode akan dijalankan ketika ada object lain masuk ke dalam trigger
        SceneManager.LoadScene("GameOver");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
