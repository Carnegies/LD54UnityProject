using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEditor;

public class showCoin : MonoBehaviour
{
    //ÔÚ±à¼­Æ÷Àï¸³Öµ
    public Text textScore;

    void Start()
    {
        textScore.text = "Score: " + ScreenUtils.Score.ToString();
    }
}
