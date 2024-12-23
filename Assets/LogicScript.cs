using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
   public int playerScore;
   public Text scoreText;
   public GameObject gameOverScreen;
   [ContextMenu("Incerease Score")]
   public void addScore(int scoreToadd){
    playerScore = playerScore+scoreToadd;
    scoreText.text = playerScore.ToString();
   }
   public void restartGmae(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
   public void gameOver(){
    gameOverScreen.SetActive(true);
   }

}
