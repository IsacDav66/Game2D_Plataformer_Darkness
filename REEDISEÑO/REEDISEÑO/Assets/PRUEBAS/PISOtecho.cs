using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PISOtecho : MonoBehaviour
{
    bool canJump = true;
    bool onPlatform = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("suelo"))
        {
            canJump = true;
            onPlatform = false;
        }
        else if (collision.collider.CompareTag("plataforma"))
        {
            canJump = true;
            onPlatform = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("plataforma"))
        {
            onPlatform = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            canJump = false;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 500));
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && onPlatform)
        {
            // Hacer algo cuando se presiona la tecla hacia abajo mientras se está en una plataforma.
        }
    }
}