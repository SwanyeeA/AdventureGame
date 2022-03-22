using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;


public class PlayerCode : MonoBehaviour
{
    NavMeshAgent _navAgent;

    Camera mainCam;

    public TextMeshProUGUI scoreUI;


    public static class PublicVars 
    {
        public static int score = 0;
    }

    void Start()
    {
        _navAgent = GetComponent<NavMeshAgent>();
        mainCam = Camera.main;
        scoreUI.text = "Score: " + PublicVars.score;
    }

    private void Update() 
    {
        {
            if(Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                if(Physics.Raycast(mainCam.ScreenPointToRay(Input.mousePosition),out hit, 200))
                {
                    _navAgent.destination = hit.point;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other) 
    {    
        if(other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            PublicVars.score++;
            scoreUI.text = "Gold: " + PublicVars.score;
        }

        if(other.CompareTag("BlueKey"))
        {
            Destroy(other.gameObject);
            scoreUI.text += "Blue Key";
        }
    }
}
