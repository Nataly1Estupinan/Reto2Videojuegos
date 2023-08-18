using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtBox : MonoBehaviour
{

    public GameObject deadEfect;

    [Range(0,100)] public float chanceToDrope;
    
    public GameObject collectible;
    public GameObject collectableSuelo;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            other.transform.parent.gameObject.SetActive(false);
           
            Instantiate(deadEfect, other.transform.position, other.transform.rotation);

            Playercontroler.instance.Bounce();

            float dropSelect = Random.Range(0, 100f);

            if (dropSelect <= chanceToDrope)
            {
                Instantiate(collectible, other.transform.position, other.transform.rotation);
            }
        }
        if (other.tag == "EnemySuelo")
        {
            other.transform.parent.gameObject.SetActive(false);

            Instantiate(deadEfect, other.transform.position, other.transform.rotation);

            Playercontroler.instance.Bounce();

            float dropSelect = Random.Range(0, 100f);

            if (dropSelect <= chanceToDrope)
            {
                Instantiate(collectableSuelo, other.transform.position, other.transform.rotation);
            }
        }
    }
}
