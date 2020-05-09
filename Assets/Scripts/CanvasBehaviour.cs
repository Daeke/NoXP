using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasBehaviour : MonoBehaviour
{

    void Awake() //happens before Start!
    {
        References.canvas = gameObject;
    }
    
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
}
