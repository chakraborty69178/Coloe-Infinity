using UnityEngine;

public class Rotator : MonoBehaviour {

	public float speed = 100f;
    int[] speeds = { 130,-130};
    public bool BigCircle=false;
    public Transform cam;
    public float offset;
    public bool notRotating = false;
    public Rotator small;
    public GameObject colorChanger;
    private void Start()
    {
        speed = speeds[Random.Range(0, 2)];
        if (BigCircle)
        {
            if (small == null)
            {
                Debug.Log("Null in Small");
                //speed = small.speed * -1;
            }
            else {
                speed = (-small.speed);
            }
            
        }
    }
    void Update () {
        if(this.transform.position.y<(cam.transform.position.y+offset))
        {
            Spawner.currentYposition += Spawner.diffrence;
            Spawner.colorchangeYposition = Spawner.currentYposition + Spawner.diffrence/2;
            this.transform.position = new Vector2(this.transform.position.x, Spawner.currentYposition);
            if(colorChanger != null)
                Instantiate(colorChanger, new Vector2(0, Spawner.colorchangeYposition), Quaternion.identity);
        }
        if(!notRotating)
		transform.Rotate(0f, 0f, speed * Time.deltaTime);
	}
}
