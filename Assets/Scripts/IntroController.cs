using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroController : MonoBehaviour
{
    public GameObject intro;
    void Start()
    {
        intro.SetActive(true);
        StartCoroutine(Example());
    }
    IEnumerator Example()
    {
        yield return new WaitForSeconds(3.0f);
        intro.SetActive(false);
    }
}
