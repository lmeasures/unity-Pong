using UnityEngine;

public class PuckController : MonoBehaviour
{
    public double speedMultiplier = 1.01;
    public AudioSource audio;
    private Rigidbody2D body;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
        body.linearVelocityX = 10;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Wall"){
            audio.Play();
            body.linearVelocityY = body.linearVelocityY * -1;
        } else if (other.gameObject.tag == "Player"){
            audio.Play();
            body.linearVelocityX = (body.linearVelocityX * -1) * (float)(speedMultiplier);
            body.AddForceY((body.position.y - other.gameObject.GetComponent<Rigidbody2D>().position.y)*200);
        }
        else {
            body.MovePosition(new Vector2(0,0));
            body.linearVelocityX = 10;
            body.linearVelocityY = 0;
            // set direction to opposite of point loser
            // reset speed to default
        }
    }
}
