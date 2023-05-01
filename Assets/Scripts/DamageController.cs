using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    [SerializeField] private int damage = 1;
    [SerializeField] private HealthController _healthController;
    [SerializeField] private Invulnerability _invulnerability;


    private void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HealthTrigger")) // Trzeba ustawi� tagi w Edytorze!!!
        {
            Damage();
            _invulnerability.SetInvulnerability();



        }
    }

    public void Damage()
    {
        _healthController.playerHealth = _healthController.playerHealth - damage;
        _healthController.UpdateHealth();


    }
}
