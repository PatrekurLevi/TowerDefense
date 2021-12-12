using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Errortext : MonoBehaviour
{

    public Text errortext;
    public bool notenoughmoney;
    public bool notenoughspace;
    public Animator anim; 
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (notenoughmoney == true)
        {
            errortext.text = "Not enough Money";
            anim.SetTrigger("Error");
            notenoughmoney = false; 
        }

        if (notenoughmoney == false)
        {
            anim.SetTrigger("NoError");
        }
    }
}
