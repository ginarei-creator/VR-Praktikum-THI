using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rb;
    public bool keyboard;
    public float speed;
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        if(keyboard)
        {
            float moveHorizontal = Input.GetAxis ("Horizontal"); 
            float moveVertical = Input.GetAxis ("Vertical");
            movement = new Vector3(moveHorizontal,0f,moveVertical);
            movement=movement *speed;
            rb.AddForce(movement);
        }
        
    }
    void OnTriggerEnter(Collider other) 
    { 
        if (other.gameObject.CompareTag ("Pick Up")) 
        { 
            other.gameObject.SetActive (false); 
        } 
    }
}
