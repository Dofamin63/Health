using TMPro;
using UnityEngine;

public class HealthText : MonoBehaviour
{
    [SerializeField] private Health _health;
    private TextMeshProUGUI _healthText;
    
    private void Awake()
    {
        _healthText = GetComponent<TextMeshProUGUI>();
        _health.OnHealthChanged += UpdateHealth;
    }

    private void OnDisable()
    {
        _health.OnHealthChanged -= UpdateHealth;
    }

    private void UpdateHealth(float currentHealth, float maxHealth)
    {
        _healthText.text = $"{currentHealth} / {maxHealth}";
    }
}
