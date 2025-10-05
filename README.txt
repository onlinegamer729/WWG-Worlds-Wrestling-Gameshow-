WWG_Complete_UnityProject
-------------------------
Unity Version: 2022.3.10f1 (recommended)
Includes scenes, scripts, and basic ProjectSettings for Windows (StandaloneWindows64) and Android targets.

How to use:
1. Unzip the archive into your Unity Projects folder or open Unity Hub and add the folder as a project.
2. In Unity, open 'Assets/Scenes/MainMenu.unity' and 'Assets/Scenes/ArenaScene.unity'.
3. Install Universal Render Pipeline (Window -> Package Manager -> Universal RP) and assign a URP Pipeline Asset if not already set.
4. In Build Settings (File -> Build Settings) add both scenes and choose target platform (Windows / Android), then build.
5. If you use CI, there's a placeholder build script at Assets/Scripts/ci/BuildScript.cs.

Notes:
- Some scene components are placeholders. Open the ArenaScene and assign the Player prefab or GameObject to the CameraFollow and EnemyController references.
- For Android builds: set PlayerSettings -> Package name and configure keystore if needed.
