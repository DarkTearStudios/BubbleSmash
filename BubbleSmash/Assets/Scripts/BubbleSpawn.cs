using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawn : MonoBehaviour
{
    public float xbound;
    public float ybound;

    public float SpawnTime;
    public GameObject bubble;

    public float radius;
    public Collider2D[] colliders;

    void Start()
    {
        StartSpawn();
       
    }

   
    void Update()
    {
       
    }


    public void StartSpawn()
    {
        Vector2 SpawnPos = new Vector2();
        bool canSpawnHere = false;
        

        while (!canSpawnHere)
        {
            float xPos = Random.Range(-xbound, xbound);
            float yPos = Random.Range(-ybound, ybound);

            SpawnPos = new Vector2(xPos, yPos);
            canSpawnHere = PreventSpawnOverlap(SpawnPos);

            if (canSpawnHere)
            {
                break;
            }

            
        }

        InvokeRepeating("SpawnBubble",0.5f, SpawnTime);

        
    }

    public void StopSpawn ()
    {
        CancelInvoke("SpawnBubble");
    }

    void SpawnBubble()
    {
        Instantiate(bubble, new Vector3 (Random.Range(-2.5f, 2.5f), transform.position.y, 0), Quaternion.identity);
    }

    public bool PreventSpawnOverlap(Vector2 spawnPos)
    {
        colliders = Physics2D.OverlapCircleAll(transform.position, radius);
        for (int i = 0; i < colliders.Length; i++)
        {
            Vector2 centerpoint = colliders[i].bounds.center;
            float width = colliders[i].bounds.extents.x;
            float height = colliders[i].bounds.extents.y;

            float leftExtent = centerpoint.x - width;
            float rightExtent = centerpoint.x + width;
            float lowerExtent = centerpoint.y - height;
            float upperExtent = centerpoint.y + height;

            if (spawnPos.x >= leftExtent && spawnPos.x <= rightExtent)
            {
                if (spawnPos.y >= lowerExtent && spawnPos.y <= upperExtent)
                {
                    return false;
                }
            }
        }
        return true;
    }


}
