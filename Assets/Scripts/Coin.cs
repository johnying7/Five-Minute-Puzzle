using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed = 2.0f;
    private float secondsPerMinute = 60.0f;

    // Start is called before the first frame update
    void Start() {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collider.gameObject.tag == "Player")
        {
            GameObject.FindWithTag("CoinManager").GetComponent<CoinManager>().incrementCoinsCollected();
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    private void Update() {
        transform.Rotate(Vector3.right * (rotationSpeed * Time.deltaTime * secondsPerMinute));
    }
}
