using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankingButton : MonoBehaviour {

    public Bola bola;
    private Vector3 sizeBola;
    private Vector2 position;

    // Use this for initialization
    void Start()
    {
        sizeBola = bola.GetComponent<Renderer>().bounds.size;
        position.x = (Screen.width / 1.75f);
        position.y = (Screen.height / 4) / 1.5f;
        transform.GetComponent<RectTransform>().sizeDelta = sizeBola * (Screen.width / 16);
        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
