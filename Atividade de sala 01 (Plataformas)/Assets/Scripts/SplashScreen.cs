using UnityEngine;

public class SplashScreen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("IrParaMainMenu", 2f);
    }

    void IrParaMainMenu()
    {
        GameManager.Instance.LoadScene("MainMenu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
