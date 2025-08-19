using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject liveCoins;
    public GameObject endScreen;
    //public GameObject FadeOut;

    void Start()
    {
        StartCoroutine(gameOver());
    }

    IEnumerator gameOver()
    {
        yield return new WaitForSeconds(3);
        liveCoins.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);

       // fadeOut.SetActive(true);
    }


}
