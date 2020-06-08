using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreesSpawn : MonoBehaviour
{
    public float maxTime = 1;
    public GameObject trees;
    private float timer = 0;
    public float height; 

    void Start()
    {
        GameObject newtrees = Instantiate(trees);
        newtrees.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newtrees, 5);
    }

    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newtrees = Instantiate(trees);
            newtrees.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newtrees, 5);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
