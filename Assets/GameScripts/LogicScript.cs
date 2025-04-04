using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text ScoreText;
    public GameObject GameOverScreen;
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        ScoreText.text = playerScore.ToString();   
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        GameOverScreen.SetActive(true); 
    }
    void Start()
    {
    if (SceneManager.GetActiveScene().name == "MainMenu")
    {
        gameObject.SetActive(false); // Or Destroy(gameObject);
    }
}


}

