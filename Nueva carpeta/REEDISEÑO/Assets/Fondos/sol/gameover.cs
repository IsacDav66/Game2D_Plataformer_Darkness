using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    private void OnEnable()
    {
        reloj.ALllegarACero += CambiarARojo;
    }
    private void OnDisable()
    {
        reloj.ALllegarACero -= CambiarARojo;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void CambiarARojo()
    {
       SceneManager.LoadScene("GameOver");
    }
}
