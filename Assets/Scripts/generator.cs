using UnityEngine;
using System.Collections;

public class generator : MonoBehaviour {

	public GameObject scanner;
	public GameObject toSpawn;
	public Color colorToCheck;
	public float Chrono1;
	public float Chrono2;


	[Header("If not a Sign prefab, ignore this.")]
	public Texture[] textureList;

	// Update is called once per frame
	void Update () {

		//check if we are moving, because else spawning stuff is useless
		if(Input.GetKey(KeyCode.UpArrow)){

		Color toCheckCol = scanner.GetComponent<scanningcube> ().theColor;
			

			//check what the color of the pixel is, so we know what we are allowed to spawn there
		if (toCheckCol == colorToCheck) {

			float Chrono = Random.Range(Chrono1, Chrono2);
			Chrono -= Time.deltaTime;


				//Random placing of the object by random time between each spawn
			if(Chrono <= 0){
			GameObject clone;
			clone = Instantiate(toSpawn.gameObject, transform.position, transform.rotation) as GameObject;
			//spawning of the object

			clone.transform.position = scanner.transform.position;



			if(toSpawn.name == "Sign"){
						//for signs, random texture
			Transform childobj;
			childobj = clone.transform.FindChild("Plane");
			childobj.GetComponent<Renderer>().material.SetTexture ("_MainTex", textureList[Random.Range(0, textureList.Length)]);

					}
				}
			}
		}
	}
}
