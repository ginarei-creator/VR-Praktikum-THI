using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButton : MonoBehaviour
{
    public GameObject hud;
    public GameObject canvas;
    public AudioClip click;
    bool isTriggered;
    float lastAction;
    // Start is called before the first frame update
    void Start()
    {
        isTriggered = false;
        lastAction = 0;
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(this.position);
       
    }

    void OnTriggerEnter(Collider other)
    {
        if(!isTriggered&&((Time.time - lastAction)>0.5))
        {
            this.transform.Translate(0,0.04f,0.02f); //Working: 0, 0.01, 0.03; 0. 0.001, 0.03
            hud.SetActive(true);
            canvas.SetActive(false);
            isTriggered = true;
        }
        else if(isTriggered&&((Time.time - lastAction)>0.5))
        {
            this.transform.Translate(0,-0.04f,-0.02f); //Working: 0, 0.01, 0.03; 0. 0.001, 0.03
            hud.SetActive(false);
            canvas.SetActive(true);
            isTriggered = false;
        }
        Debug.Log(isTriggered);
        AudioSource.PlayClipAtPoint(click, transform.position, 1);
        lastAction = Time.time;
    }
}
