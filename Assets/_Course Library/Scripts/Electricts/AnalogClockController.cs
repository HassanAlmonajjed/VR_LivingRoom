using System;
using UnityEngine;

public class AnalogClockController : MonoBehaviour
{
    [SerializeField] private Transform _SecondPointer;
    [SerializeField] private Transform _minutesPointer;
    [SerializeField] private Transform _hoursPointer;

    private void Update()
    {
        var time = DateTime.Now;

        UpdateSeconds(time);

        UpdateMinutes(time);

        UpdateHours(time);
    }

    private void UpdateSeconds(DateTime time)
    {
        float angle = CalculateSecondsAngle(time.Second);
        _SecondPointer.rotation = CreateRotationFromAngle(angle);
    }

    private void UpdateMinutes(DateTime time)
    {
        float angle = CalculateSecondsAngle(time.Minute);

        _minutesPointer.rotation = CreateRotationFromAngle(angle);
    }

    private void UpdateHours(DateTime time)
    {
        float angle = CalculateAngle(time);
        _hoursPointer.rotation = CreateRotationFromAngle(angle);

        static float CalculateAngle(DateTime time) => (time.Hour * 30) + 90;
    }

    private float CalculateSecondsAngle(float time) => (time * 6) + 90;

    private Quaternion CreateRotationFromAngle(float angle) => Quaternion.Euler(angle, 0, -90);

}
