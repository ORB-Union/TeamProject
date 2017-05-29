using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SujungBreak : MonoBehaviour {

    Animator animator;
    Rigidbody rb;
    GameObject Sujung;

    // Use this for initialization
    void Start() {

    }

    void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();  // rigidbody에서 지원하는 AddForce를 사용하기 위해
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Kuriko")
        {
            animator.SetBool("Breaking", true);
            DestroyObject(gameObject, 3.0f);
        }
    }
}
