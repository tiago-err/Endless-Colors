using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ColorControlScript : MonoBehaviour
{

    SpriteRenderer spriteR;
    int colorNumber = 0;
    private Color[] colors = { Color.red, Color.blue, Color.green };
    private int points = 0;
    public Canvas pointCanvas;

    void Awake()
    {
        spriteR = GetComponent<SpriteRenderer>();
        colorNumber = 0;
        spriteR.color = colors[colorNumber];
        pointCanvas.GetComponentInChildren<Text>().text = points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        pointCanvas.GetComponentInChildren<Text>().text = points.ToString();
    }

    public void changeColor()
    {
        colorNumber = (colorNumber + 1 == 3) ? 0 : colorNumber + 1;
        spriteR.color = colors[colorNumber];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            if (!collision.gameObject.GetComponent<SpriteRenderer>().color.Equals(colors[colorNumber]))
            {
                Destroy(gameObject);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else
            {
                points++;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Switch")
        {
            changeColor();
        }
    }
}
