using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBasketball : MonoBehaviour
{
    // public GameObject basketball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(transform.position);
        if(transform.position.y < 0)
        {
            Debug.Log("destroyed");
            Destroy(this);
        }
    }
}
