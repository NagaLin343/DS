using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private StoneSpawner m_stoneS;
    private float m_timer = 0f;
    [SerializeField]
    private float m_delay = 1f;
    [SerializeField]
    private Play player;
    private bool isDown = false;
    [SerializeField]
    private float m_power = 100f;

    private void Start()
    {
        StartGame();
    }
    private void StartGame()
    {
        Dead.onGameOver += OnGameOver; 
    }

    private void OnGameOver()
    {
        Dead.onGameOver -= OnGameOver;
    }
    private void Update()
    {
        m_timer += Time.deltaTime;
        if (m_timer >= m_delay)
        {
            m_stoneS.Spawn();
            m_timer -= m_delay;
        }
    }

    public void OnCollisionStone(Collision collision, Vector3 plowForwardVector)
    {
        // Понять, что это камень, можно через тег или через слой или через компонент
        if (collision.gameObject.TryGetComponent<Stone>(out var stone)) // Можно динамически создавать переменные
        {

            stone.SetAffect(false);
            var contact = collision.contacts[0]; // Лучше делать так, а не постоянно вызывать дальше
            Physics.IgnoreCollision(contact.thisCollider, contact.otherCollider, true);

            // А еще лучше сделать отдельный метод
            var body = contact.otherCollider.GetComponent<Rigidbody>();
            var m_impulseDirectionPositive = new Vector3(plowForwardVector.x, 1f, plowForwardVector.z);
            var m_impulseDirectionNegative = new Vector3(-plowForwardVector.x, 1f, -plowForwardVector.z);
            Debug.Log($"{contact.normal.x} {contact.normal.y} {contact.normal.z}");
            body.AddForce((isDown ? m_impulseDirectionNegative : m_impulseDirectionPositive) * m_power, ForceMode.Impulse);
            foreach (var item in collision.contacts)
            {
                Debug.DrawRay(item.point, item.normal * 100, Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f), 10f);
            }
        }
    }

    public void ChangePowlState()
    {
        isDown = !isDown;
        player.setIsDown(isDown);
    }

    private void OnDestroy()
    {
        Dead.onGameOver -= OnGameOver;
    }
    
}
