using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ireli : MonoBehaviour
{
  List <Veri2> Liste;
    bool geriGayit = false;

    public GameObject TapToPlay;
    public GameObject Car2;

   

   private void Start() {
      Liste = new List<Veri2>();
   }

   void Update(){
     
       if(Input.GetKeyDown(KeyCode.X)){      //
        Basla();
       }

       if(Input.GetKeyUp(KeyCode.X)){          //
      Stop();
       }


   }

   private void FixedUpdate() {
     if(geriGayit){
       KecmiseQayit(); /////

     }
     else
     YaddasaYaz();
     
   }

   void KecmiseQayit(){
     if(Liste.Count> 0 ){
     transform.position = Liste[0].position;
     transform.rotation = Liste[0].rotasion;

     Liste.RemoveAt(0);
     }


     else 
      Stop();

   }

   void YaddasaYaz(){
      Veri2 gecmis = new Veri2{
        position =  transform.position,
        rotasion =  transform.rotation

      };
    //  Liste.Insert(0,gecmis);
      Liste.Add(gecmis);

              
   }
  

   void Basla(){
     geriGayit = true;
   }

   void Stop(){
     geriGayit = false;
   }

 

  public void TapToPlayButton(){
      Car2.GetComponent<CarMove>().enabled = true;
      Basla();
      TapToPlay.SetActive(false);
      
    }



}







public struct Veri2{
    public Vector3 position ;
    public Quaternion rotasion;
}
  