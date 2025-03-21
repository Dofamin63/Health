using UnityEngine;
using UnityEngine.UI;

public abstract class HealthChanger : MonoBehaviour
{
    [SerializeField] protected Health Health; 
    [SerializeField] protected float CountHealth;
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(Change);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(Change);
    }

    protected abstract void Change();
}
