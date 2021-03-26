using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public GameObject[] waypoints;
    int current = 0;
    float rotSpeed;
    public float speed;
    float WPradius = 0.2f;
    public bool ismoving = true;
    bool grab = false;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if ((Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)&&ismoving&&grab)
        {
            current++;
            if (current >= waypoints.Length)
            {
                current = 0;
                grab = false;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
        if (grab)
        {
            ismoving = false;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Play3"))
        {
            ismoving = false;
        }
    }
}
