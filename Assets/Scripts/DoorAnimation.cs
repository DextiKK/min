using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorAnimation : MonoBehaviour
{
    public GameObject Door;
    public GameObject Key;
    public Text Score;

    private float ScoreKey = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>())
        {
            Key.GetComponent<SpriteRenderer>().enabled = false;
            Key.GetComponent<BoxCollider>().enabled = false;
            ScoreKey = +1;
        }
    }

    private void Update()
    {
        if (ScoreKey == 1 && Score.text == "20/20")
        {
            Door.GetComponent<Animator>().enabled = true;
        }
    }
}
