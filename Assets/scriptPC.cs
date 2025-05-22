using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class scriptPC : MonoBehaviour{

    public LayerMask mascara;
    public GameObject tiro;
    public GameObject pe;
    private float altura;
    private float largura;
    private float alturaRobo;
    private bool chao;
    private bool direita = true;

    public float pulo;
    private Rigidbody2D rbd;
    private AudioSource som;
    public float vel;

   
    void Start() {
       
        rbd = GetComponent<Rigidbody2D>();
        som = GetComponent<AudioSource>();
        vel = 5;
        pulo = 550;
        altura = Camera.main.orthographicSize;
        
        alturaRobo = GetComponent<SpriteRenderer>().bounds.size.y / 2;

    }
    // Update is called once per frame
    void Update() {

        largura = altura * Camera.main.aspect;

        float x = Input.GetAxis("Horizontal");
        rbd.velocity = new Vector2(x * vel, rbd.velocity.y);

        float y = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space)) {
            rbd.AddForce(new Vector2(0, pulo));
        }

        //DETECTANDO DIREÇÃO
        if(x<0 && direita) {
            transform.Rotate(new Vector2(0, 180));
            direita = false;
        }else if (x>0 && !direita) {
            transform.Rotate(new Vector2(0, 180));
            direita = true;
        }

        //DETECTA O CHAO
            RaycastHit2D hit;
        hit = Physics2D.Raycast(pe.transform.position, Vector2.down, 0.1f, mascara);
        if (hit.collider == null) {
            chao = false;
        } else {
            chao = true;
        }


        //if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            //som.Play();
            //Vector2 posicaoTiro = new Vector2(transform.position.x, transform.position.y - alturaRobo * 0.3f);
            //Instantiate(tiro, posicaoTiro, Quaternion.identity);
        //}
    }
}
