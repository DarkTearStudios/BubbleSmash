using UnityEngine;
using System.Collections;

public class Backgrounds : MonoBehaviour
{

    public SpriteRenderer backgroundSpriteRenderer;
    public Sprite[] backgroundSprites;

    // Use this for initialization
    void Start()
    {
        backgroundSpriteRenderer.sprite = backgroundSprites[Random.Range(0, backgroundSprites.Length)];
    }

}