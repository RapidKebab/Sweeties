using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] Game gmemgr;
    [SerializeField] int scoreToWin;
    [SerializeField] FlowerDisplay fd;
    [SerializeField] bool destroyOtherOnHit;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        if (other.gameObject.tag == "obj") {
            score++;
            other.enabled = false;
            if (destroyOtherOnHit) other.gameObject.SetActive(false);
            if (score >= scoreToWin)
            {
                gmemgr.score++;
                gmemgr.Transition();
            }
            if (fd != null) fd.add();
        }
    }
}
