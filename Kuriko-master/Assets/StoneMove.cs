﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoneMove : MonoBehaviour
{
    public GameObject kuriko;
    GameObject Stone;
    bool fly = false;
    // Use this for initialization
    void Start()
    {
        kuriko = GameObject.Find("KURIKO");
    }

    // Update is called once per frame
    void Update()
    {
        if(kuriko.transform.position.x >= 28.3f && kuriko.transform.position.y >=3.6f)
            transform.Translate(new Vector3(0.0f, 0.1f, 0.0f));

		if(kuriko.transform.position.x >= 28.0f && kuriko.transform.position.y >=14.5f) //목표지점 도달시 씬 이동
			SceneManager.LoadScene ("clear01");
    }

}