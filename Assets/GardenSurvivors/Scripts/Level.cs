using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections.Generic;

public class Level : MonoBehaviour
{
    [SerializeField] private float _mapHeight;
    [SerializeField] private float _mapWidth;
    [SerializeField] private UIManager _uiManager;
    [SerializeField] private string _levelName;
    private List<Enemy> _spawnedZombies = new List<Enemy>();
    public List<Enemy> SpawnedZombies => _spawnedZombies;
    public string LevelName => _levelName;
    public float MapHeight => _mapHeight;
    public float MapWidth => _mapWidth;

    [SerializeField] private int _currentScore = 0;

    public void UpdateScore(int enemyValue) {
        _currentScore += enemyValue;
        _uiManager.SetScore(_currentScore);
    }

    public void OnPlayerTakeDamage(float health) {
        _uiManager.UpdateHealth(health);
    }

    public void OnPlayerDead() {
        if (_currentScore > SaveState.GetHighScore()) {
            SaveState.SetHighScore(_currentScore);
        }
        Debug.Log($"High score is {SaveState.GetHighScore()}");
        _uiManager.ShowLoseScreen();
    }

    private void Awake() {
        _levelName = SceneManager.GetActiveScene().name;
        Game.SetLevel(this);
        _uiManager.SetScore(_currentScore);
    }

    public void AddEnemy(Enemy newEnemy) {
        _spawnedZombies.Add(newEnemy);
    }

    public void RemoveZombie(Enemy zombie) {
        _spawnedZombies.Remove(zombie);
    }
}
