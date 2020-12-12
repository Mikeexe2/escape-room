using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : Interactable
{

    public override void interact(){
        GameObject item = Instantiate(gameObject);

        item.transform.SetParent(Game.Instance.obsCamera.rig);
        item.transform.localPosition = Vector3.zero;
        item.transform.GetChild(0).localPosition = Vector3.zero;
        Game.Instance.obsCamera.model = item.transform;
        Game.Instance.obsCamera.gameObject.SetActive(true);

        Game.Instance.disableArrows();
    }
}