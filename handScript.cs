using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour
{
    public GameObject hand;
    // Start is called before the first frame update
    void Start()
    {
     // Instantiate the prefab (the prefab, at what location, with what rotation)
    Instantiate(hand, this.transform);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
