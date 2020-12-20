using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toolable : Interactable
{

    [HideInInspector]
    public Collider collider;

    public Item key;
    
    public override void interact(){

        // get key!

        if (key.active) {
            Game.Instance.endGame();
        }
    }

}