using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voa : MonoBehaviour
{
    private Rigidbody2D Body;
    [SerializeField] private float _forceJump = 10;
    private Diretor diretor;
    private Vector3 posicaoInicial;

    private void Awake(){
        this.posicaoInicial = this.transform.position;
        this.Body = this.GetComponent<Rigidbody2D>();
    }

    private void Start(){
        this.diretor = GameObject.FindObjectOfType<Diretor>();
    }

    private void Update()
    {
        if(Input.GetButtonDown("Jump") || Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2")){
            this._impulsionar();
        }
    }

    private void _impulsionar(){
        this.Body.AddForce(Vector2.up*_forceJump, ForceMode2D.Impulse);
    }

    public void Reiniciar(){
        this.transform.position = this.posicaoInicial;
        this.Body.simulated = true;
    }

    private void OnCollisionEnter2D(Collision2D colisao){
        this.Body.simulated = false;
        this.diretor.FinalizarJogo();
    }
}
