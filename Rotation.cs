using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRotate : MonoBehaviour
{
  public float speed;

     void Update(){

       if(Input.GetKey(KeyCode.A))

     {
         transform.Rotate(Vector3.up * speed * Time.deltaTime);
     }

     if(Input.GetKey(KeyCode.W))

     {
         transform.Rotate(Vector3.right * speed * Time.deltaTime);
     }

     if(Input.GetKey(KeyCode.D))

     {
         transform.Rotate(Vector3.down * speed * Time.deltaTime);
     }

     if(Input.GetKey(KeyCode.S))

     {
         transform.Rotate(Vector3.left * speed * Time.deltaTime);
     }

   }
 }
