using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    private Rigidbody2D body;
    public Rigidbody2D puck;
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (body.position.y < puck.position.y - 0.1){
            body.MovePosition(new Vector2(body.position.x, (float)(body.position.y + 0.1)));
        }
        else if (body.position.y > puck.position.y + 0.1){
            body.MovePosition(new Vector2(body.position.x, (float)(body.position.y - 0.1)));
        }

        if ( Input.GetKey(KeyCode.Keypad8) || Input.GetKey(KeyCode.Keypad5)){
            body.MovePosition(
                new Vector2(
                    body.position.x,
                    (float)(body.position.y + (
                        (Input.GetKey(KeyCode.Keypad8) ? 0.1 : 0.0) - (Input.GetKey(KeyCode.Keypad5) ? 0.1 : 0.0 ) 
                    ))
                )
            );
        }
    }

}
