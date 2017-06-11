using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour {

    public GameObject BossBullet; // BULLET position
    public GameObject BossMissilePos; // BULLET position prefab

    public Animator anim;


    public bool Attack;
    public float AttackTimer;
    public float AttackCd;

    // Use this for initialization



    void Start ()
    {
       
        InvokeRepeating("Fire", 1, 3.0f);
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once perframe
	void Update () {
           
	}


    void Fire()
    {
        GameObject bossbullet01 = (GameObject)Instantiate(BossBullet);
        bossbullet01.transform.position = BossMissilePos.transform.position;
    }
}
