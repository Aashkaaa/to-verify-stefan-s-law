
using UnityEngine;

public class StefanLawCalculator : MonoBehaviour
{
    public float area = 1f;
    const float sigma = 5.67e-8f;

    public float CalculatePower(float temperature)
    {
        return sigma * area * Mathf.Pow(temperature, 4);
    }
}
