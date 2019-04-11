using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCam : MonoBehaviour {

    void Update ()
    {
        if (Input.GetKey(KeyCode.UpArrow))

        {
            GetComponent<Camera>().fieldOfView--;
        }

        if (Input.GetKey(KeyCode.DownArrow))

        {
            GetComponent<Camera>().fieldOfView++;
        }
    }
}
