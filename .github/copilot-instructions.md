# GitHub Copilot Instructions for "Party Your F****** Ass Off (Continued)"

## Mod Overview and Purpose
"Party Your F****** Ass Off (Continued)" is a RimWorld mod originally created by Captain Muscles and updated first by Khobs, with the current version continuing their work. The mod injects a lively spirit into the game by enabling colonists to initiate parties actively, regardless of conditions that would traditionally prevent such gatherings. This dynamic feature encourages players to embrace the social aspects of their colonies and handle the fun and chaos that ensue.

## Key Features and Systems
- **Party Initiation**: Allows players to manually start a party by selecting a colonist and right-clicking on a designated party spot. 
- **Override Conditions**: Parties can commence even under unfavorable conditions like bad temperature or imminent danger, adding both excitement and risk.
- **User Instructions**:
  1. Select a colonist in your game.
  2. Right-click a party spot to initiate the party.
  3. Enjoy the festivities or chaos that follows!

## Coding Patterns and Conventions
- **File Structure**: The mod source code is organized following typical C# conventions. Key files include `FloatMenuMakerMap_Patches.cs` and `PartyMod.cs`.
- **Class and Method Naming**: Descriptive names that follow C# naming conventions (PascalCase for classes and methods).
  
### XML Integration
- XML is commonly used in RimWorld modding for defining game data, such as item and job definitions.
- Ensure that your XML files (if used) are well-structured and properly referenced in your C# code. Though this mod centers around C#, familiarity with the XML structure RimWorld uses is helpful.

### Harmony Patching
- **Harmony** is used to patch the existing game behaviors non-destructively. In this mod, `FloatMenuMakerMap_Patches.cs` contains code for injecting custom party logic.
  - **Patch Structure**: Typical patches include prefix or postfix methods that are injected into existing game functions.
  - **Usage**: Ensure the proper use of attributes like `[HarmonyPatch]` to target specific methods requiring alteration or extension.

## Suggestions for Copilot
- **Class Creation**: Assist with generating classes and methods for new features while ensuring naming conventions align with RimWorld mod standards.
- **Harmony Patch Suggestions**: Provide templates for common Harmony patch scenarios, such as postfix and prefix patches useful in modifying game behavior.
- **XML Handling**: Offer suggestions on integrating and referencing XML data within C# code.
- **Error Handling and Logging**: Code suggestions for robust error handling to ensure any unexpected behavior is logged and easy to diagnose.

## Additional Resources
- Download the mod from GitHub using the provided link.
- For support and troubleshooting, use the Mod's Discord channel instead of creating discussion threads.
- When reporting issues, attach logs via the Log Uploader for detailed diagnostics.

Adopting these guidelines and utilizing GitHub Copilot can significantly streamline the development and maintenance of this RimWorld mod, enhancing the party experience for all players.
