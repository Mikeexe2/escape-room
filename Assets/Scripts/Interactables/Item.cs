using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{

    public Image imageHolder;
    public bool active;
    public GameObject border;

    public IVCanvas iV;

    public bool isKey = false;

    public void setImg(Sprite pic){
        imageHolder.sprite = pic;
        if (pic.name.Contains("key")){
            this.isKey = true;
        }
    }

    private bool isOtherSelected(){
        foreach(Item item in iV.imageHolders){
            if (item.active){
                item.deselectItem();
                return true;
            }
        }
        return false;
    }

    public void deselectItem(){
        active = false;
        border.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
    
    public void selectItem(){

        if (active == true){
            deselectItem();

        } else if (isOtherSelected()){
            active = true;
            border.transform.localScale = new Vector3(1.2f, 1.2f, 1.0f);
        } else {
            active = true;
            border.transform.localScale = new Vector3(1.2f, 1.2f, 1.0f);
        }
    }

    public void useItem(){
        // remove item from inventory
        Debug.Log("TODO");
    }
}