using UnityEngine;
using System.Collections;

public class scanningcube : MonoBehaviour {

	public Transform target;

	public Color theColor;
	public Texture2D tex;
	public Vector2 pixelUV;


	void Update () {

		RaycastHit hit;
		Vector3 MeHim = target.position - this.transform.position;
		Ray scanningRay = new Ray(this.transform.position, MeHim.normalized);

		//Setup the "laser" of the scanner, the ray starting from the emittor and landing on the receptor.

		//Debug.DrawLine(transform.position, target.position, Color.blue, 0.05f, false);



		if (Physics.Raycast(scanningRay, out hit)){
			

			//cast the ray, get the texture that was collided with, get the info from the hit

			Debug.DrawLine(transform.position, target.position, Color.green, 0.001f, false);

			tex = hit.collider.GetComponent<MeshRenderer>().material.mainTexture as Texture2D;

			//get the texture offset
			Vector2 texOff = hit.collider.GetComponent<MeshRenderer>().material.GetTextureOffset("_MainTex");
			//print("this" + texOff);

			//add it to the uv
			pixelUV = hit.textureCoord + texOff;
			pixelUV.x *= tex.width;
			pixelUV.y *= tex.height;

			//get the position and color of the pixel hit by the laser
			Color hitColor = tex.GetPixel((int)pixelUV.x, (int)pixelUV.y);
			theColor = hitColor;
			//print("color is" + hitColor);
		
		}//else {print("I hit nothing");}


	}
}
