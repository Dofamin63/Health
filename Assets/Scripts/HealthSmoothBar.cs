using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthSmoothBar : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] public float smoothSpeed;
    
    private Slider _healthSlider;
    
    private void Awake()
    {
        _healthSlider = GetComponent<Slider>();
        _health.OnHealthChanged += UpdateHealth;
    }

    private void OnDisable()
    {
        _health.OnHealthChanged -= UpdateHealth;
    }

    private void UpdateHealth(float currentHealth, float maxHealth)
    {
        float targetHealth = currentHealth / maxHealth;
        
        StopAllCoroutines();
        StartCoroutine(SmoothUpdateHealth(targetHealth));
    }
    
    private IEnumerator SmoothUpdateHealth(float targetHealth)
    {
        while (Mathf.Approximately(_healthSlider.value, targetHealth) == false)
        {
            _healthSlider.value = Mathf.MoveTowards(_healthSlider.value, targetHealth, smoothSpeed * Time.deltaTime);
            yield return null; 
        }
    }
}
