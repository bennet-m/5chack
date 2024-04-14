using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mix : MonoBehaviour
{
   
    float timer;
    MeshRenderer meshRenderer;
    public Material newMat;

    public void OnTriggerStay(Collider other)
    {
        // Check if the Collider is tagged as "Rod"
        if (other.CompareTag("RHand"))
        {
            Debug.Log("Collided");
            timer = timer + Time.deltaTime;
            if (timer > 2) 
            {
                //change material
                meshRenderer.material = newMat;

            }
            
        }
        

       
    }

    // Start is called before the first frame update
    void Start()
    {

    timer = 0;
    meshRenderer = GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
    

    

    }
}

