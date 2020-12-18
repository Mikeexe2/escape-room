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

    public void setImg(Sprite pic){
        Debug.Log("Setting image");
        imageHolder.sprite = pic;
    }

    private bool isOtherSelected(){
        foreach(Item item in iV.imageHolders){
            if (item.active){
                return true;
            }
        }
        return false;
    }
    
    public void selectItem(){

        if (isOtherSelected() || active == true){
            active = false;
            border.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            Debug.Log("Item inactive");

        } else {

            // make item disappear from room


            active = true;
            // border.transform.localScale = new Vector3(1.2f, 1.2f, 1.0f);
            border.transform.localScale = new Vector3(1.2f, 1.2f, 1.0f);
            Debug.Log("Item active");
        }
    }

    public void useItem(){
        Debug.Log("TODO");
    }
}