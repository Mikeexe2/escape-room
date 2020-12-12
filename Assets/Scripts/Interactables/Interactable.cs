using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// can only be used with Props
public abstract class Interactable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.enabled = false;
    }

    public virtual void interact(){
        Debug.Log("Interacting with "+ name);
    }
}
