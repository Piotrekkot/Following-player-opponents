using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strzelanie : MonoBehaviour {
    public GameObject pocisk;
    public GameObject bron;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject pociskKopia = Instantiate<GameObject>(pocisk);
            pociskKopia.transform.position = bron.transform.position;
            pociskKopia.GetComponent<Rigidbody>().AddForce(bron.transform.forward * 1000);
        }
    }
}
