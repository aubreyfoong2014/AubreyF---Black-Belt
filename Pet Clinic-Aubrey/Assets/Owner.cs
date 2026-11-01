using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Owner : MonoBehaviour
{
    public Transform deskfront;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.MoveTowards(transform.position.x, deskfront.position.x, .02f), 2, Mathf.MoveTowards(transform.position.z, deskfront.position.z, .02f));
    }
}
