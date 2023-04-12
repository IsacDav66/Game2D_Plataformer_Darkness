using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinSpawner : MonoBehaviour
{
    float timer;
    public GameObject coinPrefab;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >=5f)
        {
            timer = 0;
            float x = Random.Range(-10f, 50f);
            Vector3 position = new Vector3(x, 0, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(coinPrefab, position, rotation);
        }
        
    }
}
