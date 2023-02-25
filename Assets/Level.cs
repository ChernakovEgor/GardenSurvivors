using UnityEngine.SceneManagement;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private float _mapHeight;
    [SerializeField] private float _mapWidth;
    [SerializeField] private UIManager _uiManager;
    [SerializeField] private string _levelName;
    public string LevelName => _levelName;
    public float MapHeight => _mapHeight;
    public float MapWidth => _mapWidth;

    public void OnPlayerTakeDamage(float health) {
        _uiManager.UpdateHealth(health);
    }

    public void OnPlayerDead() {
        _uiManager.ShowLoseScreen();
    }

    private void Awake() {
        _levelName = SceneManager.GetActiveScene().name;
        Game.SetLevel(this);
    }
}
