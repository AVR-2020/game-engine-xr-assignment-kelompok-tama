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

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("the ball has enter the ring");
        value += 1;
        score.text = value.ToString();
        //speed = speed * -1;
        //colorPicker = Random.Range(0, 10);
    }

    // Update is called once per frame
    //void Update()
    //{

    //}
}
