using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playMusic : MonoBehaviour
{
    AudioSource[] m_ArrayMusic;
    AudioSource m_music1;
    AudioSource m_music2;

    void Start()
    {
        m_ArrayMusic = gameObject.GetComponents<AudioSource>();
        m_music1 = m_ArrayMusic[0];
        m_music2 = m_ArrayMusic[1];
    }

    void Update()
    {
        if (ScreenUtils.isLevelFinished)
        {
            m_music1.Stop();
            m_music2.Stop();
        }
    }
}
