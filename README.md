# TS4 SimRipper Classic

A tool for extracting Sims from The Sims 4 savegames for use in 3D modeling applications.

## ✨ Features

- Extract complete Sims (mesh, textures, rig) from savegame files
- Support for all ages, species, and occult types
- Export to OBJ, MS3D, and DAE formats
- Preview Sims directly in the application

## 📋 Requirements

- [Microsoft .NET Desktop Runtime 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) or later
- The Sims 4 game installation (for game assets)

## 🎮 Game Compatibility

| Game Version | SimRipper Version | Status |
|-------------|-------------------|--------|
| 1.121.342.1030 (Feb 2026) | 3.14.2.11+ | ✅ Working |
| 1.120.x and earlier | 3.14.2.10 | ✅ Working |

## 📥 Download

Download the latest release from [Releases](https://github.com/victorzambelli/TS4SimRipper/releases).

## 🔧 Building from Source

### Prerequisites
- Visual Studio 2022 or later
- .NET Framework 4.8 SDK
- .NET 6.0 SDK (for .NET Core build)

### Build Commands

**For .NET Framework build:**
```bash
dotnet build src/TS4SimRipper.csproj -c Release
```

**For .NET Core build:**
```bash
dotnet build src/TS4SimRipper.NET.csproj -c Release
```

The output will be in `src/bin/Release/`.

## 📖 Usage

1. Launch TS4SimRipper
2. Go to **Setup** menu and configure your game installation path
3. Click **Select** to choose a savegame file (`.save`)
4. Select a Sim from the list
5. Use the export options on the right panel

## 🐛 Troubleshooting

### Sims appear invisible or without head
This usually happens after a game update that changes the CASP format. Check if there's a new version of SimRipper available.

### Build errors with S4PI libraries
Make sure the `s4pe` folder is present in your project root and contains:
- `s4pi.Interfaces.dll`
- `s4pi.Package.dll`
- `s4pi.WrapperDealer.dll`

## 📝 Support

- **Instructions:** [ModTheSims page](https://modthesims.info/d/635720)
- **Bug reports:** [GitHub Issues](https://github.com/victorzambelli/TS4SimRipper/issues)

## 📄 License

This project is licensed under the GPL-3.0 License - see the [LICENSE](LICENSE) file for details.

## 🙏 Credits

- Original author: CmarNYC
- S4PI libraries by the s4pe team
