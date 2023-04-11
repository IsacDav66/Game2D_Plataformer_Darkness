using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzController : MonoBehaviour
{
     bool canJump;
     public GameObject gameObjectToDeactivate;
     public GameObject gameObjectToActivate;

     bool derecha;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey("x") )
            {
            derecha = true;
            
            //Esto verifica si se presiona la derecha para que se active la animacion moving
            
            gameObject.GetComponent<Animator>().SetBool("siderecha", true);
            //gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }
     
        if (!Input.GetKey("x") && derecha )
            {
             derecha = false;
             gameObject.GetComponent<Animator>().SetBool("siderecha", false);
            }
      
       /*if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gameObjectToDeactivate.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            gameObjectToDeactivate.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            gameObjectToActivate.SetActive(true);
        }
       if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gameObjectToActivate.SetActive(false);
         }*/
    }

}