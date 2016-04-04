using UnityEngine;
using System.Collections;

public class OutRoad : MonoBehaviour {

	public GameObject car;
	public Color green;
	public Vector3 startPos;
	//public float speed;


	void Start () {

		startPos = this.transform.position;
	
	}
	

	void Update () {

		Color toCheckCol = car.GetComponent<scanningcube> ().theColor;
		//get the current scanned color pixel from the car
	
		//check if color is green, so not road, and if so, bring Car back to the road
		if (toCheckCol == green) {
			print ("sortie");
			car.GetComponent<MoveCar> ().enabled = false;

			//attempt to make it smooth instead of instant + slow down the car

			//float step = speed * Time.deltaTime;
			//transform.position = Vector3.MoveTowards(transform.position, startPos, step);


			this.transform.position = startPos;
			car.GetComponent<MoveCar> ().enabled = true;
		
		}
	}
}