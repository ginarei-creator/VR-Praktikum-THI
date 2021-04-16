using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCanon : MonoBehaviour
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
                Debug.Log("in Rockez");
                //this.renderer.material.color = Color.white;
                rocket_l.SetActive(true);
                rocket_r.SetActive(true);
                durationRocket = 1.8f;
                beingHandled = false;
                isTriggered = false;
            }
            else if (durationRocket <= 0)
            {
                beingHandled = true;
                Debug.Log("in Dur");
                this.transform.Translate(0,-0.02f,0);
            }
            else
            {
                durationRocket -= Time.deltaTime;
                Debug.Log(durationRocket);
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
            Debug.Log(isTriggered);
        }
        AudioSource.PlayClipAtPoint(click, transform.position, 1);
        lastAction = Time.time;
        this.transform.Translate(0,0.01f,0);
    }
}
