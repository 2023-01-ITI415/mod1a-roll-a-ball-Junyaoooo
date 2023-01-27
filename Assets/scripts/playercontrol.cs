using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    public Text countText;
    public float speed;
    public Text winText;

    private Rigidbody rb;
    private int count;
    

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("pig");
        
        rb = GetComponent<Rigidbody>();
        count = 0;
        s();
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        float Xmove = Input.GetAxis("Horizontal");
        float Ymove = Input.GetAxis("Vertical");
        Vector3 movements = new Vector3(Xmove, 0.0f, Ymove);

        rb.AddForce(speed*movements);
    }
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            s();
            
        }
    }
    void s() 
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12) 
        {
            winText.text = "You Win";
        }
    }


}
