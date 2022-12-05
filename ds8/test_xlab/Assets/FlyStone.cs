using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyStone : MonoBehaviour
{   private Vector3 polog;
    public GameObject stone; 
    void Start()
    {
        polog = GetComponent<Transform>().position;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(stone, polog, Quaternion.identity);
        }
    }
}
