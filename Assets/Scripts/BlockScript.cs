using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{

    private Color[] colors = { Color.red, Color.blue, Color.green };
    public float speed;

    // Start is called before the first frame update
    void Awake()
    {
        Random random = new Random();
        GetComponent<SpriteRenderer>().color = colors[Random.Range(0, 3)];
        transform.localScale = new Vector3(Random.Range(0.15f, 1.6f), transform.localScale.y, transform.localScale.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 position = new Vector3(transform.position.x, -10f, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, position, speed * Time.deltaTime);
    }
}
