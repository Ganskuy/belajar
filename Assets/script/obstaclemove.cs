using UnityEngine;

public class obstaclemove : MonoBehaviour
{
    public float speed;
    private float leftEdge;

    private void Start(){
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }
    public void Update(){
        transform.position += Vector3.left * speed * Time.deltaTime;
        if(transform.position.x < leftEdge){
            Destroy(gameObject);
        }
    }
}
