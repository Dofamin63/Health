using System.Collections;
using UnityEngine;

public class HealthSmoothBar : HealthBarBase
{
    [SerializeField] private float _smoothSpeed;

    protected override void UpdateHealth()
    {
        StartCoroutine(SmoothUpdateHealth(TargetHealth));
    }

    private IEnumerator SmoothUpdateHealth(float targetHealth)
    {
        while (Mathf.Approximately(HealthSlider.value, targetHealth) == false)
        {
            HealthSlider.value = Mathf.MoveTowards(HealthSlider.value, targetHealth, _smoothSpeed * Time.deltaTime);
            yield return null;
        }
    }
}