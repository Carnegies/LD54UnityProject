using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public enum AudioClips
//{
//    Chase,
//    Collision,
//    DeathScreen,
//    FootStep
//}
public static class ScreenUtils
{
    static int screenWidth;
    static int screenHeight;
    static float screenLeft;
    static float screenRight;
    static float screenTop;
    static float screenBottom;

    public static bool isPlayerCatched;
    public static bool isExitReached;
    public static bool isLevelFinished;
    public static bool CDcountDownStart;
    public static int SceneIndex = 1;
    public static int Score;

    public static float ScreenLeft
    {
        get
        {
            CheckScreenSizeChanged();
            return screenLeft;
        }
    }
    public static float ScreenRight
    {
        get
        {
            CheckScreenSizeChanged();
            return screenRight;
        }
    }
    public static float ScreenTop
    {
        get
        {
            CheckScreenSizeChanged();
            return screenTop;
        }
    }
    public static float ScreenBottom
    {
        get
        {
            CheckScreenSizeChanged();
            return screenBottom;
        }
    }

    public static void Initialize()
    {
        screenWidth = Screen.width;
        screenHeight = Screen.height;

        float screenZ = Camera.main.transform.localScale.z;
        Vector3 lowerLeftCornerScreen = new Vector3(0, 0, screenZ);
        Vector3 upperRightCornerScreen = new Vector3(screenWidth, screenHeight, screenZ);
        Vector3 lowerLeftCornerWorld = Camera.main.ScreenToWorldPoint(lowerLeftCornerScreen);
        Vector3 upperRightCornerWorld = Camera.main.ScreenToWorldPoint(upperRightCornerScreen);
        screenLeft = lowerLeftCornerWorld.x;
        screenRight = upperRightCornerWorld.x;
        screenBottom = lowerLeftCornerWorld.y;
        screenTop = upperRightCornerWorld.y;
    }

    static void CheckScreenSizeChanged()
    {
        if (screenWidth != Screen.width || screenHeight != Screen.height)
        {
            Initialize();
        }
    }
}
