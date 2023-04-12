using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ganaste : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D estrella)
    {
        if (estrella.gameObject.tag == "estrella")
        {
            //gameObject.GetComponent<Animator>(true).enabled = true;
            SceneManager.LoadScene("Ganaste");
            //Debug.Log("au xd");
        }
    }
    
}
