﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpgrade : MonoBehaviour
{
    /// <summary>
    /// Valeur de l'énergie regagner au contact
    /// </summary>
    [SerializeField]
    private int _gainPoint = 3;
    [SerializeField]
    private AudioClip _clip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            GameManager.Instance.AudioManager
                .PlayClipAtPoint(_clip, this.transform.position);
            GameManager.Instance
                .PlayerData.IncrScore(this._gainPoint);
            GameManager.Instance.PlayerData.NbConcention();
            GameObject.Destroy(this.gameObject);
        }
    }
}
