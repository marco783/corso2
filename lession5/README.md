Vogliamo gestire l'inserimento e la lettura di un prodotto a una certa data.

Il prodotto ha come informazioni basilari quelle elementari come:
- Nome
- Data di scadenza (opzionale)
- Codice EAN

Le caratteristiche del prodotto principali sono:
Prezzo, sempre presente e con un range di date. Il range ha sempre una data di inizio e di fine e d è sempre presente.
Sconto, opzionale.Lo sconto ha un range di date sempre presente e a scaglioni di 5 punti.Da 5% a 50%.
 

L'applicazione avrà un API per l'inserimento del prodotto e due API per la lettura del prodotto. La prima estrae l'articolo ad una specifica data. Il secondo riporta lo storico di tutti i cambiamenti
 

Implementare il codice in modalità TDD (partendo dai test).

Integration test (Entity Framework, Dapper, Moq, Mongo VALUTATE VOI).