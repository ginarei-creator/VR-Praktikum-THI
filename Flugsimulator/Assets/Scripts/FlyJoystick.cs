using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyJoystick : MonoBehaviour
{
    public float speed;
    public float speedAmplifier;
    public float rotationSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputPitch = Input.GetAxis("Pitch");
        float inputRoll = Input.GetAxis("Roll");
        float inputYawn = Input.GetAxis("Yawn");
        float inputThrottle = Input.GetAxis("Throttle");
        Vector3 rotationMovement = new Vector3 (inputPitch * Time.deltaTime * rotationSpeed, inputRoll * Time.deltaTime * rotationSpeed, inputYawn * Time.deltaTime * rotationSpeed );
        this.transform.Rotate(rotationMovement);
        speed = inputThrottle * speedAmplifier;
        Debug.Log(inputThrottle);
        this.transform.Translate (Vector3.forward * speed * Time.deltaTime);
    }
}
