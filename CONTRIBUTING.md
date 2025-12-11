# Contributing to Kitchen Chaos

This project follows CodeMonkey's Kitchen Chaos tutorial. The development process follows the tutorial closely to ensure proper learning outcomes.

## Development Workflow

1. **Follow the Tutorial**: Each feature should align with the corresponding tutorial episode
2. **Code Organization**: Keep scripts organized in the Assets/Scripts folder
3. **Naming Conventions**: Use Unity's C# naming conventions:
   - Classes: PascalCase (e.g., `PlayerController`)
   - Methods: PascalCase (e.g., `HandleMovement()`)
   - Private fields: camelCase with prefix (e.g., `moveSpeed`)
   - Serialized fields: camelCase (e.g., `gameInput`)

## Project Structure

```
Assets/
├── Scripts/         # All C# scripts
│   ├── Player.cs
│   ├── GameInput.cs
│   └── ...
├── Scenes/          # Unity scenes
├── Prefabs/         # Reusable game objects
├── Materials/       # Materials and shaders
├── Textures/        # Textures and sprites
└── Audio/          # Sound effects and music
```

## Coding Standards

- Use XML documentation comments for public methods
- Keep methods focused and single-purpose
- Use Unity's serialization system for inspector configuration
- Follow SOLID principles where applicable
- Add comments for complex logic

## Learning Resources

- [CodeMonkey Kitchen Chaos Tutorial](https://www.youtube.com/watch?v=AmGSEH7QcDg)
- [Unity Documentation](https://docs.unity3d.com/)
- [C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/)

## Questions?

Refer back to the specific tutorial episode or Unity documentation for guidance.
