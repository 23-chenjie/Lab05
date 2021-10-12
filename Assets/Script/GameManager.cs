using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    int score;
    int totalscore = 60;
    float timeleft;
    float starttime = 20f;
    int timeremaining;

    public Text scoretxt;
    public Text timertxt;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        score = 0;
        timeleft = starttime;
    }

    void Update()
    {
        timeleft -= Time.deltaTime;
        timeremaining = Mathf.FloorToInt(timeleft % 60);
        timertxt.text = "Timer: " + timeremaining.ToString();

        if(score == totalscore)
        {
            SceneManager.LoadScene(1);
        }
        else if(timeleft <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void addscore(int add)
    {
        score += add;
        scoretxt.text = "Score: " + score;
    }
}
