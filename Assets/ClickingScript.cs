using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickingScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    { 
        GetComponent<Animator>().SetBool("clicked", true);
    }

    private void OnMouseUp()
    {
        SceneManager.LoadScene(1);
    }
}
