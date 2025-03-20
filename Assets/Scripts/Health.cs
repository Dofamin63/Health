using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    private const float _minHealth = 0;

    [SerializeField] private float _maxHealth;
    private float _currentHealth;

    public event Action<float, float> OnHealthChanged;

    private void Awake()
    {
        _currentHealth = _maxHealth;
        NotifyHealthChanged();
    }

    public void TakeDamage(float damage)
    {
        if (damage > _minHealth)
        {
            _currentHealth = Mathf.Clamp(_currentHealth - damage, _minHealth, _maxHealth);
            NotifyHealthChanged();

            if (_currentHealth == _minHealth)
            {
                Die();
            }
        }
    }

    public void Heal(float amountHealthRestore)
    {
        _currentHealth = Mathf.Clamp(_currentHealth + amountHealthRestore, _minHealth, _maxHealth);
        NotifyHealthChanged();
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    private void NotifyHealthChanged()
    {
        OnHealthChanged?.Invoke(_currentHealth, _maxHealth);
    }
}