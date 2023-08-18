using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paneles : MonoBehaviour
{
    public static Paneles instance;

    private void Awake()
    {
        instance = this;
    }

    public GameObject panelGanar;
    public GameObject panelPerder;
    public GameObject panelGameOver;
    public GameObject panelJuego;
        


}
