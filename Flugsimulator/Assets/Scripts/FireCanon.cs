using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCanon : MonoBehaviour
{
    public GameObject rocket_l;
    public GameObject rocket_r;
    public AudioClip click;
    private bool isTriggered;
    float lastAction;
    float durationRocket;
    private bool beingHandled;
    // Start is called before the first frame update
    void Start()
    {
        isTriggered = false;
        lastAction = 0;
        beingHandled = true;
    }

    // Update is called once per frame
    void Update()
    {
       if (isTriggered || !beingHandled)
        {
            if (isTriggered)
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

    void OnTriggerEnter(Collider other)
    {
        if(!isTriggered&&((Time.time - lastAction)>0.5))
        {
            isTriggered = true;
        }
        
        lastAction = Time.time;
    }
}
