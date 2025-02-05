using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathscreen : MonoBehaviour
{
    public string currentSceneName;
    void Start()
    {
        currentSceneName = SceneManager.GetActiveScene().name;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(currentSceneName);
    }
}
