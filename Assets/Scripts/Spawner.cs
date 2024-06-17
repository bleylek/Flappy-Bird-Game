using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Bird bird;
    public float time; // Time interval between spawns, set in the editor
    public GameObject obstacles; // The obstacle prefab to spawn
    public float h; // The vertical range within which obstacles will be spawned

    // Coroutine that spawns obstacles at regular intervals
    public IEnumerator sobj(float time) // Continue spawning as long as the bird is not dead
    {
        while(bird.isDead == false)
        {
            Instantiate(obstacles, new Vector3(3, Random.Range(-h, h),0),Quaternion.identity); // Spawn an obstacle at a random vertical position within the range
            yield return new WaitForSeconds(time); // Wait for the specified interval before spawning the next obstacle
        }
        
    }

    private void Start()
    {
        StartCoroutine(sobj(time)); // Start the obstacle spawning coroutine
    }
}
