# XRDeviceSimulatorInstantiator

## Описание

XRDeviceSimulatorInstantiator - это компонент Unity, который автоматизирует процесс создания XRDeviceSimulator в Unity Editor. Он особенно полезен для разработчиков AR/VR приложений, которым нужна возможность быстро тестировать устройство без физического оборудования.

### Основные функции:

- Автоматическое создание XRDeviceSimulator при запуске сцены
- Упрощение процесса настройки симулятора устройств
- Поддержка Unity Editor

### Как использовать

1. Удалите существующий XRDeviceSimulator из вашей сцены или отключите его в Project Settings.

2. Создайте пустой игровой объект в вашей сцене (если его еще нет) и прикрепите XRDeviceSimulatorInstantiator к нему.

3. Откройте Inspector для XRDeviceSimulatorInstantiator.

4. Найдите поле "XRDeviceSimulator Prefab" и нажмите на него, чтобы открыть выпадающее меню.

5. Выберите XRDeviceSimulator из списка доступных префабов.

6. Запустите сцену. XRDeviceSimulator должен автоматически появиться в вашей сцене.

### Код компонента

```csharp
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;

public class XRDeviceSimulatorInstantiator : MonoBehaviour
{
#if UNITY_EDITOR
    [SerializeField] private XRDeviceSimulator deviceSimulatorPrefab;
    private void Awake() => DontDestroyOnLoad(Instantiate(deviceSimulatorPrefab.gameObject));
#endif
}
```

### Преимущества использования

- Ускоряет процесс разработки AR/VR приложений
- Обеспечивает консистентность тестирования на разных устройствах
- Упрощает отладку проблем, связанных с устройством

### Лицензия

Этот проект лицензирован под лицензией MIT. Полные детали лицензии можно найти в файле LICENSE.

### Контакты

Автор оригинальной идеи: Бородкин Макар (студент RTU TVP)

Дополнительная доработка: Шутов Кирилл (студент RTU TVP)

Если у вас есть вопросы или предложения по улучшению, пожалуйста, свяжитесь со мной по электронной почте: <i@shutovks.ru>.
