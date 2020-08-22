using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score_point = 5;

    public Text player_score;
    public Text bot_score;

    // Start is called before the first frame update
    void Start()
    {
        player_score = GetComponent<Text>();
        bot_score = GetComponent<Text>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "backwall")
        {
            player_score.text = "Player: " + score_point;
        }

        if (col.gameObject.tag == "backwall_P")
        {
            bot_score.text = "Bot: " + score_point;
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
