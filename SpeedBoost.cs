using UnityEngine;
using System.Collections;

public class SpeedBoost : MonoBehaviour {

    public GameObject boost;
    public GameObject player; //placeholdder, since PlayerScript seems to determine what the player is, can't reference player gameobject(I think)
    bool isboosting = false;
    [SerializeField]
    private float baseSpeed = 5;
    private float maxSpeed; // will possibly be used as a speed cap
    private float speedAddition;
    private float playerSpeed;


    public void gainSpeed()
    {
        if (isboosting)
            playerSpeed = baseSpeed + speedAddition;
        else
            playerSpeed = baseSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        speedAddition = 5; // example speed boost valaue
        isboosting = true;
        if (other.tag == "Booster")
        {
            playerSpeed = baseSpeed + speedAddition;
        }
    }
}

