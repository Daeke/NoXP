using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{

    public float health;
    public GameObject healthBarPrefab;

    // Start is called before the first frame update
    void Start()
    {
        //Create our health panel on the canvas (References.canvas)
        Instantiate(healthBarPrefab, References.canvas.transform);
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;

        transform.localScale *= 0.5f;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
