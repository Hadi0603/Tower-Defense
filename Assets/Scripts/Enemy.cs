using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float startSpeed = 3f;
    [HideInInspector]
    public float speed;
    public float startHealth = 100;
    private float health;
    public int moneyGain = 50;
    public GameObject deatheffect;
    private bool isDead = false;
    [Header("Unity Stuff")]
    public Image healthBar;
    private void Start()
    {
        health = startHealth;
        speed = startSpeed;
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        healthBar.fillAmount = health / startHealth;
        if (health <= 0 && !isDead)
        {
            Die();
        }
    }
    public void Slow(float pct)
    {
        speed = startSpeed * (1f - pct);
    }
    void Die()
    {
        isDead = true;
        GameObject effect = (GameObject)Instantiate(deatheffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
        PlayerStats.money += moneyGain;
        WaveSpawner.enemiesAlive--;
        Destroy(gameObject);
    }
}
