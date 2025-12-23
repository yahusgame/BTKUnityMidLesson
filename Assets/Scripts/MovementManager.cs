using UnityEngine;
using UnityEngine.InputSystem;

public class MovementManager : MonoBehaviour
{
    public float speed = 5f;
    //public Vector3 movement;
    //private Rigidbody rb;
    //public float force = 10f;
    //public Transform target;
    int counter = 0;
    public Transform[] targets;

    /*void Awake()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // transform.position = new Vector3(5f, transform.position.y, transform.position.z);
    }*/

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + new Vector3(1f * Time.deltaTime, 0f, 0f); // Move right at 1 unit per second
        //transform.position += new Vector3(1f, 0f, 0f) * Time.deltaTime; // Move right at 1 unit per second
        //transform.position += Vector3.right * speed * Time.deltaTime; // Move right at 'speed' units per second
        //transform.position += Vector3.left * speed * Time.deltaTime; // Move left at 'speed' units per second
        //transform.position += Vector3.up * speed * Time.deltaTime; // Move up at 'speed' units per second
        //transform.position += Vector3.forward * speed * Time.deltaTime; // Move forward at 'speed' units per second

        //transform.Translate(0.1f, 0, 0); // Move right at 0.1 units per frame
        //transform.Translate(movement * speed * Time.deltaTime); // Move based on 'movement' vector

        //rb.linearVelocity = movement * speed; // Move based on 'movement' vector using Rigidbody

        /*if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            //rb.AddForce(Vector3.up * force,ForceMode.Force); // F=m*a Newton 's Second Law always applies
            //rb.AddForce(Vector3.up * force, ForceMode.Impulse); // Apply instant force upwards. Impulse considers mass 
            //rb.AddForce(Vector3.up * force, ForceMode.VelocityChange); // Instantaneously change velocity upwards
            //rb.AddForce(Vector3.up * force, ForceMode.Acceleration); // free of mass acceleration using F= m*a

        }*/

        //Vector3.MoveTowards linearly interpolates between two points at a constant speed
        //transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if (counter < targets.Length)
        {
            transform.position = Vector3.MoveTowards(transform.position, targets[counter].position, speed * Time.deltaTime);
            if (transform.position == targets[counter].position)
            {
                counter++;
            }
        }

        //Vector3.Lerp linearly interpolates between two points based on a fraction (0 to 1)
        /*if (counter<targets.Length)
        {
            transform.position = Vector3.Lerp(transform.position, targets[counter].position, 0.01f);
            if (Vector3.Distance(transform.position, targets[counter].position) < 0.1f)
            {
                counter++;
            }
        }*/
    }
}
