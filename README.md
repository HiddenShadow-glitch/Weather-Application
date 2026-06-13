# 🌤 Weather Application
> A Windows desktop weather app built with **C# Windows Forms** and the OpenWeatherMap API.

![Platform](https://img.shields.io/badge/platform-Windows-blue?logo=windows)
![Language](https://img.shields.io/badge/language-C%23-239120?logo=csharp)
![Framework](https://img.shields.io/badge/framework-.NET%206%2B-512BD4?logo=dotnet)
![License](https://img.shields.io/badge/license-MIT-green)

---

## 📋 Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Screenshots](#screenshots)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [How It Works](#how-it-works)
- [Configuration](#configuration)
- [Troubleshooting](#troubleshooting)
- [Contributing](#contributing)
- [License](#license)

---

## Overview

The Weather Application is a Windows desktop app built with **C# and Windows Forms**. It fetches real-time weather data from the [OpenWeatherMap API](https://openweathermap.org/api) and displays current conditions plus a 5-day forecast — all through a clean GUI built entirely with WinForms controls.

---

## Features

- 🔍 Search weather by city name
- 🌡️ Current temperature, humidity, wind speed, and conditions
- 📅 5-day weather forecast with daily high/low
- 🖼️ Dynamic weather icons based on current conditions
- 🔄 Toggle between **Celsius** and **Fahrenheit**
- ⚠️ Error handling for invalid city names or network failures

---

## Screenshots

> _Add your screenshots here._

```
📁 assets/
   screenshot-main.png
   screenshot-forecast.png
```

---

## Prerequisites

- [Visual Studio 2019 or later](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload
- .NET Framework 4.7.2+ **or** .NET 6 / .NET 8
- A free [OpenWeatherMap API key](https://openweathermap.org/appid)
- NuGet package: **Newtonsoft.Json**

---

## Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/your-username/weather-app-winforms.git
cd weather-app-winforms
```

### 2. Open in Visual Studio

Open `WeatherApp.sln`. NuGet packages will restore automatically on first build.

### 3. Add your API key

Open `ApiConfig.cs` and replace the placeholder:

```csharp
public static class ApiConfig
{
    public const string ApiKey  = "YOUR_API_KEY_HERE";
    public const string BaseUrl = "https://api.openweathermap.org/data/2.5/";
    public const string Units   = "metric"; // or "imperial"
}
```

### 4. Build and run

Press **F5** in Visual Studio, or via CLI:

```bash
dotnet run --project WeatherApp
```

---

## Project Structure

```
weather-app-winforms/
├── WeatherApp.sln
├── WeatherApp/
│   ├── Form1.cs                 # Main form — UI logic & event handlers
│   ├── Form1.Designer.cs        # Auto-generated WinForms designer code
│   ├── ApiConfig.cs             # API key and base URL
│   ├── WeatherService.cs        # HttpClient calls to OpenWeatherMap
│   ├── Models/
│   │   ├── CurrentWeather.cs    # POCO for current weather response
│   │   └── Forecast.cs          # POCO for 5-day forecast response
│   └── Resources/
│       └── icons/               # Weather condition icons
└── README.md
```

---

## How It Works

### Form Controls

| Control | Name | Purpose |
|---|---|---|
| `TextBox` | `txtCity` | User enters the city name |
| `Button` | `btnSearch` | Triggers weather fetch on `Click` |
| `Label` | `lblTemp`, `lblCondition`, etc. | Displays weather data |
| `PictureBox` | `picWeatherIcon` | Shows condition icon |
| `RadioButton` | `rbCelsius` / `rbFahrenheit` | Toggles temperature unit |
| `DataGridView` | `dgvForecast` | Renders the 5-day forecast |

### API Call Flow

```
User types city → btnSearch.Click
        ↓
WeatherService.GetCurrentWeatherAsync(city)
        ↓
HttpClient GET → api.openweathermap.org
        ↓
JSON response deserialized via Newtonsoft.Json
        ↓
Form1 updates Labels, PictureBox, DataGridView
        ↓
Error? → MessageBox shown to user
```

---

## Configuration

All settings live in `ApiConfig.cs`:

```csharp
public static class ApiConfig
{
    public const string ApiKey   = "your_key_here";
    public const string BaseUrl  = "https://api.openweathermap.org/data/2.5/";
    public const string Units    = "metric";   // "metric" | "imperial" | "standard"
    public const string Language = "en";
}
```

> 💡 For production use, consider moving the API key to `app.config` or environment variables to avoid committing secrets to source control.

---

## Troubleshooting

| Problem | Fix |
|---|---|
| **City not found** | Check spelling. The API requires standard English city names. |
| **No data shown** | Verify your API key is correct and activated (can take up to 10 min after signup). |
| **Build errors** | Right-click solution → *Restore NuGet Packages*, then rebuild. |
| **Icons not loading** | Ensure icons in `Resources/` are set to **Embedded Resource** in file properties. |
| **HTTP 401** | API key is invalid or inactive. Re-check at openweathermap.org. |
| **HTTP 429** | Free tier rate limit hit. Wait a minute and try again. |

---

## Contributing

Contributions are welcome!

1. Fork the repository
2. Create a feature branch: `git checkout -b feature/your-feature`
3. Commit your changes: `git commit -m "Add your feature"`
4. Push to the branch: `git push origin feature/your-feature`
5. Open a Pull Request

Please follow C# naming conventions and add XML doc comments to public methods.

---

## License

This project is licensed under the **MIT License** — see the [LICENSE](LICENSE) file for details.

---

<p align="center">Made with ❤️ using C# and Windows Forms &nbsp;•&nbsp; Powered by <a href="https://openweathermap.org">OpenWeatherMap</a></p>
