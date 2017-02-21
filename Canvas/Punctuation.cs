using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Punctuation : MonoBehaviour {

    public Bola bola;
    public GameObject punctImg;
    private Vector3 sizeBola;
    private Vector2 position;
    Text t;

    // Use this for initialization
    void Start()
    {
        t = GetComponent<Text>();
        sizeBola = bola.GetComponent<Renderer>().bounds.size;
        position.x = 20;
        position.y = Screen.height - 20;
        //transform.GetComponent<RectTransform>().sizeDelta = sizeBola * (Screen.width / 16);
        transform.position = position;
        t.fontSize = Screen.width / 8;
    }

    public void rePosition()
    {
        t.fontSize = Screen.width / 4;
        t.transform.position = new Vector3((Screen.width / 2), (Screen.height / 1.75f));
    }

}
