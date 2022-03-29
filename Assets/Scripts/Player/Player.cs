using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamageable
{
    [SerializeField] private float speed = 1f;
    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rig.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
        }
    }

    public void TakeDamage()
    {
        GameController.Instance.GameOver();
    }
}
