using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    public GameObject startMenuUI;
    public static bool StartMenu = true;

    public void Play()
    {
        startMenuUI.SetActive(false);
        Time.timeScale = 1f;
        StartMenu = false;
    }
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
