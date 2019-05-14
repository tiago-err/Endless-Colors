using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Awake()
    {
        transform.position = new Vector3(transform.position.x, -3.8f, transform.position.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 curPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, transform.position.y, transform.position.z));
            curPosition.x = curPosition.x <= -3 ? -3 : curPosition.x >= 3 ? 3 : curPosition.x;
            transform.position = Vector3.MoveTowards(transform.position, curPosition, speed * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, -3.8f, transform.position.z);
        }
    }
}
