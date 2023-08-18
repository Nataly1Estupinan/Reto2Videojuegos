using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaPuerta : MonoBehaviour
{
    //public AudioClip puertaAuido;
    //public AudioSource audioSource;


    public int numCollectable1;
    //= LevelManager.instance.elementsColected.ToString();
    public int numCollectable2;

    //public bool evaluarCollectable1;
    //public bool evaluarCollectable2;
    void Start()
    {
        
        //numCollectable1 = 10;
        //numCollectable2 = 10;
        Debug.Log(numCollectable1);
        Debug.Log(numCollectable2);
    }
   


    private void OnTriggerEnter2D(Collider2D collision)
    {
        numCollectable1 = LevelManager.instance.elementsColected;
        numCollectable2 = LevelManager.instance.elementsColected2;
        //Solo detecta colisiones del Player
        if (collision.CompareTag("Player"))
        {
            if (numCollectable1 >= 10 && numCollectable2 >= 10)
            {
                //Encuentro el objeto Puntaje en el juego
                //GameObject puntaje = GameObject.FindObjectOfType<Puntaje>().gameObject;
                //si el puntaje es cierto valor
                //if (numCollectable1 >= 10)

                // {
                Debug.Log(numCollectable1);
                Debug.Log(numCollectable2);
                
                //audioSource.PlayOneShot(puertaAuido);
                    //ejecutar aniamcion "door"
                    gameObject.GetComponent<Animator>().Play("door");
               // }
               // else
               // {
                    //Debug.Log("Te elementos por recoger.");
               // }
            //}
           // else if (evaluarCollectable2)
            //{
                //Encuentro el objeto Puntaje en el juego
                //GameObject llaves = GameObject.FindObjectOfType<KeysCanvas>().gameObject;
                //si el puntaje es cierto valor
               // if (numCollectable2 >=10)
               // {
               //     audioSource.PlayOneShot(puertaAuido);
                    //ejecutar aniamcion "door"
                //    gameObject.GetComponent<Animator>().Play("door");
                }
                else
                {
                Debug.Log(numCollectable1);
                Debug.Log(numCollectable2);
                Debug.Log("Te faltan elementos por recoger.");
                }
           // }
           // else
           // {
              //  audioSource.PlayOneShot(puertaAuido);
                //ejecutar aniamcion "door"
              //  gameObject.GetComponent<Animator>().Play("door");

           // }

        }
    }
    //public void Destruir()
    //{
      //  Destroy(gameObject);

    //}
}
