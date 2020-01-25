using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void LoadNextLevel()
    {
        // if ((SceneManager.GetActiveScene().buildIndex + 1) >= SceneManager.sceneCountInBuildSettings)
        // {
        //     SceneManager.LoadScene(0);
        // }
        // else
        // {
        //     SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1));
        // }
        Debug.Log("Level 2");
        Debug.Log("Next Level " + (SceneManager.GetActiveScene().buildIndex + 1));
        // SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1));
    }
}
