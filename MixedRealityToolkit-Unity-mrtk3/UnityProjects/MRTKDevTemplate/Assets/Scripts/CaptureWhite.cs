using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CaptureWhite : MonoBehaviour
{	
	private void OnCollisionEnter(Collision collision)
{
	if (collision.gameObject.tag == "BlackPiece") {
    Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }
	
	if(collision.gameObject.tag != "board" && collision.gameObject.tag != "BlackPiece"){
	Destroy(collision.gameObject);
}
}
}
