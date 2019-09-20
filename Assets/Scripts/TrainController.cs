using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainController : MonoBehaviour
{
    // Start is called before the first frame update
    public int numberCabin;
    public Transform parent;
    public GameObject cabin;
    public Transform transformTrain;
    public GameObject train;
    private int speed=100;
    private Vector3 checkTransform;
    void Start()
    {
        for(int i=0;i<numberCabin;i++)
        {
            Instantiate(cabin, parent);
            
        }
        transformTrain.SetSiblingIndex(numberCabin);
        //train = GameObject.FindGameObjectWithTag("Train");
        checkTransform = train.transform.position;
        checkTransform.x = 50.0f;
        speed = 100;
        //train.transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f);
    }


    // Update is called once per frame
    void Update()
    {
        train.transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f);
        if (train.transform.position.x >= checkTransform.x)
        {
            speed = 0;
            train.transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f);
        }
    }
}
