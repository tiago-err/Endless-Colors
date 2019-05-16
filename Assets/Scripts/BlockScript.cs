using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{

    private Color[] colors = { Color.red, Color.blue, Color.green };
    public float verticalSpeed;
    private bool ableToMove = false;
    public float horizontalSpeed;
    private bool movingRight = false;
    private bool move = false;

    [Range(0, 100)]
    public int movingProbability;

    private Transform initialPosition;

    // Start is called before the first frame update
    void Awake()
    {
        Random random = new Random();
        GetComponent<SpriteRenderer>().color = colors[Random.Range(0, 3)];
        transform.localScale = new Vector3(Random.Range(0.15f, 1.6f), transform.localScale.y, transform.localScale.z);
        initialPosition = this.gameObject.transform;
        move = Random.Range(0, 100) <= movingProbability;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enableMovement()
    {
        ableToMove = true;
    }

    public void disableMovement()
    {
        ableToMove = false;
    }

    private void FixedUpdate()
    {
        Vector3 position = new Vector3(transform.position.x, -10f, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, position, verticalSpeed * Time.deltaTime);

        if (ableToMove && move)
        {
                position.x = position.x + (movingRight ? 1 : -1);
                position.y = transform.position.y;
                transform.position = Vector3.MoveTowards(transform.position, position, horizontalSpeed * Time.deltaTime);
                if ((transform.position.x >= initialPosition.position.x + 2 || transform.position.x <= initialPosition.position.x - 2) || (transform.position.x >= 3 || transform.position.x <= -3))
                {
                    movingRight = !movingRight;
                }
        }
    }
}
