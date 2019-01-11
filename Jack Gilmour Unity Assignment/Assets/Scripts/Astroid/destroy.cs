using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D hitInfo)
            {
                Debug.Log(hitInfo.name);
                Destroy(gameObject);
            }

    void OnCollisionEnter(Collision otherObj)
    {
        if (otherObj.gameObject.tag == "Missile")
        {
            Destroy(gameObject, .5f);
        }
    }

}
