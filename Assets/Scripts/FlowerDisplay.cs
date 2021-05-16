using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerDisplay : MonoBehaviour
{
    [SerializeField] GameObject[] flowers;
    int pointer;

    public void add() {
        flowers[pointer].SetActive(true);
        pointer++;
    }
}
