using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField] private GameObject imagemGameOver;
    private voa aviao;

    public void FinalizarJogo(){
        Time.timeScale = 0;
        //habilitar a imagem Game Over
        this.DestruirObstaculos();
        this.imagemGameOver.SetActive(true);
    }

    private void Start(){
        this.aviao = GameObject.FindObjectOfType<voa>();
    }

    private void DestruirObstaculos(){
        obstaculo[] obstaculos = GameObject.FindObjectsOfType<obstaculo>();
        foreach(obstaculo obstaculo in obstaculos){
            obstaculo.Destruir();
        }
    } 

    public void ReiniciarJogo() {
        this.imagemGameOver.SetActive(false);
        Time.timeScale = 1;
        this.aviao.Reiniciar();
        this.DestruirObstaculos();
    }
}
