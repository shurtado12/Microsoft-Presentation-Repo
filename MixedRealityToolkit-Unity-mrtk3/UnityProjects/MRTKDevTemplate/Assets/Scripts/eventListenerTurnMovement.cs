//using System;
//using System.Collections.Generic;
//using Unity.Profiling;
//using UnityEngine;
//using UnityEngine.InputSystem;
//using UnityEngine.Serialization;
//using UnityEngine.XR.Interaction.Toolkit;

//using Microsoft.MixedReality.Toolkit.SpatialManipulation

using System.Collections.Generic;

using Microsoft.MixedReality.Toolkit.SpatialManipulation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class eventListenerTurnMovement : MonoBehaviour, IEventSystemHandler
{
    public static ObjectManipulator ob;


    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "BlackPiece")
        {
            print("IAM BOAT");
        }
        ob = GetComponent<ObjectManipulator>();
    }

    //OnSelectEntered
    // Update is called once per frame
    void Update()
    {
        if (!Turn.TurnBool)
        {
            if (ob.IsActiveHovered == true)
            {
                print("BOAT  are hovered");
                Turn.TurnBool = true;
            }
        }
    }

    public void BoatTurn()
    {
        print(" Hello the boats manipulation is done");
        coral.ob.enabled = true;
        ob.enabled = false;
    }
}


//public class eventListenerTurnMovement : MonoBehaviour
//{
//public static bool whiteTurn;
 
  //   void Start()
    //{
// om = GetComponent<ObjectManipulator>();
//print(gameObject.name);
    
//whiteTurn = true;


  //  }

    // Update is called once per frame
  //  void Update(){

   //     print(gameObject.name);
  //  if (whiteTurn== true && gameObject.tag=="BlackPiece")
   // whiteTurn = false;
      //gameObject.GetComponent<ObjectManipulator>().enabled= false;
  
   // }}
    

