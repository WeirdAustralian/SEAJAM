using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class TrashMove : MonoBehaviour
{
    public float speed;

    public CoinHandle ch;

    // Start is called before the first frame update
    void Start()
    {
        ch = FindObjectOfType<CoinHandle>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Random.Range(0, speed));
    }

    private void OnMouseDown()
    {
        Destroy(this.gameObject);
        ch.CoinAdd(this.gameObject);
    }
}
