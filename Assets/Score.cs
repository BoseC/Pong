using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreboard;
    public GameObject ball;
    private int score_p1=0;
    private int score_p2 =0;

	// Use this for initialization

    
	void Start () {
        ball = GameObject.Find("ball");
	
	}
    void Result()
    {
        if (ball.transform.position.x >= 10f)
        {
            score_p1++;
        }
        if (ball.transform.position.x <= -10f)
        {
            score_p2++;
        }
    }

    // Update is called once per frame
    void Update () {
        Result();
        scoreboard.text = score_p1.ToString() + " " + score_p2.ToString();


    }

}
