using System.Collections;
using UnityEngine;

using static UnityEngine.Mathf;

public class CircleRoll : MonoBehaviour
{
    public float RollSpeed;
    public float Width;
    public float ScaleSpeed;
    
    private Coroutine m_coroutineRoll;
    private Coroutine m_coroutineScale;

    private void Start()
    {
        m_coroutineRoll = StartCoroutine(roll());
        m_coroutineScale = StartCoroutine(scale());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
            StopAllCoroutines();
    }

    private IEnumerator roll()
    {
        float angle = 0;

        while (true) {
            angle += Time.deltaTime * RollSpeed;

            float x = Sin(angle * Deg2Rad);
            float y = Cos(angle * Deg2Rad);
            transform.position = new Vector3(x, y, 0) * Width;
            yield return null;
        }        
    }


    private IEnumerator scale()
    {
        while (true) {
            float scaleVal = Abs(Sin(Time.time * ScaleSpeed * Deg2Rad));
            transform.localScale = Vector3.one * scaleVal;
            yield return null;
        }
    }

}
