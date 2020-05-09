using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class HealthSystem : MonoBehaviour
{
    [FormerlySerializedAs("health")]
    public float maxHealth;
    public GameObject healthBarPrefab;

    HealthBar myHealthBar;
    float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        //Create our health panel on the canvas (References.canvas)
        GameObject healthBarObject = Instantiate(healthBarPrefab, References.canvas.transform);
        myHealthBar = healthBarObject.GetComponent<HealthBar>();
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        if(myHealthBar != null)
        {
            Destroy(myHealthBar.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Make our health bar reflect our health - myHealthBar.ShowHealthFraction()
        myHealthBar.ShowHealthFraction(currentHealth / maxHealth);

        //Make our health bar follow us - move it to our current position
        myHealthBar.transform.position = Camera.main.WorldToScreenPoint(transform.position + Vector3.up * 2);
    }
}
