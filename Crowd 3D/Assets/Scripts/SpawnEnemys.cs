using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemys : MonoBehaviour
{
    public Transform myPrefab;
    public int instanceCount = 5;
    private void Start()
    {
        StartCoroutine(CreateInstances());
    }
    
    private IEnumerator CreateInstances()
    {
        for (int i = 0; i < instanceCount; ++i) 
        {
            yield return new WaitForSeconds(0.5f);
            Instantiate(myPrefab, Vector3.zero, Quaternion.identity);
        }
    }
}
