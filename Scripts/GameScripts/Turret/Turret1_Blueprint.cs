using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret1_Blueprint : MonoBehaviour
{
    RaycastHit hit;
    Vector3 movePoint;
    public GameObject prefab;
    public GameObject Build;
    public GameObject NoBuild;


    //Buildingpermissions

    //Buttons


    // Start is called before the first frame update
    void Start()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 500000.0f))
        {
            transform.position = hit.point;
        }


    }




    // Update is called once per frame
    void Update()
    {


        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 500000.0f) && hit.transform.gameObject.tag != "NoBuild")
        {
            transform.position = hit.point;
            Build.SetActive(true);
            NoBuild.SetActive(false);
        }

        if (Physics.Raycast(ray, out hit, 500000.0f) && hit.transform.gameObject.tag == "NoBuild")
        {
            transform.position = hit.point;
            Build.SetActive(false);
            NoBuild.SetActive(true);
        }



        if (Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject); 
        }

        if (Input.GetMouseButtonDown(1))
        {
            Destroy(gameObject);
        }

    }
}
