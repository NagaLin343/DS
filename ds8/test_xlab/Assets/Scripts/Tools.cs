using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tools : MonoBehaviour
{
    [SerializeField]
    private Farmer[] m_farmers;
    public void Action() 
    {
        foreach (var item in m_farmers) 
        {
            item.ChangeTool();
        }
    }
}
