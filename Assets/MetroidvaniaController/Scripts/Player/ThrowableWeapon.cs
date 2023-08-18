using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowableWeapon : MonoBehaviour
{
	public Vector2 direction;
	public bool hasHit = false;
	public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		if ( !hasHit)
		GetComponent<Rigidbody2D>().velocity = direction * speed;
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //collision.gameObject.SendMessage("ApplyDamage", Mathf.Sign(direction.x) * 2f);
            collision.transform.gameObject.SetActive(false);
             ; ;
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
    }


    //public GameObject deadEfect;

    ////[Range(0, 100)] public float chanceToDrope;
    ////public GameObject collectible;
    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.tag == "Enemy")
    //    {
    //        other.transform.parent.gameObject.SetActive(false);

    //        gameObject.GetComponent<Animator>().Play("dead");
    //        // Destroy(gameObject);

    //        //Instantiate(deadEfect, other.transform.position, other.transform.rotation);

    //        //Playercontroler.instance.Bounce();

    //        //float dropSelect = Random.Range(0, 100f);

    //        //if (dropSelect <= chanceToDrope)
    //        //{
    //        //    Instantiate(collectible, other.transform.position, other.transform.rotation);
    //        //}

    //    }
    //    else if (other.tag != "Enemy")
    //    {
    //        //Destroy(gameObject);
    //    }
    //}
}
