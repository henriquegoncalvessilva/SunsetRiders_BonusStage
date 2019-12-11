﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemyBonusSunset : MonoBehaviour
{
    [SerializeField]
    Sprite spriteDie, spriteLive;

    /*[SerializeField]
    SpriteRenderer sprite;*/

    [SerializeField]
    Animator anim;

    [SerializeField]
    bool die;


    private void Update()
    {
        anim.SetBool("Die", die);
    }

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void OnMouseDown()
    {

        die = true;
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        Debug.LogError(this.gameObject.name);
       StartCoroutine(Reset());

    }

    IEnumerator Reset()
    {
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        Debug.Log("Olá");
      yield return new WaitForSeconds(1);
        this.gameObject.SetActive(false);
        die = false;
        anim.SetBool("Die", false);
        this.gameObject.GetComponent<BoxCollider2D>().enabled = true;


    }

    void Die()
    {
        die = false;
        this.gameObject.GetComponent<BoxCollider2D>().enabled = true;



    }
}
