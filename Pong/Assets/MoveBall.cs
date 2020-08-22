using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBall : MonoBehaviour {

	Vector3 ballStartPosition;
	Rigidbody2D rb;
	float speed = 400;
	public AudioSource blip;
	public AudioSource blop;

    int score_point = 5;

    public Text player_score;
    public Text bot_score;

    // Use this for initialization
    void Start () {
		rb = this.GetComponent<Rigidbody2D>();
		ballStartPosition = this.transform.position;
		ResetBall();
	}

	void OnCollisionEnter2D(Collision2D col)
	{
        if (col.gameObject.tag == "backwall")
        {
            blop.Play();
            player_score.text += "Player: " + score_point;
        }

        else if (col.gameObject.tag == "backwall_P")
        {
            blop.Play();
            bot_score.text += "Bot: " + score_point;
        }

        else
        {
            blip.Play();
        }
    }

	public void ResetBall()
	{
		this.transform.position = ballStartPosition;
		rb.velocity = Vector3.zero;
		Vector3 dir = new Vector3(Random.Range(-100,300),Random.Range(-100,100),0).normalized;
		rb.AddForce(dir*speed);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space"))
		{
			ResetBall();
		}
	}
}
