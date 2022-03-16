using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Save : MonoBehaviour
{

    private int currentSceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("Save", currentSceneIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void NextLevelButton()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       
    }
}
