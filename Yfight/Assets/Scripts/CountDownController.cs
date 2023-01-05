using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDownController : MonoBehaviour
{

    public int countdownTime;
    public TextMeshProUGUI countdownText;
    PlayerController controller1;
    PlayerController controller2;
    PowerUpController power;
    ObstacleController obstacle;

    // Start is called before the first frame update
    void Start()
    {
        controller1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<PlayerController>();
        controller2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<PlayerController>();

        power = GameObject.FindGameObjectWithTag("Suply").GetComponent<PowerUpController>();
        obstacle = GameObject.FindGameObjectWithTag("Obstacle").GetComponent<ObstacleController>();
        StartCoroutine(CountDownToStart());
    }

    IEnumerator CountDownToStart()
    {
        
        while (countdownTime > 0)
        {
            countdownText.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
            controller1.enabled = false;
            controller2.enabled = false;
            power.enabled = false;
            obstacle.enabled = false;

        }
        countdownText.text = "GO!!!";
        yield return new WaitForSeconds(1f);
        countdownText.gameObject.SetActive(false);
        controller1.enabled = true;
        controller2.enabled = true;
        power.enabled = true;
        obstacle.enabled = true;



    }
}
