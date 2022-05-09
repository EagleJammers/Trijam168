using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonActions : MonoBehaviour
{
    int level= 1;
    public void StartGame()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(level.ToString());
    }

    public void Die()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("GameOver");
    }

}
