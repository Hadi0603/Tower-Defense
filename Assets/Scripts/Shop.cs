using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public static Transform cubePosition;
    public GameObject buildEffect;
    [Header("Cannon")]
    public GameObject canon;
    public int cannonPrice;
    [Header("Laser Beam")]
    public GameObject laserBeam;
    public int laserBeamPrice;
    [Header("MG Tower")]
    public GameObject mgTower;
    public int mgTowerPrice;
    [Header("Missile Tower")]
    public GameObject missileTower;
    public int missileTowerPrice;
    public void PurchaseCanon()
    {
        if (PlayerStats.money >= cannonPrice)
        {
            PlayerStats.money -= cannonPrice;
            Vector3 towerPosition = cubePosition.position + new Vector3(0, 0.1f, 0);
            Quaternion towerRotation = cubePosition.rotation;
            Instantiate(canon, towerPosition, towerRotation);
            GameObject effect = (GameObject)Instantiate(buildEffect, towerPosition, towerRotation);
            Destroy(effect, 3f);
        }
        else
        {
            Debug.Log("Not Enough Money!");
        }
        gameObject.SetActive(false);
    }
    public void PurcahseLaserBeam()
    {
        if(PlayerStats.money >= laserBeamPrice)
        {
            PlayerStats.money -= laserBeamPrice;
            Vector3 towerPosition = cubePosition.position + new Vector3(0, 0.1f, 0);
            Quaternion towerRotation = cubePosition.rotation;
            Instantiate(laserBeam, towerPosition, towerRotation);
            GameObject effect = (GameObject)Instantiate(buildEffect, towerPosition, towerRotation);
            Destroy(effect, 3f);
        }
        else
        {
            Debug.Log("Not Enough Money!");
        }
        gameObject.SetActive(false);
    }
    public void PurchaseMissileTower()
    {
        if (PlayerStats.money >= missileTowerPrice)
        {
            PlayerStats.money -= missileTowerPrice;
            Vector3 towerPosition = cubePosition.position + new Vector3(0, 0.1f, 0);
            Quaternion towerRotation = cubePosition.rotation;
            Instantiate(missileTower, towerPosition, towerRotation);
            GameObject effect = (GameObject)Instantiate(buildEffect, towerPosition, towerRotation);
            Destroy(effect, 3f);
        }
        else
        {
            Debug.Log("Not Enough Money!");
        }
        gameObject.SetActive(false);
    }
    public void PurchseMgTower()
    {
        if (PlayerStats.money >= mgTowerPrice)
        {
            PlayerStats.money -= mgTowerPrice;
            Vector3 towerPosition = cubePosition.position + new Vector3(0, 0.1f, 0);
            Quaternion towerRotation = cubePosition.rotation;
            Instantiate(mgTower, towerPosition, towerRotation);
            GameObject effect = (GameObject)Instantiate(buildEffect, towerPosition, towerRotation);
            Destroy(effect, 3f);
        }
        else
        {
            Debug.Log("Not Enough Money!");
        }
        gameObject.SetActive(false);
    }
    public void Cancel()
    {
        gameObject.SetActive(false);
    }
}
