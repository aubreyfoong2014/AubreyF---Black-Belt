using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //when pressing keys, change direction. when going right, it becomes positive, when going left it is negative. Get axis raw is a whole number i.e: 0 or 1
        //Get axis gives a decimal between 0 or 1
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        //Vector 3 is 3 set positions (x,y,z). 
        transform.position += (transform.right * horizontal * speed * Time.deltaTime) + (transform.forward * vertical * speed * Time.deltaTime); 

    }
}
