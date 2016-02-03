using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

    Text m_time;
    float m_timer;
    double m_minutes;
    double m_seconds;

    void Start()
    {
        m_time = GetComponent<Text>();
    }

    void Update ()
    {
        m_timer += Time.deltaTime;

        m_minutes = Mathf.Floor(m_timer / 60);
        m_seconds = Mathf.Floor(m_timer % 60);

        string minutes = m_minutes.ToString("00");
        string seconds = m_seconds.ToString("00");

        m_time.text = "Time  " + minutes + ":" + seconds;
    }
}
