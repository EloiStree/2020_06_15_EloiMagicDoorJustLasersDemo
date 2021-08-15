using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QAD_LaserSwithLightAlarm : MonoBehaviour
{
    public UnityEvent m_startAlarm;
    public UnityEvent m_stopAlarm;
    private float m_countDownState = 3f;
    public void SetAlarmFor(float seconds)
    {
        m_countDownState = seconds;
        m_startAlarm.Invoke();
    }
    public void SetAlarmOff() {
        m_stopAlarm.Invoke();

    }


    private void Update()
    {
        if ( m_countDownState <= 0f ) 
            return;

        float previous = m_countDownState;
        m_countDownState -= Time.deltaTime;

        if (previous > 0f && m_countDownState <= 0f) {
            m_countDownState = 0f; 
            SetAlarmOff();
        }
    }


}
