using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PowerUp_Inmune : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerHealthControllerScript.instance.Inmune();
            Destroy(gameObject);

        }
    }


}
