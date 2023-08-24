using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaPuerta : MonoBehaviour
{

    public int numCollectable1;

    public int numCollectable2;

    [SerializeField] private Animator padrePuerta;

    
   


    private void OnTriggerEnter2D(Collider2D collision)
    {
        numCollectable1 = LevelManager.instance.elementsColected;
        numCollectable2 = LevelManager.instance.elementsColected2;
        //Solo detecta colisiones del Player
        if (collision.CompareTag("Player"))
        {
            if (numCollectable1 >= 10 && numCollectable2 >= 10)
            {
               
                     padrePuerta.Play("door");

                //gameObject.GetComponent<Animator>().Play("door");
            }
            else{
                
                Debug.Log("Te faltan elementos por recoger.");
            }
         

        }
    }
  
}
