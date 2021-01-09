using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreBasketball : MonoBehaviour
{
    public GameObject trigger;
    public TextMesh score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //speed = speed * -1;
        //colorPicker = Random.Range(0, 10);
    }

    // Update is called once per frame
    //void Update()
    //{

    //}
}
