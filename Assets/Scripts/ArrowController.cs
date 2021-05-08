using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
  private GameDirector director;
  private GameObject player;
  [SerializeField] float speed = -0.1f;

  private void Start()
  {
    player = GameObject.Find("player");
    director = GameObject.Find("GameDirector").GetComponent<GameDirector>();
  }

  private void Update()
  {
    transform.Translate(0, speed, 0);

    if (transform.position.y < -5.0f)
    {
      Destroy(gameObject);
    }

    Vector2 p1 = transform.position;
    Vector2 p2 = player.transform.position;
    Vector2 dir = p1 - p2;

    float d = dir.magnitude;
    float r1 = 0.5f;
    float r2 = 1.0f;

    if (d < r1 + r2)
    {
      director.DecreaseHp();
      Destroy(gameObject);
    }
  }
}
