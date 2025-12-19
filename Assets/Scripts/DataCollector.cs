
using UnityEngine;
using System.Collections.Generic;

public class DataCollector : MonoBehaviour
{
    public StefanLawCalculator calculator;
    public List<DataPoint> dataPoints = new List<DataPoint>();

    public void Collect(float temperature)
    {
        float power = calculator.CalculatePower(temperature);
        dataPoints.Add(new DataPoint(temperature, power));
    }
}
