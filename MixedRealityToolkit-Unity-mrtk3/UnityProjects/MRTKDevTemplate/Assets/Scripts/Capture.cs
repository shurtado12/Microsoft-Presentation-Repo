using UnityEngine;


public class Capture : MonoBehaviour
{
    private bool pieceIsGrabbed = false;
    private bool hasAlreadyCaptured = false;
    public void uponGrab()
    {// Entered upon held
     //   hasAlreadyCaptured = false;
        pieceIsGrabbed = true;
    }
    public void uponRelease()
    {//entered upon release

        pieceIsGrabbed = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == gameObject.tag)
        {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }
        if (gameObject.tag == "BlackPiece" && !Turn.whiteTurn && pieceIsGrabbed)
        { // This is black turn
            if (collision.gameObject.tag != "board" && collision.gameObject.tag == "WhitePiece")
            {
                Destroy(collision.gameObject); // Destroys enemy White Piece
                hasAlreadyCaptured = true;
                Turn.whiteTurn = true;//ends black turn


            }
        }
        else if (gameObject.tag == "WhitePiece" && Turn.whiteTurn && pieceIsGrabbed)
        { //This is white turn
            if (collision.gameObject.tag != "board" && collision.gameObject.tag == "BlackPiece")
            {
                Destroy(collision.gameObject);// Destroys enemy White Piece
                hasAlreadyCaptured = true;
                Turn.whiteTurn = false;// Ends White Turn

            }
        }
    }
}

