using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CaptureBlack : MonoBehaviour
{	
	private void OnCollisionEnter(Collision collision)
{

	 if (collision.gameObject.tag == "WhitePiece") {
    Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }
	if(collision.gameObject.tag != "board" && collision.gameObject.tag != "WhitePiece"){
	Destroy(collision.gameObject);
}
}
}
