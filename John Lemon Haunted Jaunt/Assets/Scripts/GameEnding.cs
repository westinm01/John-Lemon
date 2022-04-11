using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{
    // Start is called before the first frame update
    public float fadeDuration=1f;
    public GameObject player;
    public CanvasGroup exitBackgroundImageCanvasGroup;
    float m_Timer;
    bool m_IsPlayerAtExit;
    public float displayImageDuration = 1f;
    /*void Start()
    {
        
    }
    */
    // Update is called once per frame
    void Update()
    {
        if(m_IsPlayerAtExit)
        {
            EndLevel();
        }
    }
    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerAtExit = true;
        }
    }
    void EndLevel()
    {
        m_Timer += Time.deltaTime;
        exitBackgroundImageCanvasGroup.alpha = m_Timer / fadeDuration;
        if(m_Timer > fadeDuration + displayImageDuration)
        {
            Application.Quit();
        }
    }
}
