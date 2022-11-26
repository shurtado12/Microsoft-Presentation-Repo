using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{ private MonoBehaviour movementOnTurn;
    // Start is called before the first frame update
    void Start()
    {
        movementOnTurn = GetComponent <MonoBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        
        movementOnTurn.enabled = false;
        
    }
}
