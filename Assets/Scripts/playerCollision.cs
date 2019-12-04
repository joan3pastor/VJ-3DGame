using UnityEngine;

public class playerCollision : MonoBehaviour
{

    public GameObject collisionAnimPrefab;
    public bool invencible = false;

    private Transform t;
    private bool dead = false;
    private float deathTimer;


    // Start is called before the first frame update
    void Start()
    {
        t = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!dead) { 
            if (!invencible)
            {
                if (Input.GetKey(KeyCode.F1)) invencible = true;
                if (t.position.y < -2) {
                    kill();
                }
            }
            else if (Input.GetKey(KeyCode.F2)) invencible = false;
        }
    }

    void OnCollisionEnter(Collision c)
    {
        //Debug.Log(c.collider.name);
        if (!dead && !invencible)
        {
            if (c.collider.tag == "Enemy")
            {
                kill();
                Vector3 collisionPoint = c.GetContact(0).point;
                Instantiate(collisionAnimPrefab, collisionPoint, Quaternion.identity);
                FindObjectOfType<AudioManager>().Play("collision");
            }
        }
    }


    void kill() 
    {
        playerMovement.instance.dead = true;
        deathTimer = Time.time;
        dead = true;
    }
}
