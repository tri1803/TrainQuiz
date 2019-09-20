using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ResultController : MonoBehaviour
{
    public GameObject itemList;
    //public GameObject question;
    //public GameObject square;

    // Start is called before the first frame update
    void Start()
    {
        itemList.SetActive(false);
        //question.SetActive(false);
        //square.SetActive(false);
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(3.5f);
        itemList.SetActive(true);
        //question.SetActive(true);
        //square.SetActive(true);
    }
    
}
