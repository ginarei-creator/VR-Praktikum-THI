using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float speedtrans;
    public float speedrot;
    // Start is called before the first frame update
    void Start()
    {
        
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
    }
}
