public class DamageButton : HealthChanger
{
    protected override void Change()
    {
        Health.TakeDamage(CountHealth);
    }
}
