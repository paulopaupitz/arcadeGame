using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptNPC : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float vel = 5;



    // Start is called before the first frame update


    private void OnTriggerEnter2D(Collider2D collision)
    {
        scriptPlacar.addPlacar(5);
        Debug.Log("ACERTOU");
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }




    void Start()
    {
      rbd = GetComponent<Rigidbody2D>();
      rbd.velocity = new Vector2(0, -vel);

    }

    // Update is called once per frame
    void Update()
    {
      if(transform.position.y < -Camera.main.orthographicSize)
        {
            Destroy(gameObject);
        }
    }
}
