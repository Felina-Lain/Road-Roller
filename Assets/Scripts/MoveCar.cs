using UnityEngine;
using System.Collections;

public class MoveCar : MonoBehaviour {

	//classic simple quick controller script, left and right only
  
         void Update ()
         {
                 if (Input.GetKey(KeyCode.LeftArrow))
                 {
                         Vector3 position = this.transform.position;
                         position.x--;
                         this.transform.position = position;
                 }
                 if (Input.GetKey(KeyCode.RightArrow))
                 {
                         Vector3 position = this.transform.position;
                         position.x++;
                         this.transform.position = position;
                 }
                
 }
 }