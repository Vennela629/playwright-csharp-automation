# playwright-csharp-automation
Playwright automation framework using C# and NUnit, demonstrating Page Object Model and best practices.
# Playwright NUnit Automation (C#)

This repository demonstrates a clean and minimal Playwright automation framework using C# and NUnit.

## Tech Stack
- Playwright for .NET
- NUnit
- Page Object Model (POM)
- .NET 8

## Project Structure
- **Base** – Test base class using Playwright PageTest
- **Pages** – Page Object classes
- **Tests** – NUnit test cases

## Sample Scenario
- Navigate to a public website
- Capture page title and current URL
- Validate successful navigation

## Purpose
This project is intended to showcase automation framework design and Playwright usage.
It does not contain any proprietary or enterprise code.

## How to Run
```bash
dotnet restore
dotnet test
