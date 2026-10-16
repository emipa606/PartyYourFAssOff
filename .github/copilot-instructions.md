# Party Your F****** Ass Off (Continued) - GitHub Copilot Instructions

Welcome to the GitHub Copilot instructions file for the "Party Your F****** Ass Off (Continued)" mod, a RimWorld modification that breathes some much-needed party spirit into your colonies. Below you'll find a detailed overview of the mod’s purpose, key features, coding conventions, XML integrations, and use of Harmony patching. These guidelines aim to assist developers in effectively utilizing GitHub Copilot with this mod project.

## Mod Overview and Purpose

The "Party Your F****** Ass Off (Continued)" mod was initially developed by Captain Muscles (Nathan Harbour) and later continued by Khobs. This continuation further improves the mod functionality by removing its dependency on Harmony. The mod addresses the issue where colonists often neglect to engage in festivities by introducing a mechanism that allows players to force a party, regardless of environmental conditions or potential threats.

## Key Features and Systems

- **Force Party Mode**: Bypass traditional limitations like dangerous temperatures or nearby threats to initiate a party, ensuring colonists can celebrate whenever desired.
- **Interaction with Party Spots**: By selecting a colonist and right-clicking a designated party spot, players can initiate the party system.
  
## Coding Patterns and Conventions

- **C# Coding**:
  - Follow the C# naming conventions: PascalCase for types and methods; camelCase for local variables.
  - Clear, descriptive names for methods and variables.
- **Files and Structuring**: The primary C# script, `FloatMenuOptionProvider_Party_Your_Ass_Off.cs`, encapsulates the core logic for party initiation, handling party conditions and interactions.
- **Methods**:
  - ***Drafted*** and ***Undrafted***: Control states of colonists’ readiness.
  - ***GetSingleOptionFor***: Fetch the unique menu option related to starting a party.
  - ***Multiselect***: Handles multiple colonist selections for party initiation.
  - ***TryStartParty***: Attempts to initiate a party, checking necessary conditions.

## XML Integration

- **About.xml**: Provides metadata such as name, author, and package ID. It is critical for identifying the mod within RimWorld's mod manager.
- **Manifest.xml**: Contains core dependency information and mod integration details, although Harmony is not needed in the current iteration.

## Harmony Patching

While the current version of the mod removes the need for Harmony, previous iterations utilized it. Developers who wish to understand or re-introduce Harmony-based patches should familiarize themselves with standard Harmony annotations (`[HarmonyPatch]`) for method altering.

## Suggestions for Copilot

- **Generate Code Templates**: Use Copilot to generate code scaffolding for new features or interactions, such as additional party conditions or new menu options.
- **Improve Readability**: Ask Copilot to refactor code snippets for improved clarity and maintainability, focusing on descriptive method and variable names.
- **Create XML Snippets**: Utilize Copilot for suggesting XML template structures, particularly helpful for mod metadata or config files.
- **Alternative Logic Paths**: Experiment with Copilot for alternative logic sequences within `TryStartParty` to introduce new conditions or party mechanics.

Feel free to explore and expand the mod's capabilities using these guidelines with the assistance of GitHub Copilot, and contribute back your findings to the community via the repository.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

