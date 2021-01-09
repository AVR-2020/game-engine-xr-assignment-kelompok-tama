using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreBasketball : MonoBehaviour
{
    public GameObject trigger; 
    public TextMesh score;
    int value = 0;

    // Start is called before the first frame update
    void Start()
    {
        score.text = value.ToString();
        Debug.Log("inisiasi score");
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("object entered the ring" + other);
        if (other.gameObject.tag == "basketball")
        {
            Debug.Log("basketball enter");
            value += 1;
            score.text = value.ToString();
        }
        
        //speed = speed * -1;
        //colorPicker = Random.Range(0, 10);
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("object stay the ring");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("object exit the ring");
    }

    // Update is called once per frame
    //void Update()
    //{

    //}
}
