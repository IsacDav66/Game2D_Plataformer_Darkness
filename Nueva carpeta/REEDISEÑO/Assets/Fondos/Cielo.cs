using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cielo : MonoBehaviour
{
    public float velocidad;
    private MeshRenderer cielo;
    // Start is called before the first frame update
    void Start()
    {
        cielo =this.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        cielo.material.mainTextureOffset = cielo.material.mainTextureOffset + new Vector2(0.02f, 0) * Time.deltaTime;
    }
}
