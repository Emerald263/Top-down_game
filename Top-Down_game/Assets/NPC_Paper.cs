using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    //Declaring my variables
    public string NPCname = "Paper";
    public int health;
    public int speed = 5;
    public string Message;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if colliding with a game object with specific tag
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log(Message);
        }
    }


}
