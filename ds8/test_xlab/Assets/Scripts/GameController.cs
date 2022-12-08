using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private StoneSpawner m_spawner;

    [SerializeField]
    private Tools m_tools;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)) 
        {
            if(m_spawner!=null)
            m_spawner.Spawn();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
                m_tools.Action();
        }
    }
}
