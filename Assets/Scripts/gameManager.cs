using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEditor;

public class gameManager : MonoBehaviour
{
    //�ڱ༭���︳ֵ
    public Text textScore;

    private void Awake()
    {
        ScreenUtils.Initialize();
        ScreenUtils.isPlayerCatched = false;
        ScreenUtils.isExitReached = false;
        ScreenUtils.isLevelFinished = false;
        ScreenUtils.CDcountDownStart = false;
        ScreenUtils.Score = 0;
    }
    void Update()
    {
        textScore.text = "Score: " + ScreenUtils.Score.ToString();
    }
}
