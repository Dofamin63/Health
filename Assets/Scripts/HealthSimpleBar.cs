public class HealthSimpleBar : HealthBarBase
{
    protected override void UpdateHealth()
    {
        HealthSlider.value = TargetHealth;
    }
}