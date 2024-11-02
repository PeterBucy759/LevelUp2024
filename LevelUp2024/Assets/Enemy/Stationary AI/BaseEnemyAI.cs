using UnityEngine;

public enum TypeOfAI
{
    StationaryAI,
    ChasingAI,
    NonChasingAI,
    TeleportingAI,
    RangedAI,
    CowardAI

}

public abstract class BaseEnemyAI : MonoBehaviour
{
    public TypeOfAI TypeOfAI; // we can select what type of AI we want the enemy to be
    public Transform player;
    public float health;
    public float lineOfSight; // from how far the AI will detect the player
    protected float distanceFromPlayer; //calculates the distance b/w player and AI

    protected Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    protected virtual void Update()
    {
        PlayerDetection();
    }

    public abstract void PlayerDetection();

}

