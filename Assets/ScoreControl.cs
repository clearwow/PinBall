using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{

    public Text scoreText;
    private int score = 0;
    private const string scorePrefix = "Score: ";

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText.text = scorePrefix + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

   void OnCollisionEnter(Collision other)
   {   
       if (other.gameObject.tag == "SmallStarTag")
       {
           score += 5;
       }
       else if (other.gameObject.tag == "LargeStarTag")
       {
           score += 30;
       }
       else if (other.gameObject.tag == "SmallCloudTag")
       {
           score += 10;
       }
       else if (other.gameObject.tag == "LargeCloudTag")
       {
           score += 20;
       }
       scoreText.text = scorePrefix + score.ToString();
   }
}