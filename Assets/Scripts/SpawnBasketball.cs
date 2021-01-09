using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBasketball : MonoBehaviour
{
    bool flag = false;
    public VRTK.VRTK_InteractableObject target;
    public VRTK.VRTK_InteractUse activity;
    public Transform spawner;
    public GameObject basketballPrefab;
    public float whatIsThis;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("kondisi InteractableObject : " + target.isActiveAndEnabled);
        Debug.Log("kondisi isGrabbable : " + target.isGrabbable); 
    }

    private void spawnBasketball()
    {
        if (target.isActiveAndEnabled && flag == false)
        {
            Debug.Log("aylmao"); 
            Debug.Log(spawner.position);
            GameObject basketball = Instantiate(basketballPrefab) as GameObject;
            basketball.AddComponent<destroyBasketball>();
            basketball.AddComponent<Rigidbody>();
            //basketball.AddComponent<SphereCollider>();
            basketball.transform.position = spawner.position;
            flag = true;
        }
        if (!target.isActiveAndEnabled && flag == true)
        {
            flag = false;
        }

        //GameObject basketball = Instantiate(basketballPrefab) as GameObject;
    }



    // Update is called once per frame
    void FixedUpdate()
    {

        //Debug.Log("kondisi isUsable : " + target.isUsable);

        spawnBasketball();
        //Debug.Log("kondisi InteractableObject : " + target.isActiveAndEnabled);
    }
}
