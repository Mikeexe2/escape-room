using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageViewer : Interactable
{
    public Sprite pic;

    public override void interact(){
        //put image up
        Game.Instance.ivCanvas.AddItem(pic);
    }

}
