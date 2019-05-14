
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningScript : MonoBehaviour
{
    private float timer = 0f;
    public float timeBetweenBlocks = 1f;
    private int numberBlocks = 0;
    public int spawnSpeedBlocks = 5;
    public GameObject block;

    public float range = 3f;

    // Start is called before the first frame update
    void Start()
    {
        block.GetComponent<BlockScript>().speed = 3.5f;
        timer = timeBetweenBlocks;
        Vector3 position = new Vector3(Random.Range(-range, range), transform.position.y, 0);
        Instantiate(block, position, Quaternion.identity);
        numberBlocks++;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = timeBetweenBlocks;
            Vector3 position = new Vector3(transform.position.x + Random.Range(-range, range), transform.position.y, 0);
            Instantiate(block, position, Quaternion.identity);
            numberBlocks++;
        }

        if (numberBlocks == spawnSpeedBlocks)
        {
            numberBlocks = 0;
            if (timeBetweenBlocks > 0.5f)
            {
                timeBetweenBlocks -= 0.1f;
            } else
            {
                if (block.GetComponent<BlockScript>().speed < 10f)
                {
                    block.GetComponent<BlockScript>().speed += 0.3f;
                }
                
            }
            
        }
    }
}
