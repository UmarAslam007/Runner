using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDestructor : MonoBehaviour
{
    private GameObject point;
    // Start is called before the first frame update
    void Start()
    {
        point = GameObject.Find("DestructionPoint");   
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < point.transform.position.x)
        {
            gameObject.SetActive(false);
        }
    }
}
