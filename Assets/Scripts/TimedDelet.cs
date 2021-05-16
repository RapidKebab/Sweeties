using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDelet : MonoBehaviour
{
    [SerializeField] float destroyTime;

    void Start()
    {
        Destroy(this.gameObject, destroyTime);
    }
}
