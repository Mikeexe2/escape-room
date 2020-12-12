using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop : Node
{

    public Interactable interactable;

    void Start(){
        interactable = GetComponent<Interactable>();
    }

    public override void Arrive(){
        
        if (interactable != null && interactable.enabled){
            interactable.interact();
            return;
        }

        base.Arrive();

        if (interactable != null){
            collider.enabled = true;
            interactable.enabled = true;
        }
    }

    public override void Leave(){
        base.Leave();

        if ( interactable != null){
            interactable.enabled = false;
        }
    }
}
