using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D hitInfo) //Destroys the asteroid when hit with another collider
            {
                Debug.Log(hitInfo.name);
                Destroy(gameObject);
            }

    private void Update()
    {
        Destroy(gameObject, 5f); //Destroys the bullet after 1 second
    }

}
