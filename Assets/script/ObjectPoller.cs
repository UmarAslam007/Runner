using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject poolObject;
    public int numberOfObject;
    private List<GameObject> gameObjects;
    void Start()
    {
        gameObjects = new List<GameObject>();   

        for(int i=0; i<numberOfObject;i++)
        {
            GameObject gameObject = Instantiate(poolObject);
            gameObject.SetActive(false);
            gameObjects.Add(gameObject);
        }
    }
    public GameObject GetPooledGameObject()
    {
        foreach (GameObject gameObject in gameObjects)
        {
            if(!gameObject.activeInHierarchy)
                return gameObject;
        }

        GameObject gameObj = Instantiate(poolObject);
        gameObj.SetActive(false);
        gameObjects.Add(gameObject);
        return gameObj;

    }

}
