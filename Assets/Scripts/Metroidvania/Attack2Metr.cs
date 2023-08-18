using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacke : MonoBehaviour
{
    public GameObject throwableObject;
    private Transform transformWeapon;

    private void Awake()
    {

    }

    void Start()
    {
        transformWeapon = GetComponent<Transform>();
    }

    void Update()
    {
             

        if (Playercontroler.instance.theSR.flipX == true)
        {
            transform.transform.localScale = new Vector3(-1, -1, -1);
        }
        else
        {
            transform.transform.localScale = new Vector3(1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            GameObject throwableWeapon = Instantiate(throwableObject, transform.position + new Vector3(transform.localScale.x * 0.5f, -0.2f), Quaternion.identity) as GameObject;
            Vector2 direction = new Vector2(transform.localScale.x, 0);
            throwableWeapon.GetComponent<ThrowableWeapon>().direction = direction;
            throwableWeapon.name = "ThrowableWeapon";

        }
    }
   

}
