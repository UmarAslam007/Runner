using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    public Transform groundPoint;
    public Transform minHighPoint;
    public Transform maxHighPoint;


    private float MinY;
    private float MaxY;

    public float MinGap;
    public float MaxGap;


    public ObjectPoller[] groundPoolers;
    private float[] groundWidths;

    private CoinGenrater coinGenrater;

    // Start is called before the first frame update
    void Start()
    {
        MinY = minHighPoint.transform.position.y;
        MaxY = maxHighPoint.transform.position.y;
        groundWidths = new float [groundPoolers.Length];
        for(int i=0;i<groundPoolers.Length;i++)
        {
            groundWidths[i] = groundPoolers[i].poolObject.GetComponent<BoxCollider2D>().size.x;
        }

        coinGenrater = FindObjectOfType<CoinGenrater>();
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.x < groundPoint.position.x)
        {
            int random = Random.Range(0, groundPoolers.Length);
            float distance = groundWidths[random] / 2;

            float Gap = Random.Range(MinGap, MaxGap);
            float hight = Random.Range(MinY, MaxY);

            transform.position = new Vector3(transform.position.x + distance + Gap,hight, transform.position.z);
            
            GameObject ground = groundPoolers[random].GetPooledGameObject();
            ground.transform.position = transform.position;
            ground.SetActive(true);

            coinGenrater.SpawnCoins(transform.position,groundWidths[random]);

            transform.position = new Vector3(transform.position.x + distance, transform.position.y, transform.position.z);




        }
    }
}
