# TextToFileConverter

A lightweight C# console application designed to convert text input into various file formats. This utility provides a simple and efficient way to transform text data into structured file outputs.

## 🚀 Features

- **Text to File Conversion**: Convert plain text or formatted text into file formats
- **Console-Based Interface**: Simple command-line interface for easy operation
- **Lightweight**: Minimal dependencies and fast execution
- **Cross-Platform**: Built with .NET, compatible with Windows, Linux, and macOS
- **Easy to Use**: Straightforward commands for quick conversions

## 🛠️ Technology Stack

- **Language**: C# (.NET)
- **Framework**: .NET Core / .NET 6+
- **IDE**: Visual Studio / Visual Studio Code

## 📋 Prerequisites

Before running this application, ensure you have the following installed:

- .NET SDK 6.0 or higher
- Visual Studio 2022 or later (optional, for development)
- Git (for cloning the repository)

## 🚀 Getting Started

### Installation

1. **Clone the repository**:
```bash
git clone https://github.com/tasnimjubaier/TextToFileConverter.git
cd TextToFileConverter
```

2. **Build the project**:
```bash
dotnet build
```

3. **Run the application**:
```bash
dotnet run
```

### Alternative: Using Visual Studio

1. Clone the repository
2. Open `TextToFileConverter.sln` in Visual Studio
3. Press `F5` or click "Start" to build and run the project

## 💻 Usage

### Basic Usage

```bash
dotnet run -- [options] [input]
```

### Example Commands

```bash
# Convert text to a file
dotnet run -- "Your text here"

# Specify output file name
dotnet run -- --output myfile.txt "Your text content"

# Process from input file
dotnet run -- --input input.txt --output output.txt
```

## 📁 Project Structure

```
TextToFileConverter/
├── .vs/                          # Visual Studio settings
├── Properties/
│   └── PublishProfiles/          # Publish configurations
├── obj/                          # Build artifacts
├── Program.cs                    # Main application entry point
├── TextToFileConverter.csproj    # Project configuration file
├── TextToFileConverter.sln       # Visual Studio solution file
├── .gitignore                    # Git ignore rules
└── README.md                     # Project documentation
```


## 📦 Building and Publishing

### Build for Release

```bash
dotnet build --configuration Release
```

### Publish as Self-Contained Executable

**Windows**:
```bash
dotnet publish -c Release -r win-x64 --self-contained
```

**Linux**:
```bash
dotnet publish -c Release -r linux-x64 --self-contained
```

**macOS**:
```bash
dotnet publish -c Release -r osx-x64 --self-contained
```

## 🧪 Testing

To run tests (if implemented):

```bash
dotnet test
```

## 📝 Development

### Prerequisites for Development

- Visual Studio 2022 or later
- .NET SDK 6.0+
- Git

## 📧 Contact

For questions, suggestions, or issues:
- Open an issue on [GitHub](https://github.com/tasnimjubaier/TextToFileConverter/issues)
- Contact the author through GitHub

---
