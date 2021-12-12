using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionButton : MonoBehaviour
{
    public Button yourButton;
    public GameObject StartCanvas;
    public GameObject OptionCanvas;
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
        Debug.Log("You have clicked the Option Button!");
        StartCanvas.SetActive(false);
        OptionCanvas.SetActive(true);
    }
}

