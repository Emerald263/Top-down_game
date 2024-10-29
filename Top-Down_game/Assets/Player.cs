using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //importing SceneManagement Library

public class PlayerController : MonoBehaviour
{
    public float speed;
    private SpriteRenderer sr;
    public bool hasKey = false;

    //sprite variables
    public Sprite upSprite;
    public Sprite leftSprite;
    public Sprite rightSprite;
    public Sprite frontSprite;


    //audio variables
    public AudioSource soundEffects;
    public AudioClip[] sounds;
    public AudioSource footstepsSound; // Public variable to access the Audio Source component
    public AudioSource itemcollect;

    //public Rigidbody2D rb;

    public static PlayerController instance;
    // Start is called before the first frame update
    void Start()
    {
        soundEffects = GetComponent<AudioSource>();
        sr = GetComponent<SpriteRenderer>();
        if (instance != null) //if another instance of the player is in the scene
        {
            Destroy(gameObject); //then destroy it
        }

        instance = this; //reassign the instance to the current player
        GameObject.DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;

        //go up
        if (Input.GetKey("w"))
        {
            newPosition.y += speed;
            //change sprite to up sprite
            sr.sprite = upSprite;
       
        }

        //go left
        if (Input.GetKey("a"))
        {
            newPosition.x -= speed;
            //change sprite to left sprite
            sr.sprite = leftSprite;
      
        }

        //go down
        if (Input.GetKey("s"))
        {
            newPosition.y -= speed;
            //change sprite to down sprite
            sr.sprite = frontSprite;
       
        }

        //go right
        if (Input.GetKey("d"))
        {
            newPosition.x += speed;
            //change sprite to right sprite
            sr.sprite = rightSprite;
        
        }

       
        transform.position = newPosition;

        {

            if (Input.GetKeyDown("w"))

            {

                footstepsSound.Play();

            }

            else if (Input.GetKeyUp("w")) // Check if key is released

            {

                footstepsSound.Stop();

            }
            if (Input.GetKeyDown("a"))

            {

                footstepsSound.Play();

            }

            else if (Input.GetKeyUp("a")) // Check if key is released

            {

                footstepsSound.Stop();

            }
            if (Input.GetKeyDown("s"))

            {

                footstepsSound.Play();

            }

            else if (Input.GetKeyUp("s")) // Check if key is released

            {

                footstepsSound.Stop();

            }
            if (Input.GetKeyDown("d"))

            {

                footstepsSound.Play();

            }

            else if (Input.GetKeyUp("d")) // Check if key is released

            {

                footstepsSound.Stop();

            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if colliding with a game object with specific tag
        if (collision.gameObject.tag.Equals("door1"))
        {
            Debug.Log("change scene");
       
            SceneManager.LoadScene(1);
        }

        if (collision.gameObject.tag.Equals("door3"))
        {
            Debug.Log("change scene");

            SceneManager.LoadScene(0);
        }

        if (collision.gameObject.tag.Equals("Key"))
        {
            Debug.Log("obtained key");
            hasKey = true; //player has the key now
            soundEffects.PlayOneShot(sounds[0], .7f); //play item collect sound effect
        }

        if (collision.gameObject.tag.Equals("door2") && hasKey == true)
        {
            Debug.Log("unlocked door!");
      
            SceneManager.LoadScene(0); //take to new scene
        }

        if (collision.gameObject.tag.Equals("door2") && hasKey == true)
        {
            Debug.Log("unlocked door!");
            //take to new scene
        }

       
    }

}
