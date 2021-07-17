using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text timeText;
    private float time = 0;

    private void Start()
    {
        timeText = GameObject.FindObjectOfType<Text>();
    }

    private void Update()
    {
        time += Time.deltaTime;
        timeText.text = time.ToString();
        Debug.Log("1");
    }
}