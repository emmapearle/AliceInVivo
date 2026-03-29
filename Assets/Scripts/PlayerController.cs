using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{   
   [SerializeField] private Rigidbody rb;
   [SerializeField] private float speed = 3;

  // [SerializeField] private float rotationSpeed = 360;
    private Vector3 _Input;
    
   void GatherInput()
    {
        // float horizontal = 0;
        // float vertical = 0;
        
        // if (Keyboard.current.dKey.isPressed) horizontal = 1;
        // if (Keyboard.current.aKey.isPressed) horizontal = -1;
        // if (Keyboard.current.wKey.isPressed) vertical = 1;
        // if (Keyboard.current.sKey.isPressed) vertical = -1;
        
        _Input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    }

    void Move()
    {
        rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
    }

    // void Look()
    // {
    //     if (_Input != Vector3.zero){
    //         var matrix = Matrix4x4.Rotate(Quaternion.Euler(0,45,0));
    //         var rotatedInput = matrix.MultiplyPoint3x4(_Input);

    //         var relative = (transform.position + _Input) - transform.position;
    //         var rot = Quaternion.LookRotation(relative,Vector3.up);

    //         transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, rotationSpeed * Time.deltaTime);

    //     }

    // }
   
    void Start()
    {
       
    }

    void Update()
    {
        GatherInput();
      //  Look();
    }

    void FixedUpdate()
    {
        Move();
    }
}


