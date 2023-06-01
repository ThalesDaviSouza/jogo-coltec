using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    [SerializeField] private GameObject _obstaculo;
    [SerializeField] private float _tempoParaGerar;
    private float _cronometro;

    private void Awake(){
        this._cronometro = this._tempoParaGerar;
    }

    private void Update () {
        //Quando que eu quero gerar? Tempo
        this._cronometro -= Time.deltaTime;
        if(this._cronometro < 0){
            GameObject.Instantiate(this._obstaculo, this.transform.position, Quaternion.identity);
            this._cronometro = this._tempoParaGerar;
        }

    }
}
