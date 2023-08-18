using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Solo detecta colisiones del Player
        if (collision.CompareTag("Player"))
        {
            //Mostrar PanelGanar
            Debug.Log("Ganaste.");
            GameObject.FindObjectOfType<Paneles>().panelGanar.SetActive(true);
            //GameObject.FindObjectOfType<Paneles>().panelJuego.SetActive(false);
            GameObject.FindObjectOfType<Paneles>().panelJuego.SetActive(false);


        }
    }
}
