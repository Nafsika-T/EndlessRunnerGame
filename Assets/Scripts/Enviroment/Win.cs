using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Win : MonoBehaviour
{
    public GameObject liveCoins;
    public GameObject winScreen;
    public TextMeshProUGUI coinDisplay; // Αναφορά στο Coin Display

    public void StartWinSequence()
    {
        // Ενημέρωση της εμφάνισης των νομισμάτων
        coinDisplay.text = "" + CollectableControl.coinCount;
        StartCoroutine(win());
    }

    IEnumerator win()
    {
        //yield return new WaitForSeconds(3);
        liveCoins.SetActive(false);
        winScreen.SetActive(true);
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(0);
    }
}
