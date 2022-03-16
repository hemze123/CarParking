using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
   public GameObject StartButtonu;
   public GameObject ContinueButtonu;


    private void Start()
    {
       
    }
   
       
    public void StartGame()
    {
        SceneManager.LoadScene(1);

        PlayerPrefs.SetInt("Startb", 1);

         StartButtonu.SetActive(PlayerPrefs.GetInt("Startb") == 1);
   
       
    }

  

}
