using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueScript : MonoBehaviour
{
    private int sceneToContinue;
    public void ContinuGame()
    {
        
        sceneToContinue = PlayerPrefs.GetInt("Save");
        if (sceneToContinue != 0)
            SceneManager.LoadScene(sceneToContinue);
        
        else
        { SceneManager.LoadScene(1); }
            return;
    }
}
