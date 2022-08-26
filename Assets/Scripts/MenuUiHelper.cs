using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUiHelper : MonoBehaviour
{
    public GameObject NoPlayerName;
    public InputField inputText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LoadGame() {
        if (inputText.text.Equals(""))
        {
            NoPlayerName.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene(1);
            MenuManager.Instance.playerName = inputText.text;
            NoPlayerName.SetActive(false);
            
        
        }
        }
}
