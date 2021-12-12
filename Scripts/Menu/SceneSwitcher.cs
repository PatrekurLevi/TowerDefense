using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public Button gamebutton;

    [SerializeField]
    public string _SwitchTo;
    // Start is called before the first frame update
    void Start()
    {
        gamebutton.onClick.AddListener(ReturnToMain);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ReturnToMain()
    {
        SceneManager.LoadScene(_SwitchTo);
    }
}
