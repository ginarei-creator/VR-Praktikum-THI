using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rb;
    public bool keyboard;
    //public Text MyText;
    public float speed;
    public int score;
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        //MyText.text = "Points";
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
       // MyText.text = "Points" + score;
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
            score = score + 1;

        } 
        else if (other.gameObject.CompareTag ("No Pick Up")) 
        {
            other.gameObject.SetActive (false); 
            score = score - 1;
        }
    }
}
