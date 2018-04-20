using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Mana : MonoBehaviour {

    public Image currentManabar;
    public Text ratioText;

    public static float hitpoint = 100f;
    private float maxHitpoint = 100f;

    void Start()
    {
        UpdateManabar();  
    }

    private void UpdateManabar()
    {
        float ratio = hitpoint / maxHitpoint;
        currentManabar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        ratioText.text = "Mana: " + (ratio * 100).ToString("0");
    }

    private void LoseMana(float Manalose)
    {
        hitpoint -= Manalose;
        if (hitpoint < 0)
        {
            hitpoint = 0;
            Debug.Log("0 Mana");
        }

        UpdateManabar();
    }

    private void RecieveMana(float ManaRecieve)
    {
        hitpoint += ManaRecieve;
        if (hitpoint > maxHitpoint)
            hitpoint = maxHitpoint;

        UpdateManabar();
    }
}
