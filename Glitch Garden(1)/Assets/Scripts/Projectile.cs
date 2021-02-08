using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Range(0f, 10f)] [SerializeField] float currentSpeed = 10f;
    [SerializeField] float damage = 50f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * currentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D otheColider)
    {
        Health health = otheColider.GetComponent<Health>();
        var attacker = otheColider.GetComponent<Attacker>();

        if(attacker && health)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }
    }
}
