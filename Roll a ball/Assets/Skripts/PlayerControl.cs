using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rb;
    public bool keyboard;
    public GameObject t;
    public GameObject door;
    public GameObject door2;
    public float speed;
    public int score;
    public int level;
    public GameObject level3;
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        level = 1;
        level3 = GameObject.FindGameObjectWithTag("Level3");
        level3.SetActive(false);
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
            if(score == 10 && level ==1)
            {
                //remove Door
                door = GameObject.FindGameObjectWithTag("Door");
                door.SetActive(false);
                level = 2;
            }
            if (score >=14 && level == 2)
            {
                //remove Door
                door2 = GameObject.FindGameObjectWithTag("Door2");
                door2.SetActive(false);
                //level3 = GameObject.FindGameObjectWithTag("Level3");
                level3.SetActive(true);
                level = 3;
            }
            t.GetComponent<TextMesh>().text = "Score: " + score + "\nLevel: " + level;
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
