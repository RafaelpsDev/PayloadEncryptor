# 🔐 PayloadEncryptor

**PayloadEncryptor** is a .NET 8 console application for encrypting JSON payloads using hybrid encryption (RSA + AES). The flow is interactive, guiding the user through key input, session key decryption, and data encryption.

---

## 🛠️ Features

- 🔑 **Hybrid Encryption:** RSA for key exchange and AES for data encryption.
- 💬 **Interactive Interface:** Console prompts for key and JSON input.
- 📦 **Base64 Output:** The encrypted payload is displayed in Base64.
- 🧩 **Centralized Messages:** All interface messages are centralized in `ConsoleMessages` for easy maintenance and standardization.
- 🏗️ **Separated Orchestration:** The JSON reading and encryption flow is orchestrated by the `UserJsonEncryptor` class, promoting separation of concerns.

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Valid RSA private key (Base64, PEM)
- Encrypted AES session key (Base64)

### Project Build

---

## ⚙️ How It Works

1. **Key Input:** The user provides the RSA private key and the encrypted session key.
2. **Decoding:** The private key is decoded and loaded into an RSA object.
3. **Session Key Decryption:** The AES key is recovered using the RSA key.
4. **Payload Encryption:** The provided JSON is encrypted with the AES key.
5. **Output:** The encrypted payload is displayed in Base64.
6. **Messages:** All messages shown to the user are centralized in `ConsoleMessages`.

---

## 📦 Dependencies

- `System.Security.Cryptography` (standard .NET library)
- `Microsoft.Extensions.DependencyInjection` (dependency injection)
- No required external dependencies.

---

# PayloadEncryptor

![.NET 8](https://img.shields.io/badge/.NET-8.0-blue)
![C# 12](https://img.shields.io/badge/C%23-12.0-blue)

## 📦 About the Project

**PayloadEncryptor** is a command-line utility developed in C# (.NET 8) to encrypt JSON payloads using hybrid encryption (RSA + AES). The user provides a local private key (in Base64), an encrypted session key (in Base64), and an input JSON. The program decrypts the session key using the private key, then uses this key to encrypt the JSON with AES/CBC/PKCS7.

---

## 🚀 Features

- Interactive reading of keys and JSON via console.
- Decoding of PEM private key (Base64).
- Decryption of session key (AES) using RSA.
- Encryption of JSON payload with AES/CBC/PKCS7 and zeroed IV.
- Display of the encrypted result in Base64.
- Allows processing multiple JSONs without re-entering the keys.

---

## 🏗️ Project Structure

```csharp
PayloadEncryptor/  
├── PayloadEncryptor.App/            # Console application (entry point)  
├── PayloadEncryptor.Application/    # Application services (orchestration)  
├── PayloadEncryptor.Domain/         # Domain interfaces and utilities  
├── PayloadEncryptor.Infrastructure/ # Infrastructure services (e.g., console reading)  
├── PayloadEncryptor.sln             # .NET solution  
```

---

## ⚙️ Requirements

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- UTF-8 compatible console (for better title visualization)

---

## 💻 How to Use

1. **On startup, the program will display a header and prompt for:**
   - Local private key (Base64)
   - Encrypted session key (Base64)

2. **Then, paste the input JSON.**
   - Press Enter on an empty line to finish the JSON input.

3. **The encrypted payload will be displayed in Base64.**

4. **You can choose:**
   - `1` to add a new JSON (without re-entering the keys)
   - `2` to exit the program

---

## 🧩 Main Classes and Responsibilities

- `EncryptionProcess`  
  Orchestrates the main flow.

- `DecodeService`  
  Decodes the PEM private key from Base64.

- `DecryptService`  
  Decrypts the session key (AES) using RSA.

- `EncryptService`  
  Encrypts the JSON with AES/CBC/PKCS7.

- `InputReader`  
  Responsible for reading the user's JSON via console.

- `ConsolePresentationHelper`  
  Utility to centralize and format console messages.

---

## 🔒 Security

- **Never share your private keys.**

---

## 📦 Dependencies

- `System.Security.Cryptography` (standard .NET library)
- `Microsoft.Extensions.DependencyInjection` (dependency injection)
- No required external dependencies.

---

## 📄 License

This project is licensed under the terms of the [MIT License](LICENSE).

---