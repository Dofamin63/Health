using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public abstract class HealthBarBase : MonoBehaviour
{
    [SerializeField] private Health _health;
    protected Slider HealthSlider;
    protected float TargetHealth;

    private void Awake()
    {
        HealthSlider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _health.OnHealthChanged += CalculateHealth;
    }

    private void OnDisable()
    {
        _health.OnHealthChanged -= CalculateHealth;
    }

    private void CalculateHealth(float currentHealth, float maxHealth)
    {
        TargetHealth = currentHealth / maxHealth;
        UpdateHealth();
    }

    protected abstract void UpdateHealth();
}