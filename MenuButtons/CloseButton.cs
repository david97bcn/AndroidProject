﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour {

    public Bola bola;
    private Vector3 sizeBola;
    private Vector2 position;

    // Use this for initialization
    void Start()
    {
        sizeBola = bola.GetComponent<Renderer>().bounds.size;
        position.x = Screen.width - 10;
        position.y = Screen.height - 10;
        transform.GetComponent<RectTransform>().sizeDelta = sizeBola * (Screen.width / 16);
        transform.position = position;
    }

}
