using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{   
    public GameObject[] puti;
    public float speed=3f;
    private bool dead;
    private int ind=0;
    private Vector3 homo;
    void Start()
    {
        polog();
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, homo) < .2f &&!dead)
        {
            dead = true;
        }
        if (Input.GetKeyDown(KeyCode.Z)&&dead)
        {   ind++;
            if (ind >= puti.Length)
            {
                ind = 0;
            }
            dead=false;
            polog();
        }
        if (!dead)
        {
            transform.position = Vector3.MoveTowards(transform.position, homo, Time.deltaTime*speed);
        }
    }
    private void polog()
    {   homo.x = puti[ind].transform.position.x;
        homo.y = transform.position.y;
        homo.z = puti[ind].transform.position.z;

    }
}
