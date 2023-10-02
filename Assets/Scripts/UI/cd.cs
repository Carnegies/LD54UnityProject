using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cd : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Image>().fillMethod = Image.FillMethod.Radial360; 
    }

    void Update()
    {
        if (ScreenUtils.CDcountDownStart)
        {
            if (gameObject.GetComponent<Image>().fillAmount > 0.0f)
            {
                gameObject.GetComponent<Image>().fillAmount -= Time.deltaTime * 0.333f;
            }
        }
        else
        {
            gameObject.GetComponent<Image>().fillAmount = 0;
        }
    }
}
