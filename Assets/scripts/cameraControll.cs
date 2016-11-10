using UnityEngine;
using System.Collections;

public class cameraControll : MonoBehaviour {

    private bool doMovement = true;
    public float panSpeed = 30f;

    public float scrollspeed = 5f;
    public float minY = 10f;
    public float maxY = 80f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            doMovement = !doMovement;
        }

        if (doMovement)
            return; 

        if (Input.GetKey("w") )
        {
            transform.Translate(Vector3.forward * Time.deltaTime * panSpeed, Space.World);
        }
        if (Input.GetKey("s") )
        {
            transform.Translate(Vector3.back * Time.deltaTime * panSpeed, Space.World);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * panSpeed, Space.World);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * panSpeed, Space.World);
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");

        Vector3 pos = transform.position;

        pos.y -= scroll * 1000 * scrollspeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);


        transform.position = pos;
    }
}
