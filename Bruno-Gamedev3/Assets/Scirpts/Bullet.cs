using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rig;
    public float speed = 50;
    public GameObject hitParticle;
    public GameObject destroyParticle;
    public float lifeTime = 5;

    private void Start()
    {
        rig.linearVelocity += transform.forward * speed;
        Invoke(nameof(AutoDestroy), lifeTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(hitParticle, transform.position, Quaternion.identity);
        }
        else if (other.CompareTag("Enemy"))
        {
            Instantiate(hitParticle, transform.position, Quaternion.identity);
        }


        AutoDestroy();
    }


    private void AutoDestroy()
    {
        Instantiate(destroyParticle, transform.position, Quaternion.identity);
        Destroy(gameObject);

    }

}
