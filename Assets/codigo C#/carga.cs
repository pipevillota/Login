using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class carga : MonoBehaviour
{
    public Image loadingfill;

    void Start()
    {
        StartCoroutine(Loading());

    }
    IEnumerator Loading()
    {
        AsyncOperation loading = SceneManager.LoadSceneAsync("SampleScene");

        while (!loading.isDone)
        {
            loadingfill.fillAmount = loading.progress / 0.9f;
            yield return null;
        }
    }
}
