using UnityEngine;
using System.Collections;

public class roadmove : MonoBehaviour {

	public float screenSpeed;	
	static public float scrollSpeed;
	public Renderer rend;
	static public float offset;

	void Start() {
		
		rend = GetComponent<Renderer>();
	}

	void Update() {
		
		scrollSpeed = screenSpeed / 1000;

		if (Input.GetKey (KeyCode.UpArrow)) {
			offset += scrollSpeed;
			print("this" + offset);
			rend.material.SetTextureOffset ("_MainTex", new Vector2 (0, offset));
		}
	}
}