using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    bool game_over = false;
    float restart_delay = 2f;
    float levelChange_delay = 3f;
    public GameObject LevelCompleteUI;
    public void EndGame(int code)
    {
        if(code > 0)
        {
            if(game_over == false)
            {
                game_over = true;
                Invoke("Restart", restart_delay);
            }
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void NextScene()
    {
        Debug.Log("In Second Level");
        Debug.Log(SceneManager.sceneCountInBuildSettings);
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCountInBuildSettings);
    }

    delegate void InvokedFunction();
    IEnumerator WaitAndInvoke(float secondsToWait, InvokedFunction func) 
    {
        yield return new WaitForSeconds(secondsToWait);
        func();
    }

    public void LevelComplete()
    {
        Debug.Log(SceneManager.GetActiveScene().name + " Complete");
        LevelCompleteUI.SetActive(true);
        StartCoroutine(WaitAndInvoke(levelChange_delay, NextScene));
        Debug.Log("Second Level");
        // Invoke("NextScene", levelChange_delay);
        
    }
}
