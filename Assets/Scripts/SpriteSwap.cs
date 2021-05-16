using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwap : MonoBehaviour
{
    [SerializeField] string prefname;
    [SerializeField] Sprite[] sprites;
    [SerializeField] SpriteRenderer tgt;
    int value;
    // Start is called before the first frame update
    void Start()
    {
        value = PlayerPrefs.GetInt(prefname, 0);
        tgt.sprite = sprites[value];
    }

    public void ChangeSprite()
    {
        value++;
        if (value >= sprites.Length) value = 0;
        PlayerPrefs.SetInt(prefname, value);
        tgt.sprite = sprites[value];
    }
}
