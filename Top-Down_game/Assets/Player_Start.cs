using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //importing SceneManagement Library

public class Player_Start : MonoBehaviour
{
    public static PlayerController instance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            //take to new scene
            Debug.Log("change scene");

            SceneManager.LoadScene(0);
        }
    }
}
