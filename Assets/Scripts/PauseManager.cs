using UnityEngine;
using UnityEngine.InputSystem;

public class PauseManager : MonoBehaviour
{
    [SerializeField] GameObject menuPausa;

    void Start()
    {
        menuPausa.SetActive(false);
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        bool estaPausado = menuPausa.activeSelf;

        if (estaPausado)
        {
            // Volver al juego
            menuPausa.SetActive(false);
            Time.timeScale = 1f;
        }
        else
        {
            // Pausar
            menuPausa.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void ExitGame()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
        
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}