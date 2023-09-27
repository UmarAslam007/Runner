using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenrater : MonoBehaviour
{

    public ObjectPoller CoinPoller;

    public void SpawnCoins(Vector3 position ,float groundWidth)
    {
        int random = Random.Range(1, 100);

        if (random < 50)
            return;

        int NumberOfCoins = (int)Random.Range(3f, groundWidth);
        float y = Random.Range(2, 4);

        for(int i=0; i<NumberOfCoins; i++)
        {

            float x = position.x - (groundWidth / 2) + 1; 
            GameObject coin = CoinPoller.GetPooledGameObject();
            coin.transform.position = new Vector3(x + i,
                                                  position.y + y,
                                                  0);
            coin.SetActive(true);
        }
    }

}
