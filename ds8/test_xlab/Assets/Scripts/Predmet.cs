using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Predmet : MonoBehaviour
{
    public Mesh[] predm;
    private int ind=0;
    private MeshFilter visyal;
  
    void Start()
    {
        visyal = GetComponent<MeshFilter>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            ind++;
            if (ind >= predm.Length) {
                ind = 0;
            }
            if (visyal.name != predm[ind].name){
                visyal.mesh = predm[ind]; 
            }
            else {
                ind++;
                if (ind >= predm.Length)
                {
                    ind = 0;
                }
                visyal.mesh = predm[ind];
            }
        }
    }
}
