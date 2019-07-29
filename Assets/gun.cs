using UnityEngine;

public class gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;

    public GameObject player;

    public gun myGun;

    private void Update()
    {

        if (Input.GetButtonDown("Jump"))
        {
            Shoot();
            myGun.enabled = false;
        }
    
    void Shoot()
        {
            RaycastHit hit;
            if (Physics.Raycast(player.transform.position, player.transform.forward, out hit))
            {
                Debug.Log(hit.transform.name);

                Target target = hit.transform.GetComponent<Target>();
                if (target != null)
                {
                    target.TakeDamage(damage);
                }
            }
        }

    }

}
