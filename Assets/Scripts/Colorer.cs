using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorer : MonoBehaviour
{
    [SerializeField] string prefname;
    [SerializeField] Color[] colors;
    [SerializeField] SpriteRenderer tgt;
    int value;
    // Start is called before the first frame update
    void Start()
    {
        value = PlayerPrefs.GetInt(prefname, 0);
        tgt.color = colors[value];
    }

    public void ChangeColor()
    {
        value++;
        if (value >= colors.Length) value = 0;
        PlayerPrefs.SetInt(prefname, value);
        tgt.color = colors[value];
    }
}