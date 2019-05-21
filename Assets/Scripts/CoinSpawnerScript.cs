using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnerScript : MonoBehaviour
{

    private float timer = 0f;
    public GameObject coin;

    public float range = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(10, 30);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            spawnCoin();
        }
    }

    void spawnCoin()
    {
        timer = Random.Range(10, 30);
        Vector3 position = new Vector3(transform.position.x + Random.Range(-range, range), transform.position.y, 0);
        Instantiate(coin, position, Quaternion.identity);
    }
}
