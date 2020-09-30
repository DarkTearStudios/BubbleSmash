using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour

{


    
    
    

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       


        //Gets the world position of the mouse on the screen        
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Checks whether the mouse is over the sprite
        bool overSprite = this.GetComponent<SpriteRenderer>().bounds.Contains(mousePosition);

        //If it's over the sprite


        if (overSprite)


        {
            //If we've pressed down on the mouse (or touched on the iphone)
            if (Input.GetMouseButton(0))
            {
                //Set the position to the mouse position
                this.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
                                                    Camera.main.ScreenToWorldPoint(Input.mousePosition).y,
                                                      0.0f);

            }
        }
    }



    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "BubbleDelete")
        {
            

            ScoreManager.instance.StopScore();

            

            SceneManager.LoadScene("Scenes/Lose");

            


        }
        
     
    }


    

    
}
