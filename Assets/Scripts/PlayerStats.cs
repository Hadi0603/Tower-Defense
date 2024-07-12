using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int money;
    private int startMoney = 300;
    public static int lives;
    public int startlives = 5;
    public static int rounds;
    private void Start()
    {
        lives = startlives;
        money = startMoney;
        rounds = 0;
    }
}
