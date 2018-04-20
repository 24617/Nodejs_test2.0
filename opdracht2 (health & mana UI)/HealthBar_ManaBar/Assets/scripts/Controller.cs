using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public bool isDamaging;
    public float damage = 10;
    public bool isCasting;
    public float Manalose = 10;
    public bool isHealing;
    public float heal = 10;
    public bool isRegenerating;
    public float ManaRecieve = 10;
	

	void Update () {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SendMessage((isDamaging) ? "TakeDamage" : "HealDamage", damage);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SendMessage((isCasting) ? "LoseMana" : "RecieveMana", Manalose);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SendMessage((isHealing) ? "TakeDamage" : "HealDamage",  heal); 
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SendMessage((isRegenerating) ? "LoseMana" : "RecieveMana", ManaRecieve);
        }
    }
}
