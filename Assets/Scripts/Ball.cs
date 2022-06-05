using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    [SerializeField] private ParticleSystem _jumpEffect;
    [SerializeField] private ParticleSystem _deadEffect;
    [SerializeField] private GameObject _splashPrefab;
    [SerializeField] private GameObject _winPanel;
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private float _jumpForce;
    private GameManager _gameManager;
    private MeshRenderer _meshRenderer;
    private Rigidbody _ballRigidbody;

    void Start()
    {
        _ballRigidbody = GetComponent<Rigidbody>();
        _gameManager = GameObject.FindObjectOfType<GameManager>();
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {

        _ballRigidbody.velocity = Vector3.up * _jumpForce * 4 * Time.deltaTime;

        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log("Metaryal Adý: " + materialName);



        if (materialName == "Safe Color (Instance)")
        {
            GameObject splash = Instantiate(_splashPrefab, transform.position + new Vector3(0f, -0.1f, 0f), transform.rotation);
            splash.transform.SetParent(other.gameObject.transform);
            _jumpEffect.Play();
        }

        if (materialName == "Unsafe Color (Instance)")
        {
            _deadEffect.Play();
            _ballRigidbody.isKinematic = true;
            _losePanel.gameObject.SetActive(true);

        }
        if (materialName == "Last Ring (Instance)")
        {
            _deadEffect.Play();
            _ballRigidbody.isKinematic = true;
            _winPanel.gameObject.SetActive(true);

        }


    }
}