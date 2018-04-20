using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public Image currentHealthbar;
    public Text ratioText;

    public static float hitpoint = 150f;
    private float maxHitpoint = 150f;

	void Start () {
        UpdateHealthbar();
	}

    private void UpdateHealthbar()
    {
        float ratio = hitpoint / maxHitpoint;
        currentHealthbar.rectTransform.localScale = new Vector3(ratio,1, 1);
        ratioText.text = "Health: "  + (ratio*150).ToString("0");


    }
	
    private void TakeDamage(float damage)
    {
        hitpoint -= damage;
        if (hitpoint < 0)
        {
            hitpoint = 0;
            Debug.Log("Dead!");
        }

        UpdateHealthbar();
    }

    private void HealDamage(float heal)
    {
        hitpoint += heal;
        if (hitpoint > maxHitpoint)
            hitpoint = maxHitpoint;

        UpdateHealthbar();
    }
    
}
