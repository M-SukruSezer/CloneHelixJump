using HelixJumpClone.ball;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform ball;

    [SerializeField] private ScoreManager _scoreManager;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y + 10.3f >= ball.position.y)
        {
            gameObject.SetActive(false);
            _scoreManager.GameScore(25);
        }
    }
}
