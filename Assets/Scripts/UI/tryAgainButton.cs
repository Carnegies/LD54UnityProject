using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class tryAgainButton : MonoBehaviour
{
    public void OnPointerClick()
    {
        SceneManager.LoadScene("" + ScreenUtils.SceneIndex);
    }
}
