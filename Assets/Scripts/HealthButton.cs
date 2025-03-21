public class HealthButton : HealthChanger
{
    protected override void Change()
    {
        Health.Heal(CountHealth);
    }
}
