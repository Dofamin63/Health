using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public abstract class HealthBarView : MonoBehaviour
{
    [SerializeField] private Health _health;
    protected Slider healthSlider;
    protected float targetHealth;

    private void Awake()
    {
        healthSlider = GetComponent<Slider>();
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
        targetHealth = currentHealth / maxHealth;
        UpdateHealth();
    }

    protected abstract void UpdateHealth();
}