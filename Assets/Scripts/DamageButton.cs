public class DamageButton : HealthChanger
{
    protected override void Change()
    {
        health.TakeDamage(countHealth);
    }
}
