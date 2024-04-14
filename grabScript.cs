using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabScript : MonoBehaviour
{
    // public maxHeight list;
    Vector3 RH;
    float distance;
    Rigidbody rb;
    bool grabFlag;

    public void OnTriggerStay(Collider other)
    {
        // Check if the Collider is tagged as "LHand"
        if (other.CompareTag("LHand"))
        {
            bool gripValue;
            var inputDevices = new List<UnityEngine.XR.InputDevice>();
            UnityEngine.XR.InputDevices.GetDevices(inputDevices);
            foreach (var device in inputDevices)
            {
            if (device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.gripButton, out gripValue) && gripValue)
                {
                // if grip button pressed and collided with L Hand
                this.transform.position = GameObject.Find("Left Controller").transform.position;
                this.transform.rotation = GameObject.Find("Left Controller").transform.rotation;

                grabFlag = true;
                }
            else if (grabFlag == true)
                {
                // figure out syntax of making velocity of the object 0
                // this.velocity = (0f, 0f, 0f);
                rb.velocity = Vector3.zero;
                grabFlag = false;
                }
            }    
        }
        

        // Check if the Collider is tagged as "RHand"
        if (other.CompareTag("RHand"))
        {
            bool gripValue;
            var inputDevices = new List<UnityEngine.XR.InputDevice>();
            UnityEngine.XR.InputDevices.GetDevices(inputDevices);
            foreach (var device in inputDevices)
            {
            if (device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.gripButton, out gripValue) && gripValue)
                {
                // if grip button pressed and collided with R Hand
                this.transform.position = GameObject.Find("Right Controller").transform.position;
                this.transform.rotation = GameObject.Find("Right Controller").transform.rotation;

                grabFlag = true;

                }
            else if(grabFlag == true)
                {
                // figure out syntax of making velocity of the object 0
                // this.velocity = (0f, 0f, 0f);
                rb.velocity = Vector3.zero;
                grabFlag = false;

                }
            }
            
            
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    rb = GetComponent<Rigidbody>();
    grabFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
    RH = GameObject.Find("Right Controller").transform.position;
    distance = Vector3.Distance(RH, this.transform.position);

    

    }
}
