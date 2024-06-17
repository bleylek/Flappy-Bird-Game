using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rigidBody; //rigidbody 
    public float vel = 2f;
    public bool isDead; // default  false
    public GameManager manageGame;
    public GameObject deathScreen;
   
    // Start is called before the first frame update
    void Start()
    {
        //rigidBody = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;  // Ensure the game time scale is set to normal when the game starts
    }

    // Update is called once per frame
    void Update()
    {
        //týklamayý al
        if(Input.GetMouseButtonDown(0)) //getmousebottondown 1 kez input alýr bu normal sol týkýmýzdýr normal týklamayla da eþdeðerdir whereas getmousebutton basýlý tuttuðumuz sürece input alýr
        {
            // Apply an upward velocity to the bird
            rigidBody.velocity = Vector2.up * vel;
        }
    }
    // Trigger event for scoring points
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Point") // If the bird collides with the "Point" object
        {
            manageGame.updating(); // Update the game score
        }
    }
    // Collision event for handling death
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "Death") // If the bird collides with an object tagged as "Death"
        {
            isDead = true; // Set the bird's state to dead
            Time.timeScale = 0; //no more movements Stop the game time

            deathScreen.SetActive(true); // Show the death screen
        }
    }
}
