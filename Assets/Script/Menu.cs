using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject sivazona;
    [SerializeField] GameObject sivazona2;
    [SerializeField] GameObject loading;
    [SerializeField] GameObject clickingName;
    [SerializeField] GameObject clickingJoke;
    [SerializeField] GameObject PlayButton;

    int i = 0;

    private void Start()
    {
        StartCoroutine(Clicking());
    }

    public void Play()
    {
        i = 2;
        StopCoroutine(Clicking());
        PlayButton.SetActive(false);
        clickingName.SetActive(false);
        sivazona.SetActive(false);
        sivazona2.SetActive(true);
        loading.SetActive(true);
        StartCoroutine(Clicking2());
        StartCoroutine(Loading());

    }

    IEnumerator Loading()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    IEnumerator Clicking()
    {
        while (i < 1)
        {
            yield return new WaitForSeconds(0.5f);
            clickingName.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            clickingName.SetActive(true);
        }
        clickingName.SetActive(false);
    }
    IEnumerator Clicking2()
    {
        while (0 < 1)
        {
            yield return new WaitForSeconds(0.5f);
            clickingJoke.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            clickingJoke.SetActive(true);
        }
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
