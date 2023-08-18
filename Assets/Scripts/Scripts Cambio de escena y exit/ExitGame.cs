using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    //public void Exit()
    //{
    //    Application.Quit();
    //}

    public float retraso = 1.0f; // Cambia esto al valor deseado en segundos
    
    public void ExitConRetraso()
    {
        // Invocar la función Exit después del retraso
        Invoke("Exit", retraso);
    }

    private void Exit()
    {
        Application.Quit();
    }


}
