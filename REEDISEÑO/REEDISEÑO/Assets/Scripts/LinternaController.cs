using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinternaController : MonoBehaviour
{
    bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Esto es el controlador de la derecha
        if (Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-600f * Time.deltaTime, 0));
        //Esto verifica si se presiona la derecha para que se active la animacion moving
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        //Esto es el controlador de la izquierda     
        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(600f * Time.deltaTime, 0));
            //Esto verifica si se presiona la izquierda para que se active la animacion moving
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        //Esto es el controlador que verifica si se deja de presionar la techa de la derecha o izquierda para ejecutar la animacion moving
        if(!Input.GetKey("left") && !Input.GetKey("right"))
        {
            gameObject.GetComponent<Animator>().SetBool("moving", false);
        }
        
        //Esto es el controlador par que salte el personaje
        if (Input.GetKeyDown("up") && canJump)
        {
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 650));

            //Esto verifica si se esta presionando la flecha hacia arriba para que se active la animacion saltando
            gameObject.GetComponent<Animator>().SetBool("saltando", true);
        }
        //Esto verifica si se deja de presionar la tecla arriba para que pare la animacion de saltar
        if (!Input.GetKeyDown("up") && canJump)
        {
            gameObject.GetComponent<Animator>().SetBool("saltando", false);
        }


    }

}