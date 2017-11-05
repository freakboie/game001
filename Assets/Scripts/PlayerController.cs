using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public Transform _transform;
    private float xposition;
    private float move=0;
    public float speed = 5f;
    public float yposition = 0;
    public float verticalspeed = 100f;
    public Vector3 newposition;

	// Use this for initialization
	void Start () {
        _transform = GetComponent<Transform>();
        //Debug.Log(_transform.position);
        newposition = new Vector3();
	}
	
	// Update is called once per frame
	void Update () {
        newposition = _transform.position;
        //Debug.Log(newposition);
        xposition = Input.GetAxis("Horizontal");
        move += xposition * speed * Time.deltaTime;
        newposition.x = move;
        if (Input.GetKeyDown(KeyCode.Space))
            yposition = 1;
        else
            yposition = 0;
        
        newposition.y += yposition * verticalspeed * Time.deltaTime;
        
        _transform.position = newposition;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
            Debug.Log("wall");
    }
}
