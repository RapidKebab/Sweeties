using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public GameObject[] microGames;
    public int[] times;
    public string[] transitionTexts;
    public GameObject transition;
    public Text transitionText;
    public Text scoreText;
    public Slider timeSlide;
    [HideInInspector]public int score;
    public float transitionWaitTime;
    int currentGame;
    float endTime;
    bool transitioning;
    // Start is called before the first frame update
    void Start()
    {
        endTime = Time.time + times[currentGame];
        microGames[currentGame].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        timeSlide.value = Mathf.Clamp((endTime + times[currentGame]) / times[currentGame], 0, 1);
        if (Time.time > endTime && !transitioning)
        {
            transitioning = true;
            Transition();
        }
    }

    void Transition()
    {
        transition.SetActive(true);
        transitionText.text = transitionTexts[currentGame];
        scoreText.text = "your score: "+score.ToString();
        StartCoroutine(Wait(transitionWaitTime));
    }

    IEnumerator Wait(float s)
    {
        yield return new WaitForSeconds(s);
    }
}
