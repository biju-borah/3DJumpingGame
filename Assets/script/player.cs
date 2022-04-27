using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{   
    private bool jumpkeywaspressed;
    private float horizontalinput;
    private Rigidbody rigidbodyComponent;
    // Start is called before the first frame update
    void Start()
    {
      rigidbodyComponent = GetComponent<Rigidbody>();
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
          jumpkeywaspressed = true;
          Debug.Log("Primary mouse was clicked"); // it will get printed in console of unity
        }
        if (Input.GetKey(KeyCode.A))
        {
          rigidbodyComponent.AddForce(Vector3.left*2,ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
          rigidbodyComponent.AddForce(Vector3.right*2,ForceMode.VelocityChange);
        }

        horizontalinput = Input.GetAxis("Horizontal");
        
    }

    // fixedupdate is called once every physics update
    private void FixedUpdate()
    {
        if (jumpkeywaspressed)
        {
          rigidbodyComponent.AddForce(Vector3.up*5,ForceMode.VelocityChange); // direction and magnitute
           jumpkeywaspressed = false;
        }
        rigidbodyComponent.velocity = new Vector3(horizontalinput,rigidbodyComponent.velocity.y,0);
    }

    
}
