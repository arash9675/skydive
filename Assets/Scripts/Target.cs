using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float minimumXPosition = -6f;
        float maximumXPosition = 6f;
        float minimumZPosition = -6f;
        float maximumZPosition = 5.2f;
        transform.position=new Vector3(Random.Range(minimumXPosition,maximumXPosition),
        transform.position.y,Random.Range(minimumZPosition,maximumZPosition));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
