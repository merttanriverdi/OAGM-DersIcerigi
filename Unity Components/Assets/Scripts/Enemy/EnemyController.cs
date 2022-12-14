using Managers;
using TMPro;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int health;
    public TextMeshProUGUI healthText;

    public EnemyType myType;
    
    private void Start()
    {
        healthText.text = health.ToString();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        healthText.text = health.ToString();

        if (health <= 0)
        {
            Debug.Log(name + " - health: " + health);
            
            EventManager.OnEnemyDeadAction?.Invoke(myType);
            
            Destroy(gameObject);
        }
    }
}