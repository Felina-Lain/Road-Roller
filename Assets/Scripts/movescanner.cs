using UnityEngine;
using System.Collections;

public class movescanner : MonoBehaviour {

		public int markcount;
		public float speed;
		
		// Use this for initialization
		void Start () {
			markcount = 1;
		}

		// Update is called once per frame
		void Update () {

		//state machine, used to make the "scanner" move along the texture, between two given points
			switch (markcount) {

			case 0:
			Vector3 positio = this.transform.position;
			positio.x -= speed;
			this.transform.position = positio;

				break;

			case 1:
			Vector3 position = this.transform.position;
			position.x += speed;
			this.transform.position = position;

				break;

			}
		}

		void OnTriggerEnter(Collider other) {

		if (other.tag == "Mark1") {
				markcount = 1;
			}
			if (other.tag == "Mark2") {
				markcount = 0;
			}

		}
	}
