using UnityEngine;

public class ScriptWalk : MonoBehaviour
{

    [SerializeField] private float horizontalSpeed;
    [SerializeField] private float forwardSpeed;


    // Update is called once per frame
    void Update()
    {
  
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * forwardSpeed * Time.deltaTime);
        }
         if (Input.GetKey(KeyCode.D))
         {
            transform.Translate(Vector3.right * forwardSpeed * Time.deltaTime);

         }
         if (Input.GetKey(KeyCode.W))
         {
            transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

         }
         if (Input.GetKey(KeyCode.S))
         {
            transform.Translate(Vector3.back * forwardSpeed * Time.deltaTime);

         }
        // YOOOOOOOOOOOOOO IM COMMUNICATING THRU GITHUB!!!!!
    }
}
