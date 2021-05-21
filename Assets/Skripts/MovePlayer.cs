using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 5f;
    private float angle = 0f;
    private Quaternion playerRotated;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); 
        float moveVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * moveVertical * Time.deltaTime * speed);

        //transform.rotation *= Quaternion.Euler(0, moveHorizontal * speed * 10 * Time.deltaTime, 0);
        angle += moveHorizontal * Time.deltaTime;
        Quaternion rotation = Quaternion.LookRotation(new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle)));
        transform.rotation = rotation;
    }

    public Quaternion GetQuaternion()
    {
        return playerRotated;
    }
}
