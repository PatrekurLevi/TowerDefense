using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpawnTurret : MonoBehaviour
{

    RaycastHit hit;
    Vector3 movePoint;
    
    //turrets to spawn 
    public GameObject prefab;
    public GameObject prefabblueprint;
    public GameObject prefabsentry;
    public GameObject prefabblueprintsentry;
    
    //ui and other stuff
    public Text MoneyText;
    public float Money = 500;
    public Canvas errortext;
    public Canvas errortext2;


    //Buildingpermissions
    public bool turret1 = false;
    public bool turret2 = false;


    //Buttons
    public Button turret1button;
    public Button turret2button; 

    // Start is called before the first frame update
    void Start()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 

        if(Physics.Raycast(ray, out hit, 500000.0f))
        {
            transform.position = hit.point; 
        }

        Button btn1 = turret1button.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick);

        Button btn2 = turret2button.GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnClick2);


        
    }




    // Update is called once per frame
    void Update()
    {



        MoneyText.text = Money + "$"; 
         
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 500000.0f) && hit.transform.gameObject.tag != "NoBuild")
        {
            transform.position = hit.point;
        }


        //turret 1
        if (Input.GetMouseButtonDown(0) && turret1 == true && hit.transform.gameObject.tag != "NoBuild")
        {
            Instantiate(prefab, transform.position, prefab.transform.rotation);
            turret1 = false;
            Money = Money - 300;
        }

        if (Input.GetMouseButtonDown(0) && turret1 == true && hit.transform.gameObject.tag == "NoBuild")
        {
            turret1 = false;
            Instantiate(errortext2);
        }


        //turret 2
        if (Input.GetMouseButtonDown(0) && turret2 == true && hit.transform.gameObject.tag != "NoBuild")
        {
            Instantiate(prefabsentry, transform.position, prefab.transform.rotation);
            turret2 = false;
            Money = Money - 100;
        }
        
        if (Input.GetMouseButtonDown(0) && turret2 == true && hit.transform.gameObject.tag == "NoBuild")
        {
            turret2 = false;
            Instantiate(errortext2);
        }

        //reset building
        if (Input.GetMouseButtonDown(1))
        {
            turret1 = false;
            turret2 = false;
        }
    }

    void TaskOnClick()
    {
            if (Money > 299)
            {
                turret1 = true;
                Instantiate(prefabblueprint, transform.position, prefab.transform.rotation);
            }
            else
            {
                Debug.Log("Not enough Money");
                Instantiate(errortext);
            }
        
    }

    void TaskOnClick2()
    {
        if (Money > 99)
        { 
            turret2 = true;
            Instantiate(prefabblueprintsentry, transform.position, prefab.transform.rotation);
        }
        else
        {
            Debug.Log("Not enough Money");
            Instantiate(errortext);
        }
    }


}
