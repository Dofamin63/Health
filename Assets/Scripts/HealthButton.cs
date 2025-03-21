public class HealthButton : HealthChanger
{
    protected override void Change()
    {
        health.Heal(countHealth);
    }
}
