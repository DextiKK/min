using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text Text;
    public static int enemys;

    void Start()
    {
        Text = GetComponent<Text>();
    }
    void Update()
    {
        Text.text = enemys.ToString() + "/20";
    }
}
