using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DropZone : MonoBehaviour, IDropHandler
{
    // public GameObject train;
    private GameObject train;
    string nameGameObject = "";
    bool checkedQuestion = false;
    private int speed;
    private Vector3 checkTransform;

    private void Start()
    {
        //StartCoroutine(Example(3.0f));     
        train = GameObject.FindGameObjectWithTag("Train");
        checkTransform = train.transform.position;
        checkTransform.x = 300.0f;
        speed = 100;
        
        StartCoroutine(Wait());
        IEnumerator Wait()
        {
            speed = 0;
            yield return new WaitForSeconds(3);
            speed = 100;
        }
        
    }
    public void OnDrop(PointerEventData eventData)
    {
        Draggle d = eventData.pointerDrag.GetComponent<Draggle>();
        if (d != null)
        {
            d.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            if (gameObject.tag == "Question")
            {
                nameGameObject = eventData.pointerDrag.name;
                d.transform.localScale = new Vector3(0.9f, 0.7f, 1f);
            }
            d.parentToReturnTo = this.transform;
        }
    }
    private void Update()
    {
        train.transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f);
        if (nameGameObject == "Result2")
            SceneManager.LoadScene("New");

        if (checkedQuestion == false)
        {
            if (train.transform.position.x >= checkTransform.x)
            {
                speed = 0;
                train.transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f);
            }
            if (nameGameObject == "Result1")
            {
                checkedQuestion = true;
                speed = 70;
                train.transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f);
                StartCoroutine(Example(1f));
                Debug.Log(checkedQuestion);
                //checkTransform.x = 100.0f;

            }
        }
    }
    IEnumerator Example(float second)
    {
        yield return new WaitForSeconds(second);
        speed = 0;
    }
    struct Obj
    {
        string question;
        string[] rs;
    }
    private int n;
    Obj[] name;
}