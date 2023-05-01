using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{

    public static bool GameIsOver = false;
    public GameObject endMenuUI;

    public void GameOver()
    {
        SceneManager.LoadScene("Level1");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
