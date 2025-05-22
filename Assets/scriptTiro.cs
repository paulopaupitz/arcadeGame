using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptTiro : MonoBehaviour
{

    private Rigidbody2D rbd;
    public float vel;


    void Start()
    {
        vel = 11;
        rbd = GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(vel, 0);


    }

    // Update is called once per frame
    void Update()
    {
        // Obtém a posição da borda direita da tela em coordenadas do mundo
        float limiteDireitoDaTela = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;

        if (transform.position.x > limiteDireitoDaTela)
            Destroy(gameObject);

    }
}
