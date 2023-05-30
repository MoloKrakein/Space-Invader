internal interface IHealth
{
    void TakeDamage(int damage);
    void Heal(int healAmount);
    bool IsDead();
}