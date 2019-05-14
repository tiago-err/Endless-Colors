using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorScript : MonoBehaviour
{

    public GameObject player;
    ColorControlScript script;

    // Start is called before the first frame update
    void Start()
    {
        script = player.GetComponent<ColorControlScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        script.changeColor();
    }
}
