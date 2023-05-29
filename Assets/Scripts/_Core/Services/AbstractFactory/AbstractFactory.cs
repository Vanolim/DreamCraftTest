using UnityEngine;

public class AbstractFactory
{
    public T Create<T>(T prefab) where T : MonoBehaviour
    {
        T instance = Object.Instantiate(prefab);
        if (instance is IActivable activable)
            activable.Deactivate();

        return instance;
    }
    
    public T[] Create<T>(T[] prefabs) where T : MonoBehaviour
    {
        T[] instances = new T[prefabs.Length];
        
        for (int i = 0; i < prefabs.Length; i++)
        {
            T instance = Object.Instantiate(prefabs[i]);
            if (instance is IActivable activable)
                activable.Deactivate();

            instances[i] = instance;
        }

        return instances;
    }
}