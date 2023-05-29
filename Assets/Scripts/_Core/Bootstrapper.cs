using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField]
    private GameInstaller _gameInstaller;

    [SerializeField]
    private GameStarter _gameStarter;

    private void Awake()
    {
        _gameStarter.Initialize();
        DIContainer diContainer = new DIContainer();
        InitializableService initializableService = new InitializableService();

        _gameInstaller.Initialize(diContainer, initializableService, _gameStarter);
        _gameInstaller.InstallBinding();
        
        diContainer.InjectAll();
        initializableService.InitializeAll();
        
        _gameStarter.StartGame();
    }
}
