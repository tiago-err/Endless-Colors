using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollectorScript : MonoBehaviour
{

    private int coinCounter = 0;
    public Canvas coinCanvas;

    // Start is called before the first frame update
    void Awake()
    {
       coinCanvas.GetComponentInChildren<Text>().text = coinCounter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            coinCounter++;
            coinCanvas.GetComponentInChildren<Text>().text = coinCounter.ToString();
            Destroy(collision.gameObject);
        }
    }
}
