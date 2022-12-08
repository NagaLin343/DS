using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject stonePrefab;
    public void Spawn() 
    {
        Vector3 position = transform.position;
        Quaternion rotation = transform.rotation;

        GameObject.Instantiate(stonePrefab, position, rotation);
    }
}
