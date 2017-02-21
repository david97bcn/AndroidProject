using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunctuationMenu : MonoBehaviour {

    public Bola bola;
    private Vector3 sizeBola;
    private Vector2 position;

    // Use this for initialization
    void Start()
    {
        sizeBola = bola.GetComponent<Renderer>().bounds.size;
        position.x = (Screen.width / 2);
        position.y = (Screen.height / 1.75f);
        transform.GetComponent<RectTransform>().sizeDelta = sizeBola * (Screen.width / 12);
        transform.position = position;
    }

}
