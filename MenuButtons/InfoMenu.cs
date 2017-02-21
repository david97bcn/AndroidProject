using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoMenu : MonoBehaviour {

    public Bola bola;
    private Vector3 sizeBola;
    private Vector2 position;

    // Use this for initialization
    void Start()
    {
        sizeBola = bola.GetComponent<Renderer>().bounds.size;
        position.x = (Screen.width / 4) * 3.5f;
        position.y = (Screen.height / 4) / 3.5f;
        transform.GetComponent<RectTransform>().sizeDelta = sizeBola * (Screen.width / 16);
        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
