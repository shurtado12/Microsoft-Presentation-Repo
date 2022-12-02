using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.SpatialManipulation;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayScript : MonoBehaviour, IEventSystemHandler
{
    public static ObjectManipulator ob;
    private bool allowed;
    // Start is called before the first frame update
    void Start()
    {
        ob = GetComponent<ObjectManipulator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Turn.whiteTurn && gameObject.tag == "WhitePiece")
        {
            allowed = true;
            ob.AllowedManipulations = TransformFlags.Move;
            print("This is a white piece and its whites turn Enabling movement");
        }
        else if (!Turn.whiteTurn && gameObject.tag == "BlackPiece")
        {
            allowed = true;
            ob.AllowedManipulations = TransformFlags.Move;
            print("This is a black piece and its blacks turn Enabling movement");
        }
        else
        {

            allowed = false;
            ob.AllowedManipulations = 0;
        }

    }

    public void PlayStarted()
    {
        if (gameObject.tag == "WhitePiece")
        {
            print("This is a WhitePiece and its blacks turn disabling movement");
        }
        if (gameObject.tag == "BlackPiece")
        {
            print("This is a BlackPiece and its whites turn disabling movement");
        }

        if (!allowed)
        {
            print("Play Script I am NOT  allowed to move");

            ob.AllowedManipulations = 0;

            //To disable ob.AllowedManipulations  = 0;
        }
        else
        {

            print("Play Script I am allowed to move");
            ob.AllowedManipulations = TransformFlags.Move;
        }
        //  else gameObject.ob.
    }

    public void PlayEnded()
    {
                    if (gameObject.tag == "WhitePiece")
            {
                print("This is a WhitePiece and its blacks turn disabling movement");
            }
            if (gameObject.tag == "BlackPiece")
            {
                print("This is a BlackPiece and its whites turn disabling movement");
            }
        if (allowed)
        {
            print("Play Script has ended disabing move");

            ob.AllowedManipulations = TransformFlags.None;
        }
    }
}
