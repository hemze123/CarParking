using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Geri : MonoBehaviour
{
  List <Veri> Liste; //
    bool geriGayit = false;

    public GameObject TapToPlay;
    public GameObject Car2;
    public GameObject Particle1;
    public GameObject Particle2;

   

   private void Start() {
       Liste = new List<Veri>();
   }

   void Update(){
       if(Input.GetKeyDown(KeyCode.Z)){
         Basla();
       }

       if(Input.GetKeyUp(KeyCode.Z)){
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
      Veri gecmis = new Veri{
        position =  transform.position,
        rotasion =  transform.rotation

      };
      Liste.Insert(0,gecmis);
     // gecmisListe.Add(gecmis);
        
   }

 public  void Basla(){
     geriGayit = true;
   }

  public void Stop(){
     geriGayit = false;
   }

 private void OnTriggerEnter(Collider other) {

        if ( other.gameObject.tag == "P")
        {
            other.GetComponent<BoxCollider>().enabled = false;

            GetComponent<CarMove>().enabled = false;
      
             Particle2.SetActive(true);
             Particle1.SetActive(true);
            Invoke("Parking1",1f);
        
        }         

    }


    private void OnCollisionEnter(Collision other) {
       if(other.gameObject.tag == "Object"){
      Invoke("Collider",0.8f);
     }
    }


    void Collider(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    void Parking1(){
      Basla();
      Invoke("TapToPlayButtonActive",3f);
    }


   
    void TapToPlayButtonActive(){
      TapToPlay.SetActive(true);
    }

}


public struct Veri{
    public Vector3 position ;
    public Quaternion rotasion;
}




























/*
List <GecmisVeri> gecmisListe;
    bool gecmiseSariyormu = false;

   //bool yeniden =false;

   private void Start() {
       gecmisListe = new List<GecmisVeri>();
   }

   void Update(){
       if(Input.GetKeyDown(KeyCode.Z)){
         GecmiseSarmayiBaslat();
       }

       if(Input.GetKeyUp(KeyCode.Z)){
         GecmiseSarmayidurdur();
       }
   }

   private void FixedUpdate() {
     if(gecmiseSariyormu){
       GecmiseSar();

     }
     else
      GecmisiKaydet();
   }

   void GecmiseSar(){
     if(gecmisListe.Count> 0 ){
     transform.position = gecmisListe[0].position;
     transform.rotation = gecmisListe[0].rotasion;

     gecmisListe.RemoveAt(0);
     }
     else 
      GecmiseSarmayidurdur();

   }

   void GecmisiKaydet(){
      GecmisVeri gecmis = new GecmisVeri{
        position =  transform.position,
        rotasion =  transform.rotation
      };
      gecmisListe.Insert(0,gecmis);
      
           
   }

   void GecmiseSarmayiBaslat(){
     gecmiseSariyormu = true;
   }

   void GecmiseSarmayidurdur(){
     gecmiseSariyormu = false;
   }
}


public struct GecmisVeri{
    public Vector3 position ;
    public Quaternion rotasion;
*/



















/*
List <GecmisVeri> gecmisListe;
    List <GecmisVeri_1> gecmisListe_1;
    bool gecmiseSariyormu = false;

   //bool yeniden =false;

   private void Start() {
       gecmisListe = new List<GecmisVeri>();
       gecmisListe_1 = new List<GecmisVeri_1>();
   }

   void Update(){
       if(Input.GetKeyDown(KeyCode.Z)){
         GecmiseSarmayiBaslat();
       }

       if(Input.GetKeyUp(KeyCode.Z)){
         GecmiseSarmayidurdur();
       }

       if(Input.GetKeyDown(KeyCode.V)){  //+++++++++++
         GelecekSar();
       }

       if(Input.GetKeyUp(KeyCode.V)){ //++++++++++++++++
         GelecekSarmayiDurdur();
       }
   }

   private void FixedUpdate() {
     if(gecmiseSariyormu){
       GecmiseSar();

     }
     else
      GecmisiKaydet();
   }

   void GecmiseSar(){
     if(gecmisListe.Count> 0 ){
     transform.position = gecmisListe[0].position;
     transform.rotation = gecmisListe[0].rotasion;

     gecmisListe.RemoveAt(0);
     }
     else 
      GecmiseSarmayidurdur();

   }`

   void GelecekSar(){ //++++++++++++++++
     if(gecmisListe_1.Count< 0 ){
     transform.position = gecmisListe_1[0].position;
     transform.rotation = gecmisListe_1[0].rotasion;

     gecmisListe_1.RemoveAt(0);
     }
     else 
      GelecekSarmayiDurdur();

   }

   //+++++++++++++++++
   void GelecekSar(){
     if(gecmisListe.Count> 0 ){
     transform.position = gecmisListe[0].position;
     transform.rotation = gecmisListe[0].rotasion;

     gecmisListe.RemoveAt(0);
     }
     else 
      GecmiseSarmayidurdur();

   }

   //+++++++++++++++++++++++

   void GecmisiKaydet(){
      GecmisVeri gecmis = new GecmisVeri{
        position =  transform.position,
        rotasion =  transform.rotation
      };
      gecmisListe.Insert(0,gecmis);
      
           
   }

   void GecmiseSarmayiBaslat(){
     gecmiseSariyormu = true;
   }

   void GecmiseSarmayidurdur(){
     gecmiseSariyormu = false;
   }
}


public struct GecmisVeri{
    public Vector3 position ;
    public Quaternion rotasion;

    */