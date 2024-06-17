using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 6); // Destroy the game object after 6 seconds
    }

    // FixedUpdate is called at a fixed interval and is used for physics updates
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; //transformdan pozisyonunu çek, Move the object to the left over time based on the specified speed
    }
}
