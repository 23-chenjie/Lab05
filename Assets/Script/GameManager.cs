using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    int score;
    public Text scoretxt;

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
    }

    public void addscore(int add)
    {
        score += add;
        scoretxt.text = "Score: " + score;
    }
}
