
using UnityEngine;

[System.Serializable]
public class DataPoint
{
    public float temperature;
    public float power;

    public DataPoint(float t, float p)
    {
        temperature = t;
        power = p;
    }
}
