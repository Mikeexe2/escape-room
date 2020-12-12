using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Node : MonoBehaviour
{
    public Transform cameraPosition;
    public List<Node> reachableNodes = new List<Node>();
    
    public Node prevNode;

    [HideInInspector]
    public new Collider collider;

    [HideInInspector]
    public GameObject downButton;
    
    [HideInInspector]
    public GameObject leftButton;
    
    [HideInInspector]
    public GameObject rightButton;

    void Awake(){        
        downButton = GameObject.Find ("DownButton");
        rightButton = GameObject.Find ("RightButton");
        leftButton = GameObject.Find ("LeftButton");
        
        collider = GetComponent<Collider>();
        collider.enabled = false;
    }
    
    // Start is called before the first frame update
    void Start()
    {
    }

    void OnMouseDown() {
        Arrive();
    }

    public void turnLeft(){

        cameraPosition.rotation = Quaternion.Euler(new Vector3(0f, cameraPosition.rotation.eulerAngles.y - 90, 0f));
        
        Game.Instance.rig.AlignTo(cameraPosition);
    }
    
    public void turnRight(){

        cameraPosition.rotation = Quaternion.Euler(new Vector3(0f, cameraPosition.rotation.eulerAngles.y + 90, 0f));
        
        Game.Instance.rig.AlignTo(cameraPosition);
    }

    public void Back(){
        if (Game.Instance.currNode.prevNode != null){ 
            Game.Instance.currNode.prevNode.Arrive();
        }
    }



    public virtual void Arrive(){
        Game.Instance.currNode.Leave();

        Game.Instance.currNode = this;

        // toggle buttons
        if (Game.Instance.currNode.prevNode == null){
            downButton.SetActive(false);
            leftButton.SetActive(true);
            rightButton.SetActive(true);
        } else {
            downButton.SetActive(true);
            leftButton.SetActive(false);
            rightButton.SetActive(false);
        }

        // Move camera
        Game.Instance.rig.AlignTo(cameraPosition);

        // collider setup
        if (collider != null) {
            collider.enabled = false;
        }

        foreach(Node node in reachableNodes) {
            if (node.collider != null ) {
                node.collider.enabled = true;
            }
        }
    }

    public virtual void Leave() {

        foreach(Node node in reachableNodes) {
            if (node.collider != null ) {
                node.collider.enabled = false;
            }
        }
    }
}
