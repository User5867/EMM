using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMyPrefab : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 50f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.rotation *= Quaternion.Euler(0, speed * Time.deltaTime, 0);
    }
}
