using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public float waitToRespawn;

    public int elementsColected;
    public int elementsColected2;

    public int contDeads = 0;



    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RespawnPlayer()
    {
        StartCoroutine(RespawnCo());
    }



    IEnumerator RespawnCo()
    {
        contDeads++;
        if (contDeads <= 2)
        {
            
            Playercontroler.instance.gameObject.SetActive(false);

            yield return new WaitForSeconds(waitToRespawn);

            GameObject.FindObjectOfType<Paneles>().panelPerder.SetActive(true);
            GameObject.FindObjectOfType<Paneles>().panelJuego.SetActive(false);

            Playercontroler.instance.gameObject.SetActive(true);

            Playercontroler.instance.transform.position = CheckPointController.instance.spawnPoint;

            PlayerHealthControllerScript.instance.currentHealth = PlayerHealthControllerScript.instance.maxHealth;

            UIControllerCanvasScript.instance.UpdateHealthDisplay();

        }
        if (contDeads == 3)
        {
            Playercontroler.instance.gameObject.SetActive(false);

            yield return new WaitForSeconds(waitToRespawn);

            GameObject.FindObjectOfType<Paneles>().panelJuego.SetActive(false);

            GameObject.FindObjectOfType<Paneles>().panelGameOver.SetActive(true);
            
            //Playercontroler.instance.gameObject.SetActive(true);

            //Playercontroler.instance.transform.position = CheckPointController.instance.spawnPoint;

            //PlayerHealthControllerScript.instance.currentHealth = PlayerHealthControllerScript.instance.maxHealth;

            //UIControllerCanvasScript.instance.UpdateHealthDisplay();
        }

    }

  
}
