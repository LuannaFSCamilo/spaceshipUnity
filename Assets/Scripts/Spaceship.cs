using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public Projectile projecttilePrefab;
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        ApplyMovement();
        FireProjectile();
    }

    void ApplyMovement()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        //if (Input.GetKeyUp(KeyCode.RightArrow))
        transform.Translate(Time.deltaTime * speed * new Vector3(horizontal, vertical));
    }

    void FireProjectile()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(projecttilePrefab, transform.position, Quaternion.identity);
        }
    }

}
