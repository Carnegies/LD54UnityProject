using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEditor;

public class showCoin : MonoBehaviour
{
    //�ڱ༭���︳ֵ
    public Text textScore;

    void Start()
    {
        textScore.text = "Score: " + ScreenUtils.Score.ToString();
    }
}
