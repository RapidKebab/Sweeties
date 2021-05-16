using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    void Start()
    {
        endTime = Time.time + times[currentGame];
        microGames[currentGame].SetActive(true);
    }

    void Update()
    {
        timeSlide.value = 1- Mathf.Clamp((Time.time - (endTime - times[currentGame])) / times[currentGame], 0, 1);
        if (Time.time > endTime && !transitioning)
        {
            Transition();
        }
    }

    public void Transition()
    {
        transitioning = true;
        transition.SetActive(true);
        transitionText.text = transitionTexts[currentGame];
        scoreText.text = "Your Score: "+score.ToString();
        currentGame++;
        StartCoroutine(Wait(transitionWaitTime));
    }

    IEnumerator Wait(float s)
    {
        yield return new WaitForSeconds(s);
        if (currentGame >= microGames.Length)
        {
            SceneManager.LoadScene(0);
            Debug.Log("lol");
        }
        endTime = Time.time + times[currentGame];
        microGames[currentGame].SetActive(true);
        transition.SetActive(false);
        transitioning = false;
    }
}
