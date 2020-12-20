using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoloProp : Node
{

    public Interactable interactable;

    void Start(){
        interactable = GetComponent<Interactable>();
    }

    public override void Arrive(){
        
        if (interactable != null){
            collider.enabled = true;
            interactable.enabled = true;
        }
        if (interactable != null && interactable.enabled){
            interactable.interact();
            return;
        }

    }

    public override void Leave(){

        if ( interactable != null){
            interactable.enabled = false;
        }
    }
}
