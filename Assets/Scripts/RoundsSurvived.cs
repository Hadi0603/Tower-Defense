using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundsSurvived : MonoBehaviour
{
    public Text roundsText;
    private void OnEnable()
    {
        Time.timeScale = 1f;
        StartCoroutine(AnimateText());
    }
    IEnumerator AnimateText()
    {
        roundsText.text = "0";
        int round = 0;
        while (round < PlayerStats.rounds)
        {
            round++;
            roundsText.text = round.ToString();
            yield return new WaitForSeconds(.1f);
        }
    }
}
