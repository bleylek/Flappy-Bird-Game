using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Text textForScore;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        textForScore.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updating()
    {
        score++;
        textForScore.text = score.ToString();
    }
    public void Restart()
    {
        SceneManager.LoadScene(0); // Reload the first scene
    }
}
