# Stempling av arbeidstid

## Oppgave
Oppgaven går ut på å lage et enkelt stemplesystem der man skal kunne:
- Stemple inn
- Stemple ut
- Vise en liste av tidligere stemplinger

Du står fritt til å velge de teknologiene du ønsker å jobbe med for å løse oppgaven.
Det som ligger i repositoriet er ment til å hjelpe deg i gang med oppgaven, og bruker .NET og React som er de teknologiene vi i hovedsak bruker i Tidsbanken.

## Sette opp prosjekt
1. Fork dette prosjektet til din egen GitHub konto
2. Klon ned din fork av prosjektet
3. I Frontend mappen kjør: `npm i` for å installere nødvendige pakker, og `npm start` for å kjøre frontend.
4. I Backend mappen skal det ikke være nødvendig med noe ekstra oppsett, bare åpne og kjør prosjektet på din foretrukne måte.
5. Husk å committe og pushe før fristen for å gjøre endringer er ute.

Prosjektet er delt inn i to mapper.
- `Backend` inneholder et API med en eksempelkontroller, og bruker en sqlite database for å lagre informasjon om stemplinger (timelinjer)
- `Frontend` inneholder en ferdig oppsatt React+Vite template.

## Datastruktur
Databasen `TB.db` har kun en tabell: `Timeline` som har følgende struktur:
```cs
public record Timeline
{
    public Guid Id { get; init; } // PK
    public DateTimeOffset Start { get; init; }
    public DateTimeOffset End { get; init; }
    public string? Note { get; init; }
}
```

Lykke til!
