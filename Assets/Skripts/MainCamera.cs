using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform target;
    private Vector3 offset = new Vector3(0, 0, -3);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = target.localRotation;
        Vector3 offsetRotated = target.rotation * offset;
        transform.position = target.position + offsetRotated;
    }
}
