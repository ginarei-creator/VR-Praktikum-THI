using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverPad : MonoBehaviour
{
    //public GameObject waypoint;
    public Vector3 upPos;
    public GameObject platform;
    public GameObject player;
    public float smooth;
    Vector3 newPos;
    bool hasPlayer;
    bool holdPos;
    // Start is called before the first frame update
    void Start()
    {
        holdPos = false; 
        hasPlayer = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(hasPlayer && (!holdPos)) {
            Debug.Log("has player done");
        //    newPos = upPos.position;
          //  transform.position = Vector3.Lerp(transform.position, newPos, smooth * Time.deltaTime);
            //holdPos = true;
            float step = 0.01f * Time.deltaTime;
            platform.transform.position = Vector3.MoveTowards(transform.position,upPos, step);
            player.transform.position = Vector3.MoveTowards(transform.position,upPos, step);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            Debug.Log("if done");
            //other.transform.parent = gameObject.transform;
            hasPlayer = true;
        }
    }

   // void OnTriggerExit(Collider other)
    //{
      //  if(other.tag == "Player"){
            
        //    other.transform.parent = null;
         //   hasPlayer = false;
        //}
}
