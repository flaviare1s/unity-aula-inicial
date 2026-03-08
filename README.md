# Estudos Unity - Bootcamp de Desenvolvimento de Games da SoulCode Academy

![Status do Projeto](https://img.shields.io/badge/Status-Em_Desenvolvimento-blue?style=for-the-badge&logo=unity)
![Licença](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)

Um projeto base desenvolvido em Unity para o estudo de conceitos fundamentais de desenvolvimento de jogos 2D, com foco em manipulação de **Sprite Sheets**, **Tilemaps** e estruturação de ambientes urbanos.

## 🚀 Sobre o Projeto

Este repositório contém a estrutura inicial e os assets necessários para criar o protótipo de uma cidade utilizando o motor de jogo **Unity**. O projeto utiliza assets otimizados de Tileset para permitir a construção rápida de cenários dinâmicos e grid-based.

### Diferenciais:
- Estrutura de pastas organizada para escalabilidade.
- Tileset pré-configurado com centenas de assets individuais.
- Configurações do VS Code inclusas para automação de debug em C#.

## 🛠️ Tecnologias e Ferramentas

*   [<img src="https://img.shields.io/badge/Unity-2022.3+-black?logo=unity&logoColor=white" />](https://unity.com/) - Engine de Desenvolvimento.
*   [<img src="https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white" />](https://learn.microsoft.com/en-us/dotnet/csharp/) - Linguagem de Scripting.
*   [<img src="https://img.shields.io/badge/VS_Code-007ACC?logo=visual-studio-code&logoColor=white" />](https://code.visualstudio.com/) - Editor de Código.

## 📂 Estrutura de Arquivos Principais

```bash
├── Assets/
│   └── 2dObjects/
│       └── Tiles/
│           ├── CP_V1.0.4.png       # Sprite Sheet principal da cidade
│           └── cityTiles/          # Assets de Tile individuais (.asset)
├── .vscode/                        # Configurações de Debug e Extensões
└── .gitignore                      # Filtro de arquivos temporários do Unity
```

## ⚙️ Guia de Instalação

1.  **Clone o repositório:**
    ```bash
    git clone https://github.com/flaviare1s/unity-aula-inicial.git
    ```
2.  **Abra o Unity Hub.**
3.  Clique em **Add** e selecione a pasta do projeto clonado.
4.  Certifique-se de estar utilizando a versão recomendada do Unity (2022.3 ou superior) para evitar conflitos de metadados.

## 🎮 Como Usar

1.  **Tileset:** No painel *Project*, navegue até `Assets/2dObjects/Tiles`.
2.  **Tile Palette:** Abra a janela de Tile Palette em `Window > 2D > Tile Palette`.
3.  **Pintura:** Arraste os assets da pasta `cityTiles` para a sua Palette e comece a desenhar o cenário na sua *Grid*.
4.  **Desenvolvimento:** Caso precise criar scripts, abra a pasta no VS Code para aproveitar as configurações de `launch.json` já inclusas.

## 🎨 Créditos de Assets

Os recursos visuais contidos em `Assets/2dObjects/Tiles/` fazem parte do pacote **CP_V1.0.4**, focado em arte urbana 2D de alta densidade.

---
*Desenvolvido durante as aulas do Bootcamp de Desenvolvimento de jogos da SoulCode Academy!*