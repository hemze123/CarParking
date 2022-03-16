using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderCar2 : MonoBehaviour
{

     public GameObject FinalPanel;
     public GameObject Car1;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "P2"){
            Car1.GetComponent<Geri>().enabled = false;
            Car1.GetComponent<Ireli>().enabled = false;
           Invoke("FinalPaneli",2f);

        }

        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Object"){
            
            Invoke("Car2Collider",0.5f);

        }

      if(other.gameObject.tag == "Player"){
            
            Invoke("Car2Collider",0.5f);

        }

    }


    void Car2Collider(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void FinalPaneli(){
         FinalPanel.SetActive(true);
    }
}
