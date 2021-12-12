using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelbackButton : MonoBehaviour
{
    public Button yourButton;
    public GameObject StartCanvas;
    public GameObject LevelCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the Back Button!");
        StartCanvas.SetActive(true);
        LevelCanvas.SetActive(false);
    }
}
