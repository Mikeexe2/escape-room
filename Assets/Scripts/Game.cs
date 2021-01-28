using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : Singleton<Game>
{

    public Node startNode;
    // [HideInInspector]
    public Node currNode;

    public Node endNode;

    public CameraRig rig;

    public ObsCamera obsCamera;
    public IVCanvas ivCanvas;

    public GameObject closeObserverButton;

    [HideInInspector]
    public int keyNum;

    [HideInInspector]
    public string theKey;

    public List<ImageViewer> keys;

    // public Button downButton;

    public void getRandomKeyNum(){

        int numKeys = keys.Count;
        
        System.Random randomNumGen = new System.Random();
        this.keyNum = randomNumGen.Next(numKeys);
        this.theKey = this.keys[this.keyNum].pic.name;
        Debug.Log(this.theKey);
    }

    void Start() {
        startNode.Arrive();
        obsCamera.gameObject.SetActive(false);
        closeObserverButton.SetActive(false);
        getRandomKeyNum();
    }

    public void disableArrows(){        
        currNode.downButton.SetActive(false);
        currNode.rightButton.SetActive(false);
        currNode.leftButton.SetActive(false);
        closeObserverButton.SetActive(true);
    }
    
    public void enableArrows(){        
        closeObserverButton.SetActive(false);
    }

    public void closeObsever(){
        obsCamera.close();
        obsCamera.gameObject.SetActive(false);

        currNode.GetComponent<Prop>().interactable.enabled = false;
        currNode.Arrive();
        enableArrows();
    }

    public void endGame(){
        endNode.Arrive();
        currNode.downButton.SetActive(false);
        currNode.rightButton.SetActive(false);
        currNode.leftButton.SetActive(false);
        Debug.Log("Game over");
        Destroy(ivCanvas.gameObject);
    }

    // void Update() {
    //     if (Input.GetMouseButtonDown(1) && currNode.GetComponent<Prop>() != null) {
    //         currNode.GetComponent<Prop>().loc.Arrive();
    //     }
    // }
}
