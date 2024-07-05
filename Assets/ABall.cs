using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;


public class ABall : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField]
    private GameObject _Square;

    private float rotasi;

     void Start()
    {
        Debug.Log(_Square.name);
        _Square.name = "Maze";
        Debug.Log(_Square.name);
        





    }
    

    public void turnrigth()
    {
        rotasi = -25;
    }

    public void turnleft()
    {
        rotasi = 25;
    }

    public void stop()
    {
        rotasi = 0;
    }

   

    // Update is called once per frame
    void Update()
    {
        _Square.transform.Rotate(0, 0, rotasi * Time.deltaTime);

    }




}
