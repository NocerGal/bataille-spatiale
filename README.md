# Bataille spatiale

Ce projet a pour but de simuler une bataille spatiale entre deux adversaires. Nous allons dans un premier temps expliquer comment cloner et lancer le projet, puis comment ajuster le projet à vos souhaits.

## Clonage

Dans votre terminal et après avoir choisi la localisation du fichier dans lequel vous souhaitez réaliser le téléchargement :

- `git clone https://github.com/NocerGal/bataille-test.git` ou `gh repo clone NocerGal/bataille-test`
- `cd bataille-spatiale`

## Utilisation du programme

- Tapez dans votre terminal `dotnet run [arg1] [arg2]`
- `[arg1]` et `[arg2]` doivent être des valeurs supérieures à 0 et représentent le nombre de soldats dans chaque équipe.
- La simulation de bataille se lance dans votre terminal.

## Modifier des paramètres du projet

Certaines constantes du projet peuvent être modifiées dans le fichier `Program.cs` pour ajuster la simulation. Ces constantes se trouvent de la ligne 6 à 13 et sont les suivantes :

- `blueTeamName`
- `redTeamName`
- `blueBattleCry`
- `redBattleCry`
- `minAttackPower`
- `maxAttackPower`
- `minHp`
- `maxHp`
