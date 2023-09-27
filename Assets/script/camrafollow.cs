using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camrafollow : MonoBehaviour
{
    // Start is called before the first frame update
    private player01 player;
    private Vector3 LastPosition;
    private float Distance;
    void Start()
    {
        player = FindObjectOfType<player01>();
        LastPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Distance = player.transform.position.x - LastPosition.x;
        transform.position = new Vector3(transform.position.x + Distance,transform.position.y,transform.position.z);
        LastPosition = player.transform.position;
    }
}
