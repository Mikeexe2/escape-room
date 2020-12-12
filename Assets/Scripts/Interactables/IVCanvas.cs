using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IVCanvas : MonoBehaviour
{
    // TODO: Convert this into static object viewer
    public Image imageHolder;
    
    public bool active;

    public GameObject border;

    public void AddItem(Sprite pic){
        imageHolder.sprite = pic;
    }
    
    public void selectItem(){
        active = true;
        border.transform.localScale = new Vector3(1.2f, 1.2f, 1.0f);
        Debug.Log("Item active");
    }
}
