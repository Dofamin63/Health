public class HealthSimpleBar : HealthBarView
{
    protected override void UpdateHealth()
    {
        healthSlider.value = targetHealth;
    }
}