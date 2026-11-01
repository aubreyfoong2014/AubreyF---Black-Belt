using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraX : MonoBehaviour
{
    public float LookSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxisRaw("Mouse X");
        transform.rotation *= Quaternion.Euler(0, vertical * Time.deltaTime * LookSpeed, 0);
    }
}
