using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;

    public float directionSpeed;

    private bool isFinished;

    public float restartTimer;

    public TextMesh infoText;

    private bool winner;
    // Start is called before the first frame update
    void Start()
    {
        speed = 2f;
        directionSpeed=5f;
        restartTimer=4f;
        isFinished=false;
        infoText.text="Land on the Target";
    }

    // Update is called once per frame
    void Update()
    {

        if (!isFinished)
        {
            this.transform.position += transform.forward * speed * Time.deltaTime;

            if(Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A))
            {
                transform.position+=Vector3.left * directionSpeed * Time.deltaTime;
            }
            if(Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D))
            {
                transform.position+=Vector3.right * directionSpeed * Time.deltaTime;
            }
            if(Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.W))
            {
                transform.position+=Vector3.forward * directionSpeed * Time.deltaTime;
            }
            if(Input.GetKey(KeyCode.DownArrow)|| Input.GetKey(KeyCode.S))
            {
                transform.position+=Vector3.back * directionSpeed * Time.deltaTime;
            }

        }

        else
        {
            restartTimer -= Time.deltaTime;
            
            if(restartTimer<=0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else
            {
                if(winner)
                {
                    infoText.text="You have Won! \n Game restarts in "+restartTimer.ToString("n1");

                }

                else
                {
                    infoText.text="You have Lost! \n Game restarts in "+restartTimer.ToString("n1");

                }
            }

        }
        

    }

    void OnTriggerEnter (Collider otherCollider)
    {
        if (otherCollider.tag=="Target")
        {
            Debug.Log("You colliderd with the target.");
            winner=true;

        }

        else
        {
            Debug.Log("You hit something else");
            winner=false;
        }

        isFinished=true;

        
    }
}
