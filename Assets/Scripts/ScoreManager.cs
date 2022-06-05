using UnityEngine;
using UnityEngine.UI;

namespace HelixJumpClone.ball
{
    public class ScoreManager : MonoBehaviour
    {
        // Start is called before the first frame update
        private int score;

        [SerializeField] private GameObject _sceneScoreText;

        public Text scoreText;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void GameScore(int ringScore)
        {
            score += ringScore;
            scoreText.text = score.ToString();

            if (scoreText.text == score.ToString())
            {
                _sceneScoreText.gameObject.SetActive(true);
            }
        }


    }

}