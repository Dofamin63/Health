public class HealthSimpleBar : HealthBarBase
{
    protected override void UpdateHealth()
    {
        healthSlider.value = targetHealth;
    }
}