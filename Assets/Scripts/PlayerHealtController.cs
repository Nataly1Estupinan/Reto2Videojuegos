using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthControllerScript : MonoBehaviour
{
    public static PlayerHealthControllerScript instance;

    public int currentHealth, maxHealth;

    public float invicibleLength;
    public float invicibleCounter;

    private SpriteRenderer theSR;

    public GameObject deadfect;

    private void Awake()
    {
        instance = this; 
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
     
        if (invicibleCounter > 0)
        {
            invicibleCounter -= Time.deltaTime;

        }

        if (invicibleCounter <= 0)
        {
                theSR.color = new Color(theSR.color.r,theSR.color.g,theSR.color.b,1f);
        }
        
    }
    public void DealDamage()
    {
        if (invicibleCounter <= 0)
        {
            currentHealth--;

            Playercontroler.instance.anim.SetTrigger("Hurt");

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                Instantiate(deadfect, Playercontroler.instance.transform.position, Playercontroler.instance.transform.rotation);
                LevelManager.instance.RespawnPlayer();
            }
            else
            {
                invicibleCounter = invicibleLength;
                theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, .5f);

                Playercontroler.instance.Knockback();
            }
            UIControllerCanvasScript.instance.UpdateHealthDisplay();
        }
        
    }

    public void Inmune()
    {
     
     invicibleCounter =5;
     theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, .5f);

        

    }

}
