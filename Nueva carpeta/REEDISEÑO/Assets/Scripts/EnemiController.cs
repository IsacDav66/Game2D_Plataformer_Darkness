using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiController : MonoBehaviour
{
    private float velocidadX = 2f;
    private float velocidadY = -2f;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       if (velocidadX != -3f)
       {
       transform.Translate(velocidadX * Time.deltaTime, velocidadY * Time.deltaTime, 0 ); 
       }
       if (velocidadY != 3f)
       {
       transform.Translate(velocidadY * Time.deltaTime, velocidadX * Time.deltaTime, 0 );
       }


    }
}
