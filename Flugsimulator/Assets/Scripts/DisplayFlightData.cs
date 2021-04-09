using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayFlightData : MonoBehaviour
{
    public Text textSpeed;
    public Text textHeight;
    public GameObject player;
    public float warningHeight;
    public GameObject warnImage;
    private FlyJoystick flyJoystick;
    // Start is called before the first frame update
    void Start()
    {
        flyJoystick = player.GetComponent <FlyJoystick >();
        textSpeed.color = new Color(146.0f/255.0f, 234.0f/255.0f, 242.0f/255.0f);
    }

    // Update is called once per frame
    void Update()
    {
        float height1 = player.transform.position.y;
        int height = (int) height1;//Convert.ToInt32(height1); 
        textHeight.text = "Alt: " + height + " m";
        float speed1 = flyJoystick.speed;
        int speed = (int) speed1;
        textSpeed.text = "Speed: " + speed + " km/h";
        if(height < warningHeight)
        {
            warnImage.SetActive(true);
            textHeight.color = new Color(206.0f/255.0f, 46.0f/255.0f, 46.0f/255.0f);
        }
        else
        {
            warnImage.SetActive(false);
            textHeight.color = new Color(146.0f/255.0f, 234.0f/255.0f, 242.0f/255.0f);
        }

    }
}
