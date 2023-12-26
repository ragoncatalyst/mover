using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

  }

  public float moveSpeed = 5f;

  // Update is called once per frame
  void Update()
  {
    // Get the horizontal input
    float horizontal = Input.GetAxis("Horizontal");

    // Move the sprite left and right
    transform.position += new Vector3(horizontal, 0f, 0f) * moveSpeed * Time.deltaTime;
  }
}
