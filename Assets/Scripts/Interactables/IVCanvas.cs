using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IVCanvas : MonoBehaviour
{
    // TODO: Convert this into static object viewer
    public List<Item> imageHolders = new List<Item>();
    
    // public bool active;

    // public GameObject border;
    public void AddItem(Sprite pic){
        foreach(Item imgHolder in imageHolders){
            if (imgHolder.imageHolder.sprite == null){
                imgHolder.setImg(pic);
                break;
            }
        }
        // imageHolder.sprite = pic;
    }
    
    // public void selectItem(){

    //     if (active){
    //         active = false;
    //         border.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    //         Debug.Log("Item inactive");
    //     } else {
    //         active = true;
    //         // border.transform.localScale = new Vector3(1.2f, 1.2f, 1.0f);
    //         border.transform.localScale = new Vector3(1.2f, 1.2f, 1.0f);
    //         Debug.Log("Item active");
    //     }
    // }
}
