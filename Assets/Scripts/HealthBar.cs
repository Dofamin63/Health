using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health _health;
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
        _healthSlider.value = currentHealth / maxHealth;
    }
}
