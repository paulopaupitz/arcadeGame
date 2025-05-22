using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCamera : MonoBehaviour {

    public GameObject Pc;
    public float offsetY;
    public float zoomLevel = 5f;   //nivel zoom

    // Start is called before the first frame update
    void Start() {

        offsetY = 2;
        Camera.main.orthographicSize = zoomLevel; //mudar o zoom
    }

    // Update is called once per frame
    void Update() {
        transform.position = new Vector3(Pc.transform.position.x, Pc.transform.position.y+ offsetY, -10);
    }
}
