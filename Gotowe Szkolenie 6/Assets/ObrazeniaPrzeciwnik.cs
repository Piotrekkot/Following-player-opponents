using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObrazeniaPrzeciwnik : MonoBehaviour {

    int life = 100;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            life -= 20;

            if (life <= 0)
            {
                Die();
            }
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }


}


