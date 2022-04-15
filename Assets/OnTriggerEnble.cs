using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class OnTriggerEnble : MonoBehaviour
{
    private void Awake()
    {
        _toBeActivated.SetActive(false);
    }

    [SerializeField]
    private GameObject _toBeActivated;

    private void OnCollisionEnter2D(Collision2D other)
    {
        _toBeActivated.SetActive(true);
        Destroy(gameObject,0.1f);
    }

}
