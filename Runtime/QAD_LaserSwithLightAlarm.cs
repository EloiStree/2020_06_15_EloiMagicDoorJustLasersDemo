using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QAD_LaserSwithLightAlarm : MonoBehaviour
{
    public Light m_affectedLight;

    public void SetAlarmFor(float seconds)
    {
        m_affectedLight.enabled = true;
        Invoke("SetAlarmOff", seconds);
    }
    public void SetAlarmOff() {
        m_affectedLight.enabled = false;

    }



}
