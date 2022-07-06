using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DigitalClockText : MonoBehaviour
{
    private Text m_clockText;
    private Clock m_clock;
    void Awake()
    { 
        m_clockText = GetComponent<Text>();
        m_clock = GetComponent<Clock>();
    }
    void Update()
    {
        m_clockText.text = m_clock.Now();
    }
}
