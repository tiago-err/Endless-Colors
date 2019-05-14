using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    [Range(0,10)]
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(transform.position.x, -10f, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, position, speed * Time.deltaTime);
    }
}
