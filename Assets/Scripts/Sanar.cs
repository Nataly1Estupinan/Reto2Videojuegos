using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sanar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SanarPlayer()
    {
        if (PlayerHealthControllerScript.instance.currentHealth < 6)
        {
            PlayerHealthControllerScript.instance.currentHealth++;

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SanarPlayer();
            UIControllerCanvasScript.instance.UpdateHealthDisplay();
            Destroy(gameObject);


        }
    }
}
