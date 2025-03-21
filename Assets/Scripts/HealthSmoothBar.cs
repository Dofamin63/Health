using System.Collections;
using UnityEngine;

public class HealthSmoothBar : HealthBarView
{
    [SerializeField] public float smoothSpeed;

    protected override void UpdateHealth()
    {
        StartCoroutine(SmoothUpdateHealth(targetHealth));
    }

    private IEnumerator SmoothUpdateHealth(float targetHealth)
    {
        while (Mathf.Approximately(healthSlider.value, targetHealth) == false)
        {
            healthSlider.value = Mathf.MoveTowards(healthSlider.value, targetHealth, smoothSpeed * Time.deltaTime);
            yield return null;
        }
    }
}