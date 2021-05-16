using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstMove : MonoBehaviour
{
    public Vector3 move;

    void FixedUpdate()
    {
        this.transform.position += move;
    }
}
