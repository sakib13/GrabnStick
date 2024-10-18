using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] private Rigidbody rb;       
    [SerializeField] private float rollSpeed;
    [SerializeField] private Transform cameraTransform;
    public ScoreManager scoreManager;
    public ParticleSystem hittingparticle;

    
    public AudioSource impactSound;
    private float size = 1;
    void Start()
    {
        
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
       

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        Vector3 movement = (input.z * cameraTransform.forward) + (input.x * cameraTransform.right);
        rb.AddForce(movement * rollSpeed * Time.fixedDeltaTime * size);
    }
    void OnCollisionEnter(Collision collision)
    {

       
        
            if (collision.gameObject.CompareTag("Prop") && collision.transform.localScale.magnitude <= size)
            {
                hittingparticle.Play();
                collision.transform.parent = transform;
                size += collision.transform.localScale.magnitude;
                
                scoreManager.AddPoint();
                impactSound.Play();
            }
        
    }
}
