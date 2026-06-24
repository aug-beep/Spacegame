using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb2d;
    [SerializeField] private Vector2 _input;

    private void FixedUpdate()  
    {
        _rb2d.linearVelocity = _input;
        
    }
    void Update()
    {
        float verticalMovement = Input.GetAxis("Vertical");
        float horizontalMovement = Input.GetAxis("Horizontal");
        if (horizontalMovement != 0 && verticalMovement != 0) 
        {
            _input = new Vector2(2 * horizontalMovement / Mathf.Sqrt (2), 2 * verticalMovement / Mathf.Sqrt(2));
        }
        else
        {
            _input = new Vector2(2 * horizontalMovement, 2 * verticalMovement);
        }
    }
}