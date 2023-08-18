using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{

    //public void CambiarEscena(int escenaObejtivo)
    //{
    //    SceneManager.LoadScene(escenaObejtivo);
    //}

    public float retraso = 1.0f; // Cambia esto al valor deseado en segundos
    public int escenaObjetivo;

    public void CambiarEscenaConRetraso()
    {
        // Invocar la funci�n para cambiar de escena despu�s del retraso
        Invoke("CambiarEscena", retraso);
    }

    private void CambiarEscena()
    {
        SceneManager.LoadScene(escenaObjetivo);
    }
}
