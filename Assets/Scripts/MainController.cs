using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene"); // Reemplaza por el nombre real de la escena del juego
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Salir del juego"); // Solo se ve en editor
    }

    public void ShowCredits()
    {
        // Aquí podrías cargar otra escena o abrir un panel con créditos
        Debug.Log("Créditos del juego");
    }

    public void ShowOptions()
    {
        Debug.Log("Opciones aún no implementadas");
    }
}
