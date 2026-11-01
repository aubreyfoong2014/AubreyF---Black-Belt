using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraY : MonoBehaviour
{
    public float lookSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Mouse Y");
        //Quaternion = used as a name to represent how something is being rotated (always use when rotating)
        transform.rotation *= Quaternion.Euler(-horizontal * Time.deltaTime * lookSpeed, 0, 0);

    }
}
