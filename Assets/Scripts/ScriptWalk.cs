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
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * forwardSpeed * Time.deltaTime);

        }

    }
}
