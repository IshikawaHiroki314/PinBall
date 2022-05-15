using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    private float visiblePosZ = -6.5f;

    //private GameObject scoreObject = null;
    private Text S_text;
    private int score = 0;
    private GameObject gameoverText;

    // Start is called before the first frame update
    void Start()
    {
        //this.scoreObject = GameObject.Find("ScoreText");
        this.S_text = GameObject.Find("ScoreText").GetComponent<Text>();
        this.gameoverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        S_text.text = "Score:" + score.ToString();
        if (this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "SmallStarTag")
        {
            this.score += 5;
        }
        else if(other.gameObject.tag == "LargeStarTag")
        {
            this.score += 50;
        }
        else if(other.gameObject.tag == "SmallCloudTag" || other.gameObject.tag == "LargeCloudTag")
        {
            this.score += 20;
        }
    }
}

