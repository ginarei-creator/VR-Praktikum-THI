using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float speedtrans;
    public float speedrot;
    public GameObject rocket_l;
    public GameObject rocket_r;

    private bool beingHandled;
    float durationRocket;
    // Start is called before the first frame update
    void Start()
    {
        beingHandled = true;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) 
        {
            this.transform.Translate (Vector3.forward * speedtrans * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A)) 
        {
            this.transform.Rotate (Vector3.down * speedrot * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S)) 
        {
            this.transform.Translate (Vector3.back * speedtrans * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D)) 
        {
            this.transform.Rotate (Vector3.up * speedrot * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.O)) 
        {
            this.transform.Translate (Vector3.down * speedtrans * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.E)) 
        {
            this.transform.Translate (Vector3.up * speedtrans * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.P) || !beingHandled)
        {
            if (Input.GetKey(KeyCode.P))
            {
                rocket_l.SetActive(true);
                rocket_r.SetActive(true);
                durationRocket = 1.8f;
                beingHandled = false;
            }
            else if (durationRocket <= 0)
            {
                beingHandled = true;
            }
            else
            {
                durationRocket -= Time.deltaTime;
            }
        }
        else
        {
            rocket_l.SetActive(false);
            rocket_r.SetActive(false);
        }
        
    }

}
