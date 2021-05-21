using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSkript : MonoBehaviour
{
    [SerializeField]
    private Transform myPrefab;
    [SerializeField]
    private Transform myPartikle;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            Transform temp = Instantiate(myPrefab, new Vector3(Random.Range(-5.0f, 5.0f), 1, Random.Range(-5.0f, 5.0f)), Quaternion.Euler(0, Random.Range(0.0f, 360.0f), 0), gameObject.transform);
            Instantiate(myPartikle, new Vector3(temp.position.x, temp.position.y, temp.position.z), Quaternion.identity, temp);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
