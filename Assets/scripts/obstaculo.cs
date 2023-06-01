using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    [SerializeField] private float _speed = 0.17f;
    [SerializeField] private float variacaoDaPosicaoY = 1;

    // Update is called once per frame
    private void FixedUpdate()
    {
        this.transform.Translate(Vector3.left*this._speed);
    }

    private void Awake(){
        this.transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, 1));
    }

    private void OnCollisionEnter2D(Collision2D outro){
        if(outro.gameObject.tag == "DESTRUIR"){
            Destruir();
        }
    }

    public void Destruir(){
        Destroy(this.gameObject);
    }


}
