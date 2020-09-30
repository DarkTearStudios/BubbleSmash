using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GreenCollide : MonoBehaviour
{


    bool gameOver;
    public AudioSource pop;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        pop = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Green")
        {
            pop.Play();

            Destroy(gameObject, 0.1f);

            ScoreManager.instance.IncrementScore();


        }

        else if (col.gameObject.tag == "Red" || col.gameObject.tag == "Blue" || col.gameObject.tag == "Yellow" && !gameOver)
        {
            
            ScoreManager.instance.StopScore();
            
            SceneManager.LoadScene("Scenes/Lose");
        }



    }
}
