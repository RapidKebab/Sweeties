using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] bool horizontal;
    [SerializeField] bool vertical;
    [SerializeField] float speed;

    [SerializeField] float MaxX;
    [SerializeField] float MinX;
    [SerializeField] float MaxY;
    [SerializeField] float MinY;

    void FixedUpdate()
    {
        if (horizontal)
            this.transform.position = new Vector3(Mathf.Clamp(this.transform.position.x + Input.GetAxis("Horizontal") * speed, MinX, MaxX), this.transform.position.y, this.transform.position.z);
        if (vertical)
            this.transform.position = new Vector3(this.transform.position.x, Mathf.Clamp(this.transform.position.y + Input.GetAxis("Vertical") * speed, MinY, MaxY), this.transform.position.z);
    }
}
