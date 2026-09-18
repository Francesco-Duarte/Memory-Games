# Memory Games (Color Sequence Game)

A Windows desktop app with three memory mini-games, built in C# with Windows Forms on .NET 10.

## Games

- **Color Sequence** — Watch a randomly generated sequence of 5 colors flash one at a time, then two players take turns recalling and re-selecting the sequence from a color palette.
- **Follow the Leader** — A random pattern of button positions (from a 3×3 grid) lights up in order. Both players then try to repeat the sequence by clicking the buttons in the same order.
- **Pattern Match** — A random subset of cells in a 4×4 grid is highlighted for a few seconds. Both players then try to pick out exactly the same cells from a 4×4 button grid.

After each round, both players' results are compared and a message box announces who won.

## How it works

1. **Main** — A maximized MDI hub with three buttons, one per game, each opening its own window.
2. Each game form generates a random pattern/sequence, displays it briefly, then opens a `Guesser` or `Guess` dialog for each of the two players in turn and reports the final outcome.


## Project structure

```
Color Sequence Game/
├── Color Sequence Game.slnx        # Solution file
└── Color Sequence Game/
    ├── Memory Games.csproj         # Project file (net10.0-windows, WinForms)
    ├── Program.cs                  # Entry point — launches Login
    ├── Main.cs                     # Game selection hub (MDI container)
    ├── Color_Sequence.cs           # "Color Sequence" game logic
    ├── FollowLeader.cs             # "Follow the Leader" game logic
    ├── PatternMatch.cs             # "Pattern Match" game logic
    ├── Guesser.cs                  # Shared player-guess dialog (Color Sequence & Follow the Leader)
    ├── Guess.cs                    # Player-guess dialog for Pattern Match
    └── Properties/                 # Assembly resources
```

## Requirements

- Windows (Windows Forms only runs on Windows)
- [.NET 10 SDK](https://dotnet.microsoft.com/download) or later
- Visual Studio 2022+ (recommended) or the `dotnet` CLI

## Running the project

**Visual Studio**
1. Open `Color Sequence Game.slnx`.
2. Set `Color Sequence Game` as the startup project (if prompted).
3. Press F5 to build and run.

**Command line**
```bash
cd "Color Sequence Game"
dotnet run
```

## Notes

- Namespaces are split across `Memory_Games` and `Color_Sequence_Game` — this is a holdover from how the project was renamed/restructured and doesn't affect functionality.
- No persistence or save system — scores and results only last for the current session/round.
- No unit tests are currently included.

## Possible improvements

- Add difficulty levels (longer sequences, shorter reveal times).
- Track scores/streaks across rounds instead of a single pass/fail per round.
- Add sound effects and smoother animations for pattern reveals.
