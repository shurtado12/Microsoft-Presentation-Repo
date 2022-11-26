//using System;
//using System.Collections.Generic;
//using Unity.Profiling;
//using UnityEngine;
//using UnityEngine.InputSystem;
//using UnityEngine.Serialization;
//using UnityEngine.XR.Interaction.Toolkit;



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
    

using Microsoft.MixedReality.Toolkit.SpatialManipulation; // this was missing
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
        if (gameObject.tag.Contains("BlackPiece") || gameObject.tag == "WhitePiece")
        {
            print("This is a chess piece");
        }
        ob = GetComponent<ObjectManipulator>();


       
    }

    //OnSelectEntered
    // Update is called once per frame
    void Update()
    {

            if (ob.IsGrabSelected == true)
            {
               ob.enabled = true;
                
            }
   }

    public void BoatTurn()
    {
        print("");
    }
}