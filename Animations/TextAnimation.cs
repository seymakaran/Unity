using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextAnimation : MonoBehaviour
{
    private TextMeshPro m_textMeshPro;
    private Coroutine m_coroutine;
    private Color m_color1;
    private Color m_color2;
    private void Awake()
    {
        m_textMeshPro = GetComponent<TextMeshPro>();
    }

    void Start()
    {
        m_color1 = Color.green;
        m_color2 = Color.red;
        m_coroutine = StartCoroutine(startTextAnimation(new Tuple<Color, Color>(m_color1, m_color2)));
    }
    private IEnumerator startTextAnimation(Tuple<Color, Color> colors)
    {
        var (color1, color2) = colors;
        while (true)
        {
            m_textMeshPro.color = m_textMeshPro.color == color1 ? color2 : color1;
            yield return new WaitForSeconds(1);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            StopCoroutine(m_coroutine);
    }
}
