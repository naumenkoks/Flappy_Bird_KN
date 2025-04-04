using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Start button clicked!");
        SceneManager.LoadScene("GameScene");
    }
}
