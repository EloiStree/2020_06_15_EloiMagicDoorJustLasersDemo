using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QAD_LaserSwithLightAlarm : MonoBehaviour
{
    public UnityEvent m_startAlarm;
    public UnityEvent m_stopAlarm;

    public void SetAlarmFor(float seconds)
    {
        m_startAlarm.Invoke();
        Invoke("SetAlarmOff", seconds);
    }
    public void SetAlarmOff() {
        m_stopAlarm.Invoke();

    }



}
