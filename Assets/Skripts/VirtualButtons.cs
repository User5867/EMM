using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtons : MonoBehaviour
{
    private float speed = 5f;
    private float angle = 0f;
    [SerializeField]
    private GameObject spieler;
    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for(int i = 0; i < vbs.Length; i++)
        {
            vbs[i].RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].RegisterOnButtonReleased(OnButtonReleased);
        }
    }
    private float moveVertical = 0;
    private float moveHorizontal = 0;
    
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "VirtualButtonLinks":
                moveHorizontal = 0;
                break;
            case "VirtualButtonRechts":
                moveHorizontal = 0;
                break;
            case "VirtualButtonOben":
                moveVertical = 0;
                break;
            case "VirtualButtonUnten":
                moveVertical = 0;
                break;
        }
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log(vb.name);
        switch (vb.VirtualButtonName)
        {
            case "VirtualButtonLinks":
                moveHorizontal = -1;
                break;
            case "VirtualButtonRechts":
                moveHorizontal = 1;
                break;
            case "VirtualButtonOben":
                moveVertical = 1;
                break;
            case "VirtualButtonUnten":
                moveVertical = -1;
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        spieler.transform.Translate(Vector3.forward * moveVertical * Time.deltaTime * speed);

        angle += moveHorizontal * Time.deltaTime;
        spieler.transform.rotation = Quaternion.LookRotation(new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle)));
    }
}
