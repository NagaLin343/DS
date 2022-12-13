using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Boom : MonoBehaviour
{
    [SerializeField]
    private UnityEvent<Collision, Vector3> onCollisionStone;
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(">>>");
        onCollisionStone.Invoke(other, transform.right);
    }
}
