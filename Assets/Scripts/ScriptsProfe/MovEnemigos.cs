using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovEnemigos : MonoBehaviour
{
    public Transform[] puntosPatrulla;
    public float velocidadPatrulla;
    private int siguientePlataforma;
    private bool ordenPlataformas = true;

    public GameObject hijo;

    private SpriteRenderer theSR;

    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();

        
    }

    private void Update()
    {
        if (ordenPlataformas && siguientePlataforma + 1 >= puntosPatrulla.Length)
        {
            ordenPlataformas = false;

        }
        if (!ordenPlataformas && siguientePlataforma <= 0)
        {
            ordenPlataformas = true;

        }
        if (Vector2.Distance(transform.position, puntosPatrulla[siguientePlataforma].position) < 0.1f)
        {
            
            if (ordenPlataformas)
            {
                siguientePlataforma += 1;
                               
                    theSR.flipX = true;
 
                float newrot = 0;
                hijo.transform.localEulerAngles = new Vector3(hijo.transform.localEulerAngles.x, newrot, hijo.transform.localEulerAngles.z);
              
            }
            else
            {
                siguientePlataforma -= 1;
              
                    theSR.flipX = false;

                float newrot = 180;
                hijo.transform.localEulerAngles = new Vector3(hijo.transform.localEulerAngles.x, newrot, hijo.transform.localEulerAngles.z);
                
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, puntosPatrulla[siguientePlataforma].position, velocidadPatrulla * Time.deltaTime);
    }

   
}
