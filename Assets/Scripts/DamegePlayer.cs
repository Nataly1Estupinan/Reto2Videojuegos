using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamegePlayerScript : MonoBehaviour
{
    public bool puedeMorir;
    public bool enemySuelo;

    public GameObject deadEfect;

    [Range(0, 100)] public float chanceToDrope;
    public GameObject collectible;
    public GameObject collectibleSuelo;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerHealthControllerScript.instance.DealDamage();

        }
        
        if (puedeMorir)
            {
                if (other.CompareTag("Bala"))
                {
                    Destroy(other.transform.gameObject);
                    Destroy(transform.parent.gameObject);



                    Instantiate(deadEfect, other.transform.position, other.transform.rotation);

                    Playercontroler.instance.Bounce();

                    float dropSelect = Random.Range(0, 100f);

                    if (dropSelect <= chanceToDrope)
                    {
                        Instantiate(collectible, other.transform.position, other.transform.rotation);
                    }


                }
        }       
        
        if (enemySuelo)
        {
            if (other.CompareTag("Bala"))
            {
               // Destroy(other.transform.gameObject);
                Destroy(transform.parent.gameObject);
                other.transform.gameObject.SetActive(false);


                Instantiate(deadEfect, other.transform.position, other.transform.rotation);

                Playercontroler.instance.Bounce();

                float dropSelect = Random.Range(0, 100f);

                if (dropSelect <= chanceToDrope)
                {
                    Instantiate(collectibleSuelo, other.transform.position, other.transform.rotation);
                }


            }
        }

    }
}
