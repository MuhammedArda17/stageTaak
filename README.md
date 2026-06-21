# Inimco Developer Oefening

## Beschrijving
Een full-stack applicatie waar je gegevens van een persoon kan invoeren en verwerken. De applicatie berekent het aantal klinkers en medeklinkers in de naam, draait de naam om, en slaat de data op in een JSON bestand.

## Tech Stack
- **Frontend**: Angular 20
- **Backend**: .NET Core 9 REST API (C#)
- **Repository**: JSON bestand (persons.json)

## Projectstructuur

    inimco-developer-exercise/
    ├── InimcoApi/                  ← .NET Core REST API
    │   ├── Controllers/            ← API endpoints
    │   ├── Models/                 ← Data modellen
    │   ├── Services/               ← Business logica
    │   ├── Repositories/           ← Data opslag
    │   └── Program.cs              ← Startpunt
    └── frontend/                   ← Angular applicatie
        └── src/
            └── app/
                ├── models/         ← TypeScript interfaces
                └── services/       ← HTTP service

## Features
- Voornaam en achternaam invoeren
- Social skills dynamisch toevoegen
- Social media accounts toevoegen
- Aantal klinkers en medeklinkers tellen
- Naam omdraaien
- Data opslaan in JSON bestand
- Resultaat tonen in JSON formaat

## Hoe opstarten

### Vereisten
- .NET 9 SDK
- Node.js
- Angular CLI (`npm install -g @angular/cli`)

### Backend

    cd InimcoApi
    dotnet run

API draait op `http://localhost:5190`

### Frontend

    cd frontend
    ng serve

Frontend draait op `http://localhost:4200`

## API Endpoints

| Method | URL | Beschrijving |
|--------|-----|--------------|
| POST | /api/person | Persoon opslaan en resultaat berekenen |

### Voorbeeld request

    {
        "firstName": "John",
        "lastName": "Doe",
        "socialSkills": ["social", "fun", "coach"],
        "socialAccounts": [
            {
                "type": "Twitter",
                "address": "@JohnDoe"
            }
        ]
    }

### Voorbeeld response

    {
        "vowelCount": 3,
        "consonantCount": 4,
        "fullName": "John Doe",
        "reversedName": "eoD nhoJ",
        "person": { ... }
    }