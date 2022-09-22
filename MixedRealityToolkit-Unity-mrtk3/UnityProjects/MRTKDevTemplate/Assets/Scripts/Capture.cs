



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Capture: MonoBehaviour
{	

	private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag == gameObject.tag) {
    Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
       }
   if(gameObject.tag =="BlackPiece"){
if(collision.gameObject.tag != "board" && collision.gameObject.tag == "WhitePiece" ){
	Destroy(collision.gameObject);
  
}
}
else if (gameObject.tag == "WhitePiece" ){
    if(collision.gameObject.tag != "board" && collision.gameObject.tag == "BlackPiece" ){
	Destroy(collision.gameObject);

}
}
}
}

