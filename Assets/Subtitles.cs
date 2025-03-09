using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtitles : MonoBehaviour
{
    public int subTime;
    public GameObject subtitles;

    public void SubtitleTime()
    {
        subtitles.SetActive(false);
    }

    public void Start() 
    {
        Invoke("SubtitleTime", subTime);
    }
}
