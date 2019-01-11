using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{

    public Transform firepoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //Shoots a bullet everytime I press the left mouse button
        {
            Shoot();
        }
    }

    void Shoot ()
    {
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation); //Sets the position and rotation of the bullet from the firepoint
    }

}

