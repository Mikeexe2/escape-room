using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IVCanvas : MonoBehaviour
{
    // TODO: Convert this into static object viewer
    public List<Item> imageHolders = new List<Item>();

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
}
