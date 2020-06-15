using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QAD_ChangeColorOnTouched : MonoBehaviour
{
    public Renderer m_toAffect;
    public Color m_idltColor = new Color(1f,0,0);
    public Color m_touchColor = new Color(0.8f, 0, 0);
    
    private void OnCollisionEnter(Collision collision)
    {
        SetAsTouched();
    }
    private void OnCollisionExit(Collision collision)
    {
        SetAsIdlt();
    }

    public void SetAsIdlt()
    {
        m_toAffect.material.color = m_idltColor;
    }
    public void SetAsTouched()
    {
        m_toAffect.material.color = m_touchColor;
    }

}
