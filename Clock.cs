using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    private string padWithZero(int count)
    {
        return count.ToString().PadLeft(2, '0');
    }
    public string Now()
    {
        var now = DateTime.Now;
        var day = now.Day;
        var mon = now.Month;
        var year = now.Year;
        var hour = padWithZero(now.Hour);
        var min = padWithZero(now.Minute);
        var sec = padWithZero(now.Second);

        return $"{day}/{mon}/{year} {hour}:{min}:{sec}";
    }
}
