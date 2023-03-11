using UnityEngine.SceneManagement;

public static class Game 
{
    private static Level _level;
    public static Level GetLevel => _level;

    
    public static void SetLevel(Level newLevel) {
        if (_level == null) {
            _level = newLevel;
        }
        if (SceneManager.GetActiveScene().name != newLevel.LevelName) {
            _level = newLevel;
            SceneManager.LoadScene(_level.LevelName);
        }
    }

    public static void RestartLevel() {
        SceneManager.LoadScene(_level.LevelName);
    }
}
