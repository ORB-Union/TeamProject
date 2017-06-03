using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour {

    //먼저 변수선언.

    private Quaternion Right = Quaternion.identity;
    private Quaternion Left = Quaternion.identity;
    private Quaternion Mid = Quaternion.identity;

    float Move;
    // Use this for initialization

    void Start()
    {

        Right.eulerAngles = new Vector3(0, 0, 90);
        Mid.eulerAngles = new Vector3(0, 0, 0);
        Left.eulerAngles = new Vector3(0, 0, 90);

    }

    void Awake()
    {
        
    }

   // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Right, Time.deltaTime * 1.0f);
        /*
        //transform.rotation = Quaternion.Angle(Right, Left);
        if(transform.eulerAngles.z >= 0 && transform.eulerAngles.z <= 90)
        {

            transform.rotation = Quaternion.Slerp(transform.rotation, Right, Time.deltaTime * 1.0f);
            if (transform.eulerAngles.z <= 90)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Left, Time.deltaTime * 1.0f);
            }
        }
        */

        //
    }
}
