
using UnityEngine;
using System.Collections.Generic;

public class GraphPlotter : MonoBehaviour
{
    public LineRenderer line;
    public DataCollector collector;
    public float scaleX = 0.001f;
    public float scaleY = 1e7f;

    void Update()
    {
        Plot();
    }

    void Plot()
    {
        List<DataPoint> data = collector.dataPoints;
        line.positionCount = data.Count;

        for (int i = 0; i < data.Count; i++)
        {
            line.SetPosition(i, new Vector3(
                data[i].temperature * scaleX,
                data[i].power * scaleY,
                0
            ));
        }
    }
}
