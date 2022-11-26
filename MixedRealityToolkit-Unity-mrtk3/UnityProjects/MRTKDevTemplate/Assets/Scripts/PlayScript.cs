using Microsoft.MixedReality.Toolkit.SpatialManipulation; 
using Microsoft.MixedReality.Toolkit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
 using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.SpatialManipulation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if(Turn.whiteTurn && gameObject.tag =="WhitePiece"){
            allowed = true;
            ob.AllowedManipulations = TransformFlags.Move;
        }
      else if (!Turn.whiteTurn && gameObject.tag == "BlackPiece"){
            allowed = true;
            ob.AllowedManipulations = TransformFlags.Move;
        }
        else {
            allowed = false;
              ob.AllowedManipulations = 0;
        }
        
    }

    public void PlayStarted(){
        if (!allowed){
          print("I am NOT  allowed to move");
          
                ob.AllowedManipulations =  TransformFlags.None;

        //To disable ob.AllowedManipulations  = 0;
       }
       else{

          print("I am allowed to move"); 
          ob.AllowedManipulations = TransformFlags.Move;
       }
      //  else gameObject.ob.
    }

        public void PlayEnded(){
       // if (allowed){
       //      allowed  = false;
        //     ifI(gameOb)
      //  }
    }
}
