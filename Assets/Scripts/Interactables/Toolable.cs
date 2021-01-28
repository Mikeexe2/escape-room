using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toolable : Interactable
{

    [HideInInspector]
    public Collider collider;

    public List<Item> keylist;
    
    public override void interact(){

        // get key!
        string keyname = Game.Instance.theKey;

        for (int i=0; i<keylist.Count; i++){
            Item item = keylist[i];
            if (item.imageHolder.sprite != null && item.imageHolder.sprite.name == keyname && item.active){
                Game.Instance.endGame();
            }
        }
    }

}