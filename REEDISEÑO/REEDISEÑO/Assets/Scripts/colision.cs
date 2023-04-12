using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class colision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D enemigo)
    {
        if (enemigo.gameObject.tag == "enemigo")
        {
            //gameObject.GetComponent<Animator>(true).enabled = true;
            SceneManager.LoadScene("GameOver");
            //Debug.Log("au xd");
        }
    }
    
}
