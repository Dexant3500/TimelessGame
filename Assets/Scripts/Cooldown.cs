using UnityEngine;

[System.Serializable]
public class Cooldown
{
    [SerializeField] private float CooldownTime;
    private float _nextFireTime;
    public bool IsCooldown => Time.time < _nextFireTime;
    public void StartCooldown() => _nextFireTime = Time.time + CooldownTime;
}
