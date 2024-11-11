using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    private Rigidbody2D body;
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)){
            body.MovePosition(
                new Vector2(
                    body.position.x,
                    (float)(body.position.y + (
                        (Input.GetKey(KeyCode.W) ? 0.1 : 0.0) - (Input.GetKey(KeyCode.S) ? 0.1 : 0.0 ) 
                    ))
                )
            );
        }
    }

}
