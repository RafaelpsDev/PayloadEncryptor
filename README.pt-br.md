# 🔐 PayloadEncryptor

O **PayloadEncryptor** é uma aplicação de console em .NET 8 para criptografar payloads JSON utilizando criptografia híbrida (RSA + AES). O fluxo é interativo, guiando o usuário pelo fornecimento das chaves, descriptografia da chave de sessão e criptografia dos dados.

---

## 🛠️ Funcionalidades

- 🔑 **Criptografia Híbrida:** RSA para troca de chaves e AES para criptografia dos dados.
- 💬 **Interface Interativa:** Prompts no console para inserção de chaves e JSON.
- 📦 **Saída em Base64:** O payload criptografado é exibido em Base64.
- 🧩 **Mensagens Centralizadas:** Todas as mensagens de interface estão centralizadas em `ConsoleMessages` para fácil manutenção e padronização.
- 🏗️ **Orquestração Separada:** O fluxo de leitura e criptografia do JSON é orquestrado pela classe `UserJsonEncryptor`, promovendo separação de responsabilidades.

---

## 🚀 Como começar

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Chave privada RSA válida (Base64, PEM)
- Chave de sessão AES criptografada (Base64)

### Build do Projeto


---

## ⚙️ Como funciona

1. **Entrada das chaves:** O usuário fornece a chave privada RSA e a chave de sessão criptografada.
2. **Decodificação:** A chave privada é decodificada e carregada em um objeto RSA.
3. **Descriptografia da chave de sessão:** A chave AES é recuperada usando a chave RSA.
4. **Criptografia do payload:** O JSON fornecido é criptografado com a chave AES.
5. **Saída:** O payload criptografado é exibido em Base64.
6. **Mensagens:** Todas as mensagens exibidas ao usuário são centralizadas em `ConsoleMessages`.

---

## 📦 Dependências

- `System.Security.Cryptography` (biblioteca padrão do .NET)
- `Microsoft.Extensions.DependencyInjection` (injeção de dependência)
- Não há dependências externas obrigatórias.

---




# PayloadEncryptor

![.NET 8](https://img.shields.io/badge/.NET-8.0-blue)
![C# 12](https://img.shields.io/badge/C%23-12.0-blue)

## 📦 Sobre o Projeto

**PayloadEncryptor** é um utilitário de linha de comando desenvolvido em C# (.NET 8) para criptografar payloads JSON utilizando criptografia híbrida (RSA + AES). O usuário fornece uma chave privada local (em Base64), uma chave de sessão criptografada (em Base64) e um JSON de entrada. O programa descriptografa a chave de sessão usando a chave privada, e então utiliza essa chave para criptografar o JSON com AES/CBC/PKCS7.

---

## 🚀 Funcionalidades

- Leitura interativa de chaves e JSON via console.
- Decodificação de chave privada PEM (Base64).
- Descriptografia de chave de sessão (AES) usando RSA.
- Criptografia de payload JSON com AES/CBC/PKCS7 e IV zerado.
- Exibição do resultado criptografado em Base64.
- Permite processar múltiplos JSONs sem reinserir as chaves.

---

## 🏗️ Estrutura do Projeto


```csharp
PayloadEncryptor/  
├── PayloadEncryptor.App/            # Console application (entry point)
├── PayloadEncryptor.Application/    # Application services (orchestration)
├── PayloadEncryptor.Domain/         # Domain interfaces and utilities
├── PayloadEncryptor.Infrastructure/ # Infrastructure services (e.g., console reading)
├── PayloadEncryptor.sln             # .NET solution
```

---

## ⚙️ Requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Console compatível com UTF-8 (para melhor visualização dos títulos)

---

## 💻 Como Usar

1. **Ao iniciar, o programa exibirá um cabeçalho e solicitará:**
   - Chave privada local (Base64)
   - Chave de sessão criptografada (Base64)

2. **Depois, cole o JSON de entrada.**
   - Pressione Enter em uma linha vazia para finalizar a entrada do JSON.

3. **O payload criptografado será exibido em Base64.**

4. **Você pode escolher:**
   - `1` para adicionar um novo JSON (sem reinserir as chaves)
   - `2` para encerrar o programa

---

## 🧩 Principais Classes e Responsabilidades

- `EncryptionProcess`  
  Orquestra o fluxo principal.

- `DecodeService`  
  Decodifica a chave privada PEM a partir do Base64.

- `DecryptService`  
  Descriptografa a chave de sessão (AES) usando RSA.

- `EncryptService`  
  Criptografa o JSON com AES/CBC/PKCS7.

- `InputReader`  
  Responsável pela leitura do JSON do usuário via console.

- `ConsolePresentationHelper`  
  Utilitário para centralizar e formatar mensagens no console.

---

## 🔒 Segurança

- **Nunca compartilhe suas chaves privadas.**

---

## 📦 Dependências

- `System.Security.Cryptography` (biblioteca padrão do .NET)
- `Microsoft.Extensions.DependencyInjection` (injeção de dependência)
- Não há dependências externas obrigatórias.

---

## 📄 Licença

Este projeto está licenciado sob os termos da [MIT License](LICENSE).

---
