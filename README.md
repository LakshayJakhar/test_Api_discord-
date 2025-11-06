# DiscordWebhookApp – C# Console Application

**One-liner:**  
A simple C# console application to send messages and images to a Discord channel using Discord Webhooks.

---

## Table of Contents
1. Project Overview
2. Features
3. Technologies Used
4. Setup & Installation
5. Usage
6. Project Rating & Feedback
7. Contributing
8. License

---

## Project Overview
DiscordWebhookApp is a **C# console application** that allows users to send text messages and images to a Discord channel via **webhooks**.  

This project demonstrates **HTTP requests, multipart form data handling, JSON serialization, and basic C# file I/O** — making it a good small project for showcasing API integration.

---

## Features
- Send text messages to a Discord channel  
- Send images along with messages  
- Handles HTTP requests asynchronously  
- Simple and lightweight console application  

---

## Technologies Used
- **C#**  
- **.NET Console Application**  
- **HttpClient** (for HTTP requests)  
- **Newtonsoft.Json** (for JSON content)  

---

## Setup & Installation

# Clone the repository
git clone YOUR_REPO_URL
cd DiscordWebhookApp
Open the solution in Visual Studio 2019/2022 or newer.

Install NuGet package: Newtonsoft.Json.

Configure your Discord webhook URL in Program.cs:

string url = "YOUR_DISCORD_WEBHOOK_URL";


Optionally, set the path to your image:

string imagePath = "PATH_TO_YOUR_IMAGE_FILE";


Build and run the project:

Use Visual Studio or your preferred IDE.

The console will send the message (and image if provided) to your Discord channel.

Usage
1. Configure your webhook URL and image path.
2. Run the console application.
3. Check your Discord channel for the sent message and image.
