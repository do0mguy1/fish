using UnityEngine;
using System.Collections.Generic;

public class total : MonoBehaviour
{
    public fish fishscript;
    public GameObject[] prefabs;
    public float totalValues;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fishscript = FindFirstObjectByType<fish>().GetComponent<fish>();
    }

    // Update is called once per frame
    void Update()
    {
        prefabs = GameObject.FindGameObjectsWithTag("fish");
        totalValues = 0;

        foreach (GameObject prefab in prefabs)
        {
            totalValues += fishscript.fishvalue;
        }
    }
}
