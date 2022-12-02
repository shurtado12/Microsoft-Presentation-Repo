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
        if (Capture.hasAlreadyCaptured)
        {
            Turn.playIsActive = false;
            PlayEnded();
        }

        if (!Turn.playIsActive)
        {
            // This will be only done once
            if (Turn.whiteTurn && gameObject.tag == "WhitePiece")
            {
                allowed = true;
                print($"This is a white piece {gameObject.name} and its whites turn allowing movement");
                return;
            }

            if (!Turn.whiteTurn && gameObject.tag == "BlackPiece")
            {
                allowed = true;
                print($"This is a black piece {gameObject.name} and its blacks turn allowing movement");
                return;
            }

            allowed = false;
            ob = GetComponent<ObjectManipulator>();
            ob.AllowedManipulations = 0;
        }

    }

    public void PlayStarted()
    {
        print($"This is a {gameObject.tag}");

        ob = GetComponent<ObjectManipulator>();
        if (!allowed)
        {
            print($"Play Script {gameObject.name} I am NOT  allowed to move");

            ob.AllowedManipulations = TransformFlags.None;

            //To disable ob.AllowedManipulations  = 0;
        }
        else
        {
            Turn.playIsActive = true;
            print("Play Script I am allowed to move");
            ob.AllowedManipulations = TransformFlags.Move;
        }
    }

    public void PlayEnded()
    {
        print($"Play has ended for {gameObject.tag} {gameObject.name}");
        if (allowed)
        {
            print("TURN ENDED");
            allowed = false;
            ob = GetComponent<ObjectManipulator>();
            ob.AllowedManipulations = TransformFlags.None;
            Turn.whiteTurn = !Turn.whiteTurn;
            Turn.playIsActive = false;
        }
    }
}
