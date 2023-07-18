using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipesponner : MonoBehaviour
{
    public float heightOffset = 5;
    public float spawnRate = 2;
    private float timer = 0;
    public float moveSpeed = 5;
    public GameObject pipe;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
