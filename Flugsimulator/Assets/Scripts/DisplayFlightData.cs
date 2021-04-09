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
    private FlyJoystick flyjoystick;
    // Start is called before the first frame update
    void Start()
    {
        flyJoystick = player.GetComponent <FlyJoystick >();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
