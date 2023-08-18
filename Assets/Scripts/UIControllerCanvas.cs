using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControllerCanvasScript : MonoBehaviour
{
    public static UIControllerCanvasScript instance;

    public Image Heart1, Heart2, Heart3;

    public Sprite heartFull, heartEmpty, heartHalf;

    public Text coll1Text, coll2Text;




    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        UpdateCollCount1();
        UpdateCollCount2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateHealthDisplay()
    {
        switch(PlayerHealthControllerScript.instance.currentHealth)
        {
            case 6:
                Heart1.sprite = heartFull;
                Heart2.sprite = heartFull;
                Heart3.sprite = heartFull;

                break;
            case 5:
                Heart1.sprite = heartFull;
                Heart2.sprite = heartFull;
                Heart3.sprite = heartHalf;

                break;
            case 4:
                Heart1.sprite = heartFull;
                Heart2.sprite = heartFull;
                Heart3.sprite = heartEmpty;

                break;
            case 3:
                Heart1.sprite = heartFull;
                Heart2.sprite = heartHalf;
                Heart3.sprite = heartEmpty;

                break;
                
            case 2:
                Heart1.sprite = heartFull;
                Heart2.sprite = heartEmpty;
                Heart3.sprite = heartEmpty;

                break;
               
            case 1:
                Heart1.sprite = heartHalf;
                Heart2.sprite = heartEmpty;
                Heart3.sprite = heartEmpty;

                break;
                
            case 0:
                Heart1.sprite = heartEmpty;
                Heart2.sprite = heartEmpty;
                Heart3.sprite = heartEmpty;

                break;
            default:
                Heart1.sprite = heartEmpty;
                Heart2.sprite = heartEmpty;
                Heart3.sprite = heartEmpty;

                break;

        }
    }

    public void UpdateCollCount1()
    {
        coll1Text.text = LevelManager.instance.elementsColected.ToString();
    }
    public void UpdateCollCount2()
    {
        coll2Text.text = LevelManager.instance.elementsColected2.ToString();
    }

}
