using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpriteAnimation : MonoBehaviour
{
    private SpriteRenderer m_spriteRenderer;
    private Coroutine m_coroutine;
    private float m_Red, m_Green, m_Blue;
    private Color m_newColor;
    private void Awake()
    {
        m_spriteRenderer = GetComponent<SpriteRenderer>();
        m_spriteRenderer.color = Color.yellow;
    }
    
    private IEnumerator startSpriteAnimation()
    {
        while (true)
        {
            Color c = m_spriteRenderer.material.color;
            for (float alpha = 1f; alpha >= 0; alpha -= 0.1f)
            {
                float r = Random.Range(0f, 1f);
                float g = Random.Range(0f, 1f);
                float b = Random.Range(0f, 1f);
                c.r = r;
                c.g = g;
                c.b = b;
                c.a = alpha;
                m_spriteRenderer.material.color = c;
                yield return new WaitForSeconds(1);
            }
        }
    }

    void Start()
    {
        m_coroutine = StartCoroutine(startSpriteAnimation());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            StopCoroutine(m_coroutine);
    }
}
