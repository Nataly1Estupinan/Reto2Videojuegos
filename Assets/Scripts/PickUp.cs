using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public bool isCollectable1;
    public bool isCollectable2;

    private bool isCollected;

    public GameObject pickUpEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")&& !isCollected)
        {
            if (isCollectable1)
            {
                LevelManager.instance.elementsColected++;
                UIControllerCanvasScript.instance.UpdateCollCount1();

                Instantiate(pickUpEffect, transform.position, transform.rotation);


                isCollected = true;
                Destroy(gameObject);
            }
            if (isCollectable2)
            {
                LevelManager.instance.elementsColected2++;
                UIControllerCanvasScript.instance.UpdateCollCount2();

                Instantiate(pickUpEffect, transform.position, transform.rotation);


                isCollected = true;
                Destroy(gameObject);
            }
        }
    }
}
