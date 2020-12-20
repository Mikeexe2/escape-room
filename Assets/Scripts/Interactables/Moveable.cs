using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moveable : Interactable
{

    [HideInInspector]
    public bool active;

    [HideInInspector]
    public Collider collider;

    public Transform activeState;
    public Transform restingState;
    
    public override void interact(){

        Transform currTransform = GetComponent<Transform>();
        collider = GetComponent<Collider>();

        if (active == true){
            active = false;
            currTransform.position = restingState.position;
            Debug.Log("Item inactive");

        } else {

            active = true;
            currTransform.position = activeState.position;
            Debug.Log("Item active");
        }
    }

}