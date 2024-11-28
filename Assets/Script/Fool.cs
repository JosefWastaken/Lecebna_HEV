using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Fool : MonoBehaviour
{
    [SerializeField]
    protected float speed;

    [SerializeField]
    protected int maxLives;
    private int lives;
    public int Score;

    protected virtual void Start()
    {
        lives = maxLives;
    }

    public virtual void Hit()
    {
        RemoveLife();
    }

    private void RemoveLife()
    {
        lives--;
        if (lives <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
        ScoreCounting.Instance.Count();
    }

    void Update()
    {
        DoMovement();
    }

    protected virtual void DoMovement()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
