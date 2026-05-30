using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public class butoon : MonoBehaviour
{
    // Variáveis editáveis no Inspector
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;

    // Método para o botão JOGAR
    public void Jogar()
    {
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }

    // Método para ABRIR OPÇÕES
    public void AbrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    // Método para FECHAR OPÇÕES
    public void FecharOpcoes()
    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }

    // Método para o botão SAIR
    public void SairDoJogo()
    {
        Debug.Log("Saindo do jogo..."); // Para testes no Editor
        Application.Quit(); // Funciona no build final
    }
}

