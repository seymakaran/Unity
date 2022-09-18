using System;
using UnityEngine;
using Karan.Util;

public class ExplosionInMountain : Singleton<ExplosionInMountain>
{
    private DateTime m_start;
    private DateTime m_end;
    private void Start()
    {
        m_start = DateTime.Now;
        Debug.Log($"Start time: {m_start}");
    }

    private void OnApplicationQuit()
    {
        m_end = DateTime.Now;
        Debug.Log($"End time: {m_end}");

        var ts = m_end - m_start;
        Debug.Log($"Time in seconds: {ts.TotalSeconds}");
        Application.Quit();
    }

    public override void Awake()
    {
        base.Awake();
        //...
    }
}
