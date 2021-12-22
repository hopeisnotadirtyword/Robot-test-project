using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotTest : MonoBehaviour
{
   
    public Color metallic;
    public Color hilight;
    Renderer rend;
    public GameObject lowerArmL;
    public GameObject handL;

    public Text status;
    public Text reset;

    public Transform originPoint;
    public Transform detatchedPoint;
    bool offPosition;

    public Renderer leftLowerArm;
    public Renderer leftHand;

    void Start()
    {
        rend = GetComponent<Renderer>();
        offPosition = false;
        reset.gameObject.SetActive(false);
        
    }

    void OnMouseEnter()
    {
        rend.material.SetColor("_Color", hilight);
        leftLowerArm.material.SetColor("_Color", hilight);
        leftHand.material.SetColor("_Color", hilight);
    }

    private void OnMouseDown()
    {
        DetatchRobotArm();
        reset.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        rend.material.SetColor("_Color", Color.clear);
        leftLowerArm.material.SetColor("_Color", Color.clear);
        leftHand.material.SetColor("_Color", Color.clear);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            this.gameObject.transform.position = originPoint.position;
            status.text = "STATUS: ARM ATTATCHED";
            reset.gameObject.SetActive(false);
        }
    }

    void AttatchRobotArm()
    {
        this.gameObject.transform.position = originPoint.position;
        status.text = "STATUS: ARM ATTATCHED";
    }

    void DetatchRobotArm()
    {
        this.gameObject.transform.position = detatchedPoint.position;
        status.text = "STATUS: ARM DETATCHED";
        offPosition = true;
    }
}
