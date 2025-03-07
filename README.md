# Gissa Tal Spelet

## Beskrivning
Spelet "Gissa Tal" är ett enkelt talgissningsspel där användaren ska försöka gissa ett slumpmässigt tal mellan 1 och 20. Spelet ger användaren feedback baserat på deras gissning tills de gissar rätt. Antalet försök räknas och visas när användaren lyckas.

## Spelregler
1. **Slumpmässigt Tal**: Ett tal mellan 1 och 20 genereras slumpmässigt i början av spelet.
2. **Gissningar**: Användaren får gissa ett tal mellan 1 och 20.
3. **Feedback på Gissning**:
   - Om gissningen är för liten, kommer meddelandet "Det inmatade talet [tal] är för litet, försök igen." att visas.
   - Om gissningen är för stor, kommer meddelandet "Det inmatade talet [tal] är för stort, försök igen." att visas.
   - Om gissningen är rätt, visas meddelandet "Grattis du gissade rätt, det tog dig [Gissningar] försök." och spelet avslutas.
4. **Felaktiga Inmatningar**: Om användaren matar in ett tal mindre än 1 eller större än 20, kommer meddelandet "Du kan bara mata in ett tal mellan 1-20." att visas.

## Funktionalitet
- Användaren ombeds att skriva in ett tal mellan 1 och 20.
- Antalet gissningar hålls och visas efter att användaren gissat rätt.
- Spelet fortsätter tills användaren gissar rätt tal.
