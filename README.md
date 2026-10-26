# Data Storage And Retrieval

Unity project showing two ways to store data: a ScriptableObject and PlayerPrefs.

## Features

- **ScriptableObject**: `PlayerData_SO` stores `playerName` (string), `age` (int) and `height` (float).
- **Control script**: `PlayerDataDisplay` reads the SO asset and shows the values in a UI Text.
- **PlayerPrefs storage**: `PlayerPrefsDemo` saves and loads the same three types with `SetString`, `SetInt`, `SetFloat`, `GetString`, `GetInt` and `GetFloat`.
- **Live update**: the age is recalculated from October 4, 2001 every frame, so the seconds change.
- **UI**: `PrefsText` shows PlayerPrefs data; `PlayerDataText` shows ScriptableObject data.

## Quick Start

- Open the project in Unity.
- Open `Assets/Scenes/Linerenderer.unity`.
- Press **Play**.
- Watch the age seconds change in `PrefsText`.
- Stop and press **Play** again to see the PlayerPrefs values load.
- Change a value in `PlayerData_SO.asset`, then press **Play** to see `PlayerDataText` update.

## Structure

- `Assets/ScriptableObjects/PlayerData_SO.cs` : ScriptableObject
- `Assets/ScriptableObjects/PlayerData_SO.asset` : configured values
- `Assets/ScriptableObjects/PlayerDataDisplay.cs` : displays SO values
- `Assets/Scripts/PlayerPrefsDemo.cs` : saves, loads and displays PlayerPrefs values
- `Assets/Scenes/Linerenderer.unity` : scene with the Canvas

## Output

```
[PlayerPrefs]
Name: Chomba
Height: 170.18
Age: 25 years, 23 days, 4 hours, 12 minutes, 8 seconds

[ScriptableObject]
Name: Chomba
Age: 25
Height: 170.18
```