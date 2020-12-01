using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMetalSlug : MonoBehaviour
{
    public List<ItemTypes> currentItems;

    // Start is called before the first frame update
    void Start()
    {
        InitializeAttributes();
    }

    void InitializeAttributes()
    {
        GetComponent<BulletsAttribute>().InitializeAttribute(20);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Item"))
        {
            currentItems.Add(collision.GetComponent<ItemBase>().itemType);
            Destroy(collision.gameObject);
        }
    }

    void Jump()
    {
        if(currentItems.Contains(ItemTypes.Jump)==true)
        {

            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 5, ForceMode2D.Impulse);

        }

    }

    void Shoot()
    {
        /*
       GameObject bullet=  PlayerBulletPool.Instance.GetPooledObject(transform.position);

       
        bullet.GetComponent<Projectilecomponent>().LaunchProjectile(transform.right);
        */
        GetComponent<BulletsAttribute>().SubtractToValue(1);

    }
    void Update()
    {
        if(Input.GetButtonDown("Jump")==true)
        {
            Jump();
        }

        if(Input.GetButtonDown("Fire1")==true)
        {
            Shoot();
        }
    }
   
}
