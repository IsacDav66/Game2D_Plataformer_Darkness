using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManagerGameOver : MonoBehaviour
{
  public static ScoreManagerGameOver scoreManagerGameOver;

 
   int score = 0;

   void Start()
   {
       scoreManagerGameOver = this;
   }


}