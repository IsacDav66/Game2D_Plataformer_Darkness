using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
   public static ScoreManager scoreManager;

   public Text scoreText;
   int score = 0;

   void Start()
   {
     scoreManager = this;
   }
    void Update()
    {
        if(scoreText == null)
        {
            scoreText = GameObject.Find("Text").GetComponent<Text>();
            scoreText.text = score + "";
        }
    }

   public void RaiseScore(int s)
   {
       score += s;
       scoreText.text = score + "";

       if (score == 100)
       {
           SceneManager.LoadScene("Scene2");
       }
   }
}
