using UnityEngine;

public class PowerUpCollision : MonoBehaviour
{

    public ParticleSystem poof;

    private void OnCollisionEnter(Collision collisionInfo)
    {

        if(collisionInfo.collider.tag == "Player")
        {
            poof.Play();
            Destroy(gameObject);
        }

    }

}
