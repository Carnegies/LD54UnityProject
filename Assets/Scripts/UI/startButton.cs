using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour
{
    public void OnPointerClick()
    {
        SceneManager.LoadScene("" + 1);
    }
}
