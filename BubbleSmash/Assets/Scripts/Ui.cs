using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Home()
    {
        SceneManager.LoadScene("Scenes/Start");
    }

    public void Replay()
    {
        SceneManager.LoadScene("Scenes/Game");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Scenes/Menu");
    }

    public void Lose()
    {
        SceneManager.LoadScene("Scenes/Lose");
    }
}
